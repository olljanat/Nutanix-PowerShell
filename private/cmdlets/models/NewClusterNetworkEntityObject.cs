namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterNetworkEntity" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterNetworkEntityObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterNetworkEntity))]
    public class NewClusterNetworkEntityObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterNetworkEntity" /></summary>
        private Nutanix.Powershell.Models.IClusterNetworkEntity _clusterNetworkEntity = new Nutanix.Powershell.Models.ClusterNetworkEntity();
        /// <summary>Fully qualified domain name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Fully qualified domain name.")]
        public string AddressFqdn
        {
            set
            {
                _clusterNetworkEntity.Address = _clusterNetworkEntity.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetworkEntity.Address.Fqdn = value;
            }
        }
        /// <summary>IPV4 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV4 address.")]
        public string AddressIp
        {
            set
            {
                _clusterNetworkEntity.Address = _clusterNetworkEntity.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetworkEntity.Address.Ip = value;
            }
        }
        /// <summary>IPV6 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV6 address.")]
        public string AddressIpv6
        {
            set
            {
                _clusterNetworkEntity.Address = _clusterNetworkEntity.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetworkEntity.Address.Ipv6 = value;
            }
        }
        /// <summary>Port Number</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Port Number")]
        public int AddressPort
        {
            set
            {
                _clusterNetworkEntity.Address = _clusterNetworkEntity.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetworkEntity.Address.Port = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsPassword
        {
            set
            {
                _clusterNetworkEntity.Credentials = _clusterNetworkEntity.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetworkEntity.Credentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsUsername
        {
            set
            {
                _clusterNetworkEntity.Credentials = _clusterNetworkEntity.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetworkEntity.Credentials.Username = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string[] ProxyTypeList
        {
            set
            {
                _clusterNetworkEntity.ProxyTypeList = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterNetworkEntity);
        }
    }
}