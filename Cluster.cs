using System.Management.Automation;
using System;

namespace Nutanix {

public class Cluster {
  public string Name;
  public string Uuid;
  public Cluster(dynamic json) {
    Uuid = json.metadata.uuid;
    Name = json.spec.name;
  }
}

[CmdletAttribute(VerbsCommon.Get, "Cluster")]
public class GetClusterCmdlet : Cmdlet {
  protected override void ProcessRecord() {
    WriteObject(GetAllClusters());
  }

  // Grab all VMs.
  // REST: /clusters/list
  public static Cluster[] GetAllClusters() {
    var json = Util.RestCall("/clusters/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Cluster[0];
    }
    Cluster[] clusters = new Cluster[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      clusters[i] = new Cluster(json.entities[i]);
    }
    return clusters;
  }
}

}
