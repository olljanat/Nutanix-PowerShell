using System.Management.Automation;
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Nutanix {

public class Subnet {
  public string Name;
  public string Id;

  // 'Uid' is VMware's equivalent field for Nutanix's Uuid.
  public string Uid;
  public string Uuid;
  public dynamic json;

  // TODO Mtu, NumPorts, ExtensionData, NumPortsAvailable, Key, Nic, VMHostId,
  // VMHost, VMHostUid, Nic

  public Subnet(dynamic json) {
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

[CmdletAttribute(VerbsCommon.Get, "VirtualSwitch")]
public class GetSubnetCmdlet : Cmdlet {

  // TODO: Name parameter to specify the names of subnets to retrieve.

  protected override void ProcessRecord() {
    WriteObject(GetAllSubnets());
  }

  public static Subnet[] GetAllSubnets() {
    var json = Util.RestCall("/subnets/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Subnet[0];
    }
    Console.WriteLine("break A: number of entities:" +
      json.entities.Count.ToString()); // XXX
    Subnet[] subnets = new Subnet[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      subnets[i] = new Subnet(json.entities[i]);
    }
    return subnets;
  }
}

}
