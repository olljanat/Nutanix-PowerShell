using System;
using System.Management.Automation;

namespace Nutanix
{
  public class VolumeGroup
  {
    public string Name { get; set; } = string.Empty;
    public string Id { get; set; } = string.Empty;

    // 'Uid' is VMware's equivalent field for Nutanix's Uuid.
    public string Uid { get; set; } = string.Empty;
    public string Uuid { get; set; } = string.Empty;
    public dynamic json { get; set; }

    // TODO Mtu, NumPorts, ExtensionData, NumPortsAvailable, Key, Nic, VMHostId,
    // VMHost, VMHostUid, Nic

    public VolumeGroup(dynamic json)
    {
      // Special property 'json' stores the original json.
      this.json = json;
      this.json.Property("status").Remove();
      this.json.api_version = "3.1";

      Name = json.spec.name;
      Uuid = json.metadata.uuid;
      Uid = Uuid;
    }
  }

  [CmdletAttribute(VerbsCommon.New, "VolumeGroup")]
  public class NewVolumeGroupCmdlet : Cmdlet
  {
    [Parameter]
    public string Name { get; set; } = string.Empty;

    protected override void ProcessRecord()
    {
      // // TODO: make cluster_reference required if talking to PC. But not needed
      // // if talking to PE.
      // Util.RestCall("/volume_groups", "POST", @"{
      //   ""api_version"": ""3.0"",
      //   ""metadata"": {
      //     ""kind"": ""volume_group""
      //   },
      //   ""spec"": {
      //     ""resources"": {
      //       ""memory_size_mib"": " + MemorySizeMib.ToString() + @",
      //       ""num_vcpus_per_socket"": " + NumVcpusPerSocket.ToString() + @",
      //       ""num_sockets"": " + NumSockets.ToString() + @",
      //       ""power_state"": """ + PowerState + @""",
      //       ""disk_list"": [
      //         {
      //           ""index"": ""0"",
      //           ""data_source_reference"": {
      //             ""kind"": ""image"",
      //             ""uuid"": """ + ImageUuid + @"""
      //           },
      //           ""disk_size_mib"": """ +  + @"""
      //         }
      //       ]
      //     },
      //     ""name"": """ + Name + @"""
      //   }
      // }");
    }
  }

  [CmdletAttribute(VerbsCommon.Get, "VolumeGroup")]
  public class GetVolumeGroupCmdlet : Cmdlet
  {
    [Parameter]
    public string Uuid { get; set; } = string.Empty;

    protected override void ProcessRecord()
    {
      if (!string.IsNullOrEmpty(Uuid))
      {
        WriteObject(GetVolumeGroupByUuid(Uuid));
        return;
      }

      WriteObject(GetAllVolumeGroups());
    }

    public static VolumeGroup GetVolumeGroupByUuid(string uuid)
    {
      // TODO: validate using UUID regexes that 'uuid' is in correct format.
      var json = Util.RestCall("/volume_groups/" + uuid, "GET", string.Empty /* requestBody */ );
      return new VolumeGroup(json);
    }

    public static VolumeGroup[] GetAllVolumeGroups()
    {
      var json = Util.RestCall("/volume_groups/list", "POST", "{}");
      if (json.entities.Count == 0)
      {
        return new VolumeGroup[0];
      }
      VolumeGroup[] volume_groups = new VolumeGroup[json.entities.Count];
      for (int i = 0; i < json.entities.Count; ++i)
      {
        volume_groups[i] = new VolumeGroup(json.entities[i]);
      }
      return volume_groups;
    }
  }

  [CmdletAttribute(VerbsCommon.Remove, "VolumeGroup")]
  public class DeleteVolumeGroupCmdlet : Cmdlet
  {
    [Parameter]
    public string Uuid { get; set; } = string.Empty;

    protected override void ProcessRecord()
    {
      if (!string.IsNullOrEmpty(Uuid))
      {
        // TODO: WriteObject Task
        DeleteVolumeGroupByUuid(Uuid);
        return;
      }
    }

    public static void DeleteVolumeGroupByUuid(string uuid)
    {
      // TODO: validate using UUID regexes that 'uuid' is in correct format.
      Util.RestCall("/volume_groups/" + uuid, "DELETE", string.Empty /* requestBody */ );
    }
  }

}