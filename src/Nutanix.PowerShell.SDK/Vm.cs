using System.Management.Automation;
using System;
using Newtonsoft.Json;

namespace Nutanix {
// VMware's struct definition.
// https://www.vmware.com/support/developer/PowerCLI/PowerCLI41U1/html/VirtualMachine.html
public class Vm {
  public static string PowerState_ON = "ON";
  public static string PowerState_OFF = "OFF";

  public string Name { get; set; }
  public string Uuid { get; set; }
  public string HardwareClockTimezone { get; set; }
  public int? NumSockets { get; set; }
  public int? MemoryMB { get; set; }
  public int? NumVcpusPerSocket { get; set; }
  public dynamic json { get; set; }
  public Vm(dynamic json) {
    // Special property 'json' stores the original json.
    this.json = json;
    this.json.api_version = "3.1";
    SetFromJson(json);
  }

  public void SetFromJson(dynamic json) {
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
  [Parameter]
  public string Name { get; set; } = string.Empty;

  [Parameter]
  public int MemorySizeMib { get; set; } = 1024; // 1 GiB

  [Parameter]
  public int NumSockets { get; set; } = 1;

  [Parameter]
  public int NumVcpusPerSocket { get; set; } = 1;

  [Parameter]
  public string PowerState { get; set; } = "OFF";

  [Parameter]
  public string ImageUuid { get; set; } = string.Empty;

  [Parameter]
  public string NetworkUuid { get; set; } = string.Empty;

  [Parameter]
  public string NetworkName { get; set; } = string.Empty;

  [Parameter]
  public string ImageName { get; set; } = string.Empty;

  [Parameter]
  public Cluster Cluster { get; set; }

  [Parameter]
  public SwitchParameter RunAsync
  {
    get { return runAsync; }
    set { runAsync = value; }
  }
  private bool runAsync;

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

    WriteDebug(Util.RestCallTrace(url, method, json.ToString()));

    // TODO: make cluster_reference required if talking to PC. But not needed
    // if talking to PE.
    var task = Task.FromUuidInJson(Util.RestCall(url, method, json.ToString()));
    if (runAsync) {
      WriteObject(task);
    }
    else {
      WriteObject(task.Wait());
    }
  }

  public static bool AddImage(
    dynamic json, string imageUuid, string imageName) {

    if (!string.IsNullOrEmpty(imageUuid)) {
      json.spec.resources.disk_list[0].data_source_reference.uuid = imageUuid;
    } else if (!string.IsNullOrEmpty(imageName)) {
      // TODO: grab images by name.
      var images = GetImageCmdlet.GetImagesByName(imageName);
      if (images.Length > 1) {
        Console.WriteLine(
          "Ambiguous: found more than 1 image with the same name");
        for (int i = 0; i < images.Length; ++i) {
          Console.WriteLine("Image " + i.ToString() + ": " + images[i].Uuid);
        }
        return false;
      }
      else {
        json.spec.resources.disk_list[0].data_source_reference.uuid =
          images[0].Uuid;
      }
    }
    return true;
  }

  public static bool AddNetwork(
    dynamic json, string networkUuid, string networkName) {

    if (!string.IsNullOrEmpty(networkUuid)) {
      json.spec.resources.nic_list[0].subnet_reference.uuid = networkUuid;
    } else if (!string.IsNullOrEmpty(networkName)) {
      // TODO: grab images by name.
      var networks = GetSubnetCmdlet.GetSubnetsByName(networkName);
      if (networks.Length > 1) {
        Console.WriteLine(
          "Ambiguous: found more than 1 Subnet with the same name");
        for (int i = 0; i < networks.Length; ++i) {
          Console.WriteLine("Network " + i.ToString() + ": " + networks[i].Uuid);
        }
        return false;
      }
      else {
        json.spec.resources.nic_list[0].subnet_reference.uuid =
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
  [Parameter]
  public string Name { get; set; } = string.Empty;

  [Parameter]
  public string Uuid { get; set; } = string.Empty;

  protected override void ProcessRecord() {
    if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Uuid)) {
      // If no params specified, then get all VMs.
      WriteObject(GetAllVms());
      return;
    }

    if (!string.IsNullOrEmpty(Uuid)) {
      WriteObject(GetVmByUuid(Uuid));
      return;
    }

    if (!string.IsNullOrEmpty(Name)) {
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
      throw new Exception("VM not found.");
    }
    // TODO: reconsider if we want to throw error on more than 1 VM.
    // if (json.entities.Count > 1) {
    //   throw new Exception("More than 1 VM found.");
    // }
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
  [Parameter]
  public string Uuid { get; set; } = string.Empty;

  [Parameter]
  public Vm VM { get; set; }

  [Parameter]
  public SwitchParameter RunAsync
  {
    get { return runAsync; }
    set { runAsync = value; }
  }
  private bool runAsync;

  protected override void ProcessRecord() {
    VM.json.spec.resources.power_state = Vm.PowerState_ON;
    VM.json.api_version = "3.1"; // TODO: remove api_version field set.
    var task = Task.FromUuidInJson(
      Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString()));
    if (runAsync) {
      WriteObject(task);
    }
    else {
      WriteObject(task.Wait());
    }
  }
}

[CmdletAttribute(VerbsCommon.Remove, "Vm")]
public class RemoveVmCmdlet : Cmdlet {
  [Parameter]
  public string Name { get; set; } = string.Empty;

  [Parameter]
  public string Uuid { get; set; } = string.Empty;

  [Parameter(Mandatory=true, ValueFromPipeline=true)]
  public Vm VM { get; set; }

  protected override void ProcessRecord() {
    if (VM != null) {
      Uuid = VM.Uuid;
    }

    if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Uuid)) {
      throw new Exception("Need -Name or -Uuid");
      return;
    }

    if (!string.IsNullOrEmpty(Uuid)) {
      WriteObject(DeleteVmByUuid(Uuid));
      return;
    }

    if (!string.IsNullOrEmpty(Name)) {
      WriteObject(DeleteVmByName(Name));
      return;
    }
  }

  // Delete Vm using 'uuid'.
  // REST path is /vms/{uuid}
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
  public Vm VM { get; set; }

  [Parameter]
  public string Name { get; set; }

  [Parameter]
  public string Description { get; set; }

  [Parameter]
  public int? MemoryMB { get; set; }

  // TODO: figure out Nutanix's analog for NumCpu.
  //       NumVcpusPerSocket is not correct.

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
