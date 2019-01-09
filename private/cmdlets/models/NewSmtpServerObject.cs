namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="SmtpServer" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"SmtpServerObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ISmtpServer))]
    public class NewSmtpServerObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="SmtpServer" /></summary>
        private Nutanix.Powershell.Models.ISmtpServer _smtpServer = new Nutanix.Powershell.Models.SmtpServer();
        /// <summary>Fully qualified domain name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Fully qualified domain name.")]
        public string AddressFqdn
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Address = _smtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _smtpServer.Server.Address.Fqdn = value;
            }
        }
        /// <summary>IPV4 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV4 address.")]
        public string AddressIp
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Address = _smtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _smtpServer.Server.Address.Ip = value;
            }
        }
        /// <summary>IPV6 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV6 address.")]
        public string AddressIpv6
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Address = _smtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _smtpServer.Server.Address.Ipv6 = value;
            }
        }
        /// <summary>Port Number</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Port Number")]
        public int AddressPort
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Address = _smtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _smtpServer.Server.Address.Port = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string[] ClusterNetworkEntityProxyTypeList
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.ProxyTypeList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsPassword
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Credentials = _smtpServer.Server.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _smtpServer.Server.Credentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsUsername
        {
            set
            {
                _smtpServer.Server = _smtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _smtpServer.Server.Credentials = _smtpServer.Server.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _smtpServer.Server.Credentials.Username = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string EmailAddress
        {
            set
            {
                _smtpServer.EmailAddress = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Type
        {
            set
            {
                _smtpServer.Type = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_smtpServer);
        }
    }
}