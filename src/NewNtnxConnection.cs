using System.Management.Automation;

[CmdletAttribute(VerbsCommon.New, "NtnxConnection")]
public class ConnectNTNX : Cmdlet {
  [Parameter()]
  public string Server { get; set; } = "";

  [Parameter()]
  public string UserName { get; set; } = "";

  // TODO: note that 'Password' should be the result of
  // 'ConvertTo-SecureString'
  [Parameter()]
  public System.Security.SecureString Password { get; set; } =
    new System.Security.SecureString();

  [Parameter()]
  public SwitchParameter AcceptInvalidSslCerts
  {
    get { return acceptInvalidSslCerts; }
    set { acceptInvalidSslCerts = value; }
  }
  private bool acceptInvalidSslCerts;

  protected override void ProcessRecord() {
    Connect(Server, UserName, Password, acceptInvalidSslCerts);
  }

  // Save authentication info.
  public static void Connect(
    string server, string username, System.Security.SecureString password,
    bool acceptinvalidsslcerts) {

    if (acceptinvalidsslcerts) {
      Util.TestOnlyIgnoreCerts();
    }
    Util.server = server;
    Util.pscreds = new System.Management.Automation.PSCredential(
      username, password);
  }
}
