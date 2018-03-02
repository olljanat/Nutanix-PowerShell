using System.Management.Automation;
using System;

// This is the exception that VMware's PowerCLI throws on error.
public class VimException : Exception {
  public VimException():base() { }
  public VimException (string message): base(message) { }
}

namespace Nutanix {

// VMware's struct definition.
// https://www.vmware.com/support/developer/PowerCLI/PowerCLI41U1/html/VirtualMachine.html
public class Vm {
  public const string PowerState_ON = "ON";
  public const string PowerState_OFF = "OFF";

  public string Name;
  public string Uuid;
  public string HardwareClockTimezone;
  public int? NumSockets;
  public int? MemoryMB;
  public int? NumVcpusPerSocket;
  public dynamic json;
  public Vm(dynamic json) {

    // Special property 'json' stores the original json.
    this.json = json;
    this.json.Property("status").Remove();
    this.json.api_version = "3.1";

    // Fill in field.
    Name = json.spec.name;
    NumSockets = json.spec.resources.num_sockets;
    MemoryMB = json.spec.resources.memory_size_mib;
    NumVcpusPerSocket = json.spec.resources.num_vcpus_per_socket;
    HardwareClockTimezone = json.spec.resources.hardware_clock_timezone;
    Uuid = json.metadata.uuid;
  }
}

[CmdletAttribute(VerbsCommon.New, "Vm")]
public class NewVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public int MemorySizeMib { get; set; } = 1024; // 1 GiB

  [Parameter()]
  public int NumSockets { get; set; } = 1;

  [Parameter()]
  public int NumVcpusPerSocket { get; set; } = 1;

  [Parameter()]
  public string PowerState { get; set; } = "OFF";

  // TODO: remove Mandatory. Allow a user to get image uuid via name.
  [Parameter(Mandatory=true)]
  public string ImageUuid { get; set; } = "";

  // TODO: allow creation of non-networked VMs by creating 'nic_list' iff
  // 'NetworkUuid' was passed in.
  [Parameter(Mandatory=true)]
  public string NetworkUuid { get; set; } = "";

  protected override void ProcessRecord() {
    // TODO: make cluster_reference required if talking to PC. But not needed
    // if talking to PE.
    Util.RestCall("/vms", "POST", @"{
      ""api_version"": ""3.0"",
      ""metadata"": {
        ""kind"": ""vm""
      },
      ""spec"": {
        ""resources"": {
          ""memory_size_mib"": " + MemorySizeMib.ToString() + @",
          ""num_vcpus_per_socket"": " + NumVcpusPerSocket.ToString() + @",
          ""num_sockets"": " + NumSockets.ToString() + @",
          ""power_state"": """ + PowerState + @""",
          ""disk_list"": [
            {
              ""data_source_reference"": {
                ""kind"": ""image"",
                ""uuid"": """ + ImageUuid + @"""
              },
              ""device_properties"": {
                ""device_type"": ""DISK""
              }
            }
          ],
          ""nic_list"": [
            {
              ""subnet_reference"": {
                ""kind"": ""subnet"",
                ""uuid"": """ + NetworkUuid + @"""
              }
            }
          ]
        },
        ""name"": """ + Name + @"""
      }
    }");
  }
}

[CmdletAttribute(VerbsCommon.Get, "Vm")]
public class GetVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Uuid)) {
      // If no params specified, then get all VMs.
      GetAllVms();
      return;
    }

    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetVmByUuid(Uuid));
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      WriteObject(GetVmByName(Name));
      return;
    }
  }

  // Grab all VMs.
  // REST: /vms/list
  public static Vm[] GetAllVms() {
    var json = Util.RestCall("/vms/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Vm[0];
    }
    Vm[] vms = new Vm[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      vms[i] = new Vm(json.entities[i]);
    }
    return vms;
  }

  // If no params specified, then get VM with 'name'.
  // REST: /vms/list
  public static Vm GetVmByName(string name) {
    var reqBody = "{\"filter\": \"vm_name==" + name + "\"}";
    var json = Util.RestCall("/vms/list", "POST", reqBody);
    if (json.entities.Count == 0) {
      return null;
    }
    return new Vm(json.entities[0]);
  }

  // Get Vm using 'uuid'.
  // REST: /vms/{uuid}
  public static Vm GetVmByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/vms/" + uuid, "GET", "" /* requestBody */);
    return new Vm(json);
  }
}

[CmdletAttribute("Start", "Vm")]
public class StartVmCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  [Parameter()]
  public Vm VM { get; set; } = null;

  protected override void ProcessRecord() {
    // TODO: maybe should not rely on 'json' to generate request?
    VM.json.spec.resources.power_state = Vm.PowerState_ON;
    VM.json.api_version = "3.1"; // TODO: remove api_version field set.
    // TODO: return Task object from the RestCall.
    Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString());
  }
}

[CmdletAttribute(VerbsCommon.Remove, "Vm")]
public class RemoveVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Uuid)) {
      // TODO: return error
      return;
    }

    if (!String.IsNullOrEmpty(Uuid)) {
      // TODO: WriteObject Task
      DeleteVmByUuid(Uuid);
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      // TODO: WriteObject Task
      DeleteVmByName(Name);
      return;
    }
  }

  // Delete Vm using 'uuid'.
  // REST: /vms/{uuid}
  public static void DeleteVmByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    Util.RestCall("/vms/" + uuid, "DELETE", "" /* requestBody */);
  }

  // If no params specified, then get VM with 'name'.
  // REST: /vms/list
  public static void DeleteVmByName(string name) {
    var vm = GetVmCmdlet.GetVmByName(name);
    if (vm != null) {
      Util.RestCall("/vms/" + vm.Uuid, "DELETE", "" /* requestBody */);
    }
  }
}

[CmdletAttribute(VerbsCommon.Set, "Vm")]
public class SetVmCmdlet : Cmdlet {
  [Parameter()]
  public Vm VM { get; set; } = null;

  [Parameter()]
  public string Name { get; set; } = null;

  [Parameter()]
  public string Description { get; set; } = null;

  [Parameter()]
  public int? MemoryMB { get; set; } = null;

  // TODO: figure out Nutanix's analog for NumCpu. NumVcpusPerSocket is not
  // correct.

  protected override void ProcessRecord() {
    // TODO: maybe should not rely on 'json' to generate request?
    if (Name != null) {
      VM.json.spec.name = Name;
    }
    if (Description != null) {
      VM.json.spec.description = Description;
    }
    if (MemoryMB != null) {
      VM.json.spec.resources.memory_size_mib = MemoryMB;
    }
    VM.json.api_version = "3.1";
    // TODO: return Task object from the RestCall.
    Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString());
  }
}

}
