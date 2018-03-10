using System.Management.Automation;
using System;
using Newtonsoft.Json;

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

  [Parameter()]
  public string ImageUuid { get; set; } = "";

  [Parameter()]
  public string NetworkUuid { get; set; } = "";

  [Parameter()]
  public string NetworkName { get; set; } = "";

  [Parameter()]
  public string ImageName { get; set; } = "";

  [Parameter()]
  public Cluster Cluster { get; set; } = null;

  [Parameter()]
  public SwitchParameter RunAsync
  {
    get { return runAsync; }
    set { runAsync = value; }
  }
  private bool runAsync;

  // Prints out REST URL and then exits. Does not make REST call.
  [Parameter()]
  public SwitchParameter Trace
  {
    get { return trace; }
    set { trace = value; }
  }
  private bool trace;

  protected override void ProcessRecord() {
    var url = "/vms";
    var method = "POST";
    var str = @"{
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
                ""kind"": ""image""
              },
              ""device_properties"": {
                ""device_type"": ""DISK""
              }
            }
          ],
          ""nic_list"": [
            {
              ""subnet_reference"": {
                ""kind"": ""subnet""
              }
            }
          ]
        },
        ""name"": """ + Name + @"""
      }
    }";
    dynamic json = JsonConvert.DeserializeObject(str);
    if (!AddImage(json, ImageUuid, ImageName)) {
      return;
    }
    if (!AddNetwork(json, NetworkUuid, NetworkName)) {
      return;
    }
    if (!AddCluster(json, Cluster)) {
      return;
    }

    if (trace) {
      Util.PrintTrace(url, method, json.ToString());
      return;
    }

    // TODO: make cluster_reference required if talking to PC. But not needed
    // if talking to PE.
    var task = Task.FromUuidInJson(Util.RestCall(url, method, json.ToString()));
    if (runAsync) {
      WriteObject(task);
    } else {
      WriteObject(task.Wait());
    }
  }

  public static bool AddImage(
    dynamic json, string ImageUuid, string ImageName) {

    if (!String.IsNullOrEmpty(ImageUuid)) {
      json.spec.resources.disk_list[0].data_source_reference.uuid = ImageUuid;
    } else if (!String.IsNullOrEmpty(ImageName)) {
      // TODO: grab images by name.
      var images = GetImageCmdlet.GetImagesByName(ImageName);
      if (images.Length > 1) {
        Console.WriteLine(
          "Ambiguous: found more than 1 image with the same name");
        for (int i = 0; i < images.Length; ++i) {
          Console.WriteLine("Image " + i.ToString() + ": " + images[i].Uuid);
        }
        return false;
      } else {
        json.spec.resouces.disk_list[0].data_source_reference.uuid =
          images[0].Uuid;
      }
    }
    return true;
  }

  public static bool AddNetwork(
    dynamic json, string NetworkUuid, string NetworkName) {

    if (!String.IsNullOrEmpty(NetworkUuid)) {
      json.spec.resources.nic_list[0].subnet_reference.uuid = NetworkUuid;
    } else if (!String.IsNullOrEmpty(NetworkName)) {
      // TODO: grab images by name.
      var networks = GetSubnetCmdlet.GetSubnetsByName(NetworkName);
      if (networks.Length > 1) {
        Console.WriteLine(
          "Ambiguous: found more than 1 Subnet with the same name");
        for (int i = 0; i < networks.Length; ++i) {
          Console.WriteLine("Network " + i.ToString() + ": " + networks[i].Uuid);
        }
        return false;
      } else {
        json.spec.resources.nic_list[0].subnet_source_reference.uuid =
          networks[0].Uuid;
      }
    }
    return true;
  }

  public static bool AddCluster(dynamic json, Cluster Cluster) {
    if (Cluster != null) {
      json.spec.cluster_reference = new Newtonsoft.Json.Linq.JObject();
      json.spec.cluster_reference.kind = "cluster";
      json.spec.cluster_reference.uuid = Cluster.Uuid;
      json.spec.cluster_reference.name = Cluster.Name;
    }
    return true;
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
      WriteObject(GetAllVms());
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
    WriteObject(Task.FromUuidInJson(
      Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString())));
  }
}

[CmdletAttribute(VerbsCommon.Remove, "Vm")]
public class RemoveVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string Uuid { get; set; } = "";

  [Parameter(Mandatory=true, ValueFromPipeline=true)]
  public Vm VM { get; set; } = null;

  protected override void ProcessRecord() {
    if (VM != null) {
      Uuid = VM.Uuid;
    }

    if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Uuid)) {
      throw new Exception("Need -Name or -Uuid");
      return;
    }

    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(DeleteVmByUuid(Uuid));
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      WriteObject(DeleteVmByName(Name));
      return;
    }
  }

  // Delete Vm using 'uuid'.
  // REST: /vms/{uuid}
  public static Task DeleteVmByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    return Task.FromUuidInJson(Util.RestCall("/vms/" + uuid, "DELETE", ""));
  }

  // If no params specified, then get VM with 'name'.
  // REST: /vms/list
  public static Task DeleteVmByName(string name) {
    var vm = GetVmCmdlet.GetVmByName(name);
    if (vm != null) {
      return Task.FromUuidInJson(Util.RestCall("/vms/" + vm.Uuid, "DELETE", ""));
    }
    return null;
  }
}

[CmdletAttribute(VerbsCommon.Set, "Vm")]
public class SetVmCmdlet : Cmdlet {
  [Parameter(Mandatory=true, ValueFromPipeline=true)]
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
    VM.json.Property("status").Remove();
    // TODO: return Task object from the RestCall.
    WriteObject(Task.FromUuidInJson(
      Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString())));
  }
}

}
