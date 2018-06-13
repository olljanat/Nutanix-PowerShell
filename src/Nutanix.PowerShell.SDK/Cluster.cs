// Purpose: Clusters (connection and information) source for 'Nutanix.PowerShell.SDK'
// Author: Nutanix
// Copyright: Nutanix, 2018
// Owner: PowerShell@nutanix.com
// Maintainer(s):
//   Jon Kohler  (Nutanix, JonKohler)
//   Alex Guo    (Nutanix, mallochine)

using System;
using System.Management.Automation;

namespace Nutanix
{
  public class Cluster
  {
    public string Name { get; set; }

    public string Uuid { get; set; }

    public Cluster(dynamic json)
    {
      Uuid = json.metadata.uuid;
      Name = json.spec.name;
    }
  }

  [CmdletAttribute(VerbsCommon.Get, "Cluster")]
  public class GetClusterCmdlet : Cmdlet
  {
    protected override void ProcessRecord()
    {
      WriteObject(GetAllClusters());
    }

    // Grab all VMs.
    // REST: /clusters/list
    public static Cluster[] GetAllClusters()
    {
      var json = Util.RestCall("/clusters/list", "POST", "{}");
      if (json.entities.Count == 0)
      {
        return new Cluster[0];
      }

      Cluster[] clusters = new Cluster[json.entities.Count];
      for (int i = 0; i < json.entities.Count; ++i)
      {
        clusters[i] = new Cluster(json.entities[i]);
      }

      return clusters;
    }
  }

  [CmdletAttribute(VerbsCommunications.Connect, "Cluster")]
  public class ConnectClusterCmdlet : Cmdlet
  {
    [Parameter]
    public string Server { get; set; } = string.Empty;

    [Parameter]
    public string UserName { get; set; } = string.Empty;

    // TODO: note that 'Password' should be the result of
    // 'ConvertTo-SecureString'
    [Parameter]
    public System.Security.SecureString Password { get; set; } =
      new System.Security.SecureString();

    [Parameter]
    public SwitchParameter AcceptInvalidSslCerts
    {
      get { return acceptInvalidSslCerts; }
      set { acceptInvalidSslCerts = value; }
    }
    private bool acceptInvalidSslCerts;

    protected override void ProcessRecord()
    {
      Connect(Server, UserName, Password, acceptInvalidSslCerts);
    }

    // Save authentication info.
    public static void Connect(
      string server,
      string username,
      System.Security.SecureString password,
      bool acceptinvalidsslcerts)
    {
      if (acceptinvalidsslcerts)
      {
        Util.TestOnlyIgnoreCerts();
      }
      Util.Server = server;
      Util.PSCreds = new System.Management.Automation.PSCredential(
        username, password);
    }
  }
}
