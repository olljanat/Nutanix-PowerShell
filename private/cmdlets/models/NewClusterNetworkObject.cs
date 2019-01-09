namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterNetwork" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterNetworkObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterNetwork))]
    public class NewClusterNetworkObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterNetwork" /></summary>
        private Nutanix.Powershell.Models.IClusterNetwork _clusterNetwork = new Nutanix.Powershell.Models.ClusterNetwork();
        /// <summary>Fully qualified domain name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Fully qualified domain name.")]
        public string AddressFqdn
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Address = _clusterNetwork.SmtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetwork.SmtpServer.Server.Address.Fqdn = value;
            }
        }
        /// <summary>IPV4 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV4 address.")]
        public string AddressIp
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Address = _clusterNetwork.SmtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetwork.SmtpServer.Server.Address.Ip = value;
            }
        }
        /// <summary>IPV6 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV6 address.")]
        public string AddressIpv6
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Address = _clusterNetwork.SmtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetwork.SmtpServer.Server.Address.Ipv6 = value;
            }
        }
        /// <summary>Port Number</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Port Number")]
        public int AddressPort
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Address = _clusterNetwork.SmtpServer.Server.Address ?? new Nutanix.Powershell.Models.Address();
                _clusterNetwork.SmtpServer.Server.Address.Port = value;
            }
        }
        /// <summary>
        /// Joined domain name. In 'put' request, empty name will unjoin thecluster from current domain.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Joined domain name. In 'put' request, empty name will unjoin thecluster from current domain.")]
        public string ClusterDomainServerName
        {
            set
            {
                _clusterNetwork.DomainServer = _clusterNetwork.DomainServer ?? new Nutanix.Powershell.Models.ClusterDomainServer();
                _clusterNetwork.DomainServer.Name = value;
            }
        }
        /// <summary>
        /// The IP of the nameserver that can resolve the domain name. Must setwhen joining the domain.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The IP of the nameserver that can resolve the domain name. Must setwhen joining the domain.")]
        public string ClusterDomainServerNameserver
        {
            set
            {
                _clusterNetwork.DomainServer = _clusterNetwork.DomainServer ?? new Nutanix.Powershell.Models.ClusterDomainServer();
                _clusterNetwork.DomainServer.Nameserver = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string[] ClusterNetworkEntityProxyTypeList
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.ProxyTypeList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsPassword
        {
            set
            {
                _clusterNetwork.DomainServer = _clusterNetwork.DomainServer ?? new Nutanix.Powershell.Models.ClusterDomainServer();
                _clusterNetwork.DomainServer.DomainCredentials = _clusterNetwork.DomainServer.DomainCredentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetwork.DomainServer.DomainCredentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsPassword1
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Credentials = _clusterNetwork.SmtpServer.Server.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetwork.SmtpServer.Server.Credentials.Password = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsUsername
        {
            set
            {
                _clusterNetwork.DomainServer = _clusterNetwork.DomainServer ?? new Nutanix.Powershell.Models.ClusterDomainServer();
                _clusterNetwork.DomainServer.DomainCredentials = _clusterNetwork.DomainServer.DomainCredentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetwork.DomainServer.DomainCredentials.Username = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string CredentialsUsername1
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Server = _clusterNetwork.SmtpServer.Server ?? new Nutanix.Powershell.Models.ClusterNetworkEntity();
                _clusterNetwork.SmtpServer.Server.Credentials = _clusterNetwork.SmtpServer.Server.Credentials ?? new Nutanix.Powershell.Models.Credentials();
                _clusterNetwork.SmtpServer.Server.Credentials.Username = value;
            }
        }
        /// <summary>
        /// The cluster IP address that provides external entities access tovarious cluster data services.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The cluster IP address that provides external entities access tovarious cluster data services.")]
        public string ExternalDataServicesIp
        {
            set
            {
                _clusterNetwork.ExternalDataServicesIp = value;
            }
        }
        /// <summary>The local IP of cluster visible externally.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The local IP of cluster visible externally.")]
        public string ExternalIp
        {
            set
            {
                _clusterNetwork.ExternalIp = value;
            }
        }
        /// <summary>External subnet for cross server communication. The format isIP/netmask.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "External subnet for cross server communication. The format isIP/netmask.")]
        public string ExternalSubnet
        {
            set
            {
                _clusterNetwork.ExternalSubnet = value;
            }
        }
        /// <summary>List of proxies to connect to the service centers.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of proxies to connect to the service centers.")]
        public Nutanix.Powershell.Models.IClusterNetworkEntity[] HttpProxyList
        {
            set
            {
                _clusterNetwork.HttpProxyList = value;
            }
        }
        /// <summary>HTTP proxy whitelist.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HTTP proxy whitelist.")]
        public Nutanix.Powershell.Models.IHttpProxyWhitelist[] HttpProxyWhitelist
        {
            set
            {
                _clusterNetwork.HttpProxyWhitelist = value;
            }
        }
        /// <summary>
        /// The internal subnet is local to every server - its not visibleoutside.iSCSI requests generated internally within the appliance(by
        /// user VMs or VMFS) are sent to the internal subnet. The format isIP/netmask.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The internal subnet is local to every server - its not visibleoutside.iSCSI requests generated internally within the appliance(by user VMs or VMFS) are sent to the internal subnet. The format isIP/netmask.")]
        public string InternalSubnet
        {
            set
            {
                _clusterNetwork.InternalSubnet = value;
            }
        }
        /// <summary>The cluster NAT'd or proxy IP which maps to the cluster local IP.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The cluster NAT'd or proxy IP which maps to the cluster local IP.")]
        public string MasqueradingIp
        {
            set
            {
                _clusterNetwork.MasqueradingIp = value;
            }
        }
        /// <summary>Port used together with masquerading_ip to connect to the cluster.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Port used together with masquerading_ip to connect to the cluster.")]
        public int MasqueradingPort
        {
            set
            {
                _clusterNetwork.MasqueradingPort = value;
            }
        }
        /// <summary>The list of IP addresses of the name servers.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of IP addresses of the name servers.")]
        public string[] NameServerIpList
        {
            set
            {
                _clusterNetwork.NameServerIpList = value;
            }
        }
        /// <summary>
        /// Comma separated list of subnets (of the form 'a.b.c.d/l.m.n.o') thatare allowed to send NFS requests to this container.
        /// If not specified,the global NFS whitelist will be looked up for access permission.The internal subnet is always automatically
        /// considered part of thewhitelist, even if the field below does not explicitly specify it.Similarly, all the hypervisor
        /// IPs are considered part of thewhitelist. Finally, to permit debugging, all of the SVMs local IPsare considered to be implicitly
        /// part of the whitelist.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Comma separated list of subnets (of the form 'a.b.c.d/l.m.n.o') thatare allowed to send NFS requests to this container. If not specified,the global NFS whitelist will be looked up for access permission.The internal subnet is always automatically considered part of thewhitelist, even if the field below does not explicitly specify it.Similarly, all the hypervisor IPs are considered part of thewhitelist. Finally, to permit debugging, all of the SVMs local IPsare considered to be implicitly part of the whitelist.")]
        public string[] NfsSubnetWhitelist
        {
            set
            {
                _clusterNetwork.NfsSubnetWhitelist = value;
            }
        }
        /// <summary>The list of IP addresses or FQDNs of the NTP servers.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The list of IP addresses or FQDNs of the NTP servers.")]
        public string[] NtpServerIpList
        {
            set
            {
                _clusterNetwork.NtpServerIpList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string SmtpServerEmailAddress
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.EmailAddress = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string SmtpServerType
        {
            set
            {
                _clusterNetwork.SmtpServer = _clusterNetwork.SmtpServer ?? new Nutanix.Powershell.Models.SmtpServer();
                _clusterNetwork.SmtpServer.Type = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterNetwork);
        }
    }
}