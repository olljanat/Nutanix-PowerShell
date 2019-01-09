namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterDomainServer" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterDomainServerObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterDomainServer))]
    public class NewClusterDomainServerObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterDomainServer" /></summary>
        private Nutanix.Powershell.Models.IClusterDomainServer _clusterDomainServer = new Nutanix.Powershell.Models.ClusterDomainServer();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsPassword
        {
            set
            {
                _clusterDomainServer.DomainCredentials = _clusterDomainServer.DomainCredentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterDomainServer.DomainCredentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsUsername
        {
            set
            {
                _clusterDomainServer.DomainCredentials = _clusterDomainServer.DomainCredentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterDomainServer.DomainCredentials.Username = value;
            }
        }
        /// <summary>
        /// Joined domain name. In 'put' request, empty name will unjoin thecluster from current domain.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Joined domain name. In 'put' request, empty name will unjoin thecluster from current domain.")]
        public string Name
        {
            set
            {
                _clusterDomainServer.Name = value;
            }
        }
        /// <summary>
        /// The IP of the nameserver that can resolve the domain name. Must setwhen joining the domain.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The IP of the nameserver that can resolve the domain name. Must setwhen joining the domain.")]
        public string Nameserver
        {
            set
            {
                _clusterDomainServer.Nameserver = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterDomainServer);
        }
    }
}