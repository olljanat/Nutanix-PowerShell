namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="ClientAuth" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClientAuthObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClientAuth))]
    public class NewClientAuthObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClientAuth" /></summary>
        private Nutanix.Powershell.Models.IClientAuth _clientAuth = new Nutanix.Powershell.Models.ClientAuth();
        /// <summary>Content of CA chain certificate.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Content of CA chain certificate.")]
        public byte[] CaChain
        {
            set
            {
                _clientAuth.CaChain = value;
            }
        }
        /// <summary>Name of CA chain file.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of CA chain file.")]
        public string Name
        {
            set
            {
                _clientAuth.Name = value;
            }
        }
        /// <summary>Status of client authentication.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Status of client authentication.")]
        public string Status
        {
            set
            {
                _clientAuth.Status = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clientAuth);
        }
    }
}