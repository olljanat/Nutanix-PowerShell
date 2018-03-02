using System.Management.Automation;
using System;

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

[CmdletAttribute(VerbsCommon.New, "VirtualSwitch")]
public class NewSubnetCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string VlanId { get; set; } = "";

  [Parameter()]
  public string Description { get; set; } = "";

  protected override void ProcessRecord() {
    Util.RestCall("/subnets", "POST", @"{
      ""api_version"": ""3.0"",
      ""metadata"": {
        ""kind"": ""subnet"",
        ""name"": """ + Name + @"""
      },
      ""spec"": {
        ""description"": """ + Description + @""",
        ""name"": """ + Name + @""",
        ""resources"": {
          ""subnet_type"": ""VLAN"",
          ""ip_config"": ""{}"",
          ""vlan_id"": """ + VlanId + @""",
          ""name"": """ + Name + @"""
        }
      }
    }");
  }
}

[CmdletAttribute(VerbsCommon.Get, "VirtualSwitch")]
public class GetSubnetCmdlet : Cmdlet {
  // TODO: Name parameter to specify the names of subnets to retrieve.
  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetSubnetByUuid(Uuid));
      return;
    }

    WriteObject(GetAllSubnets());
  }

  public static Subnet GetSubnetByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/subnets/" + uuid, "GET", "" /* requestBody */);
    return new Subnet(json);
  }

  public static Subnet[] GetAllSubnets() {
    var json = Util.RestCall("/subnets/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Subnet[0];
    }
    Subnet[] subnets = new Subnet[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      subnets[i] = new Subnet(json.entities[i]);
    }
    return subnets;
  }
}

[CmdletAttribute(VerbsCommon.Remove, "VirtualSwitch")]
public class DeleteSubnetCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  // TODO: Confirm, WhatIf params.
  // https://www.vmware.com/support/developer/PowerCLI/PowerCLI41U1/html/Remove-VirtualSwitch.html

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      // TODO: WriteObject Task
      DeleteSubnetByUuid(Uuid);
      return;
    }
  }

  public static void DeleteSubnetByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    Util.RestCall("/subnets/" + uuid, "DELETE", "" /* requestBody */);
  }
}

[CmdletAttribute(VerbsCommon.Set, "VirtualSwitch")]
public class SetSubnetCmdlet : Cmdlet {
  [Parameter(Mandatory=true)]
  public Subnet Subnet { get; set; } = null;

  [Parameter()]
  public string Name { get; set; } = null;

  [Parameter()]
  public string VlanId { get; set; } = null;

  protected override void ProcessRecord() {
    if (Name != null) {
      Subnet.json.spec.name = Name;
    }
    if (VlanId != null) {
      Subnet.json.spec.resources.vlan_id = VlanId;
    }
    Subnet.json.api_version = "3.1";
    Util.RestCall("/subnets/" + Subnet.Uuid, "PUT", Subnet.json.ToString());
  }

}

}
