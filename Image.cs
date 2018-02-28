using System.Management.Automation;
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Nutanix {

public class Image {
  public string Name;
  public string Id;

  // 'Uid' is VMware's equivalent field for Nutanix's Uuid.
  public string Uid;
  public string Uuid;
  public dynamic json;

  // TODO Mtu, NumPorts, ExtensionData, NumPortsAvailable, Key, Nic, VMHostId,
  // VMHost, VMHostUid, Nic

  public Image(dynamic json) {
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

[CmdletAttribute(VerbsCommon.Get, "Image")]
public class GetImageCmdlet : Cmdlet {
  protected override void ProcessRecord() {
    WriteObject(GetAllImages());
  }

  public static Image[] GetAllImages() {
    var json = Util.RestCall("/images/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Image[0];
    }
    Image[] images = new Image[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      images[i] = new Image(json.entities[i]);
    }
    return images;
  }
}

}
