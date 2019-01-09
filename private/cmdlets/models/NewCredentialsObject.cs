namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="Credentials" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CredentialsObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICredentials))]
    public class NewCredentialsObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Credentials" /></summary>
        private Nutanix.Powershell.Models.ICredentials _credentials = new Nutanix.Powershell.Models.Credentials();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Password
        {
            set
            {
                _credentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Username
        {
            set
            {
                _credentials.Username = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_credentials);
        }
    }
}