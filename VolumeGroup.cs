using System.Management.Automation;
using System;

namespace Nutanix {

public class VolumeGroup {
  public string Name;
  public string Id;

  // 'Uid' is VMware's equivalent field for Nutanix's Uuid.
  public string Uid;
  public string Uuid;
  public dynamic json;

  // TODO Mtu, NumPorts, ExtensionData, NumPortsAvailable, Key, Nic, VMHostId,
  // VMHost, VMHostUid, Nic

  public VolumeGroup(dynamic json) {
    // Special property 'json' stores the original json.
    this.json = json;
    this.json.Property("status").Remove();
    this.json.api_version = "3.1";

    Name = json.spec.name;
    Id = json.spec.resources.vlan_id;
    Uuid = json.metadata.uuid;
    Uid = Uuid;
  }
}

[CmdletAttribute(VerbsCommon.Get, "VolumeGroup")]
public class GetVolumeGroupCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetVolumeGroupByUuid(Uuid));
      return;
    }

    WriteObject(GetAllVolumeGroups());
  }

  public static VolumeGroup GetVolumeGroupByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/volume_groups/" + uuid, "GET", "" /* requestBody */);
    return new VolumeGroup(json);
  }

  public static VolumeGroup[] GetAllVolumeGroups() {
    var json = Util.RestCall("/volume_groups/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new VolumeGroup[0];
    }
    VolumeGroup[] volume_groups = new VolumeGroup[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      volume_groups[i] = new VolumeGroup(json.entities[i]);
    }
    return volume_groups;
  }
}

[CmdletAttribute(VerbsCommon.Remove, "VolumeGroup")]
public class DeleteVolumeGroupCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      // TODO: WriteObject Task
      DeleteVolumeGroupByUuid(Uuid);
      return;
    }
  }

  public static void DeleteVolumeGroupByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    Util.RestCall("/volume_groups/" + uuid, "DELETE", "" /* requestBody */);
  }
}

}
