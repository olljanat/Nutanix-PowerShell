namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster network.</summary>
    public partial class ClusterNetwork : Nutanix.Powershell.Models.IClusterNetwork, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="DomainServer" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterDomainServer _domainServer;

        /// <summary>
        /// Cluster domain server. Only applied to the cluster with all Hyper-V hosts.
        /// </summary>
        public Nutanix.Powershell.Models.IClusterDomainServer DomainServer
        {
            get
            {
                return this._domainServer;
            }
            set
            {
                this._domainServer = value;
            }
        }
        /// <summary>Backing field for <see cref="ExternalDataServicesIp" /> property.</summary>
        private string _externalDataServicesIp;

        /// <summary>
        /// The cluster IP address that provides external entities access to
        /// various cluster data services.
        /// </summary>
        public string ExternalDataServicesIp
        {
            get
            {
                return this._externalDataServicesIp;
            }
            set
            {
                this._externalDataServicesIp = value;
            }
        }
        /// <summary>Backing field for <see cref="ExternalIp" /> property.</summary>
        private string _externalIp;

        /// <summary>The local IP of cluster visible externally.</summary>
        public string ExternalIp
        {
            get
            {
                return this._externalIp;
            }
            set
            {
                this._externalIp = value;
            }
        }
        /// <summary>Backing field for <see cref="ExternalSubnet" /> property.</summary>
        private string _externalSubnet;

        /// <summary>
        /// External subnet for cross server communication. The format is
        /// IP/netmask.
        /// </summary>
        public string ExternalSubnet
        {
            get
            {
                return this._externalSubnet;
            }
            set
            {
                this._externalSubnet = value;
            }
        }
        /// <summary>Backing field for <see cref="HttpProxyList" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterNetworkEntity[] _httpProxyList;

        /// <summary>List of proxies to connect to the service centers.</summary>
        public Nutanix.Powershell.Models.IClusterNetworkEntity[] HttpProxyList
        {
            get
            {
                return this._httpProxyList;
            }
            set
            {
                this._httpProxyList = value;
            }
        }
        /// <summary>Backing field for <see cref="HttpProxyWhitelist" /> property.</summary>
        private Nutanix.Powershell.Models.IHttpProxyWhitelist[] _httpProxyWhitelist;

        /// <summary>HTTP proxy whitelist.</summary>
        public Nutanix.Powershell.Models.IHttpProxyWhitelist[] HttpProxyWhitelist
        {
            get
            {
                return this._httpProxyWhitelist;
            }
            set
            {
                this._httpProxyWhitelist = value;
            }
        }
        /// <summary>Backing field for <see cref="InternalSubnet" /> property.</summary>
        private string _internalSubnet;

        /// <summary>
        /// The internal subnet is local to every server - its not visible
        /// outside.iSCSI requests generated internally within the appliance
        /// (by user VMs or VMFS) are sent to the internal subnet. The format is
        /// IP/netmask.
        /// </summary>
        public string InternalSubnet
        {
            get
            {
                return this._internalSubnet;
            }
            set
            {
                this._internalSubnet = value;
            }
        }
        /// <summary>Backing field for <see cref="MasqueradingIp" /> property.</summary>
        private string _masqueradingIp;

        /// <summary>
        /// The cluster NAT'd or proxy IP which maps to the cluster local IP.
        /// </summary>
        public string MasqueradingIp
        {
            get
            {
                return this._masqueradingIp;
            }
            set
            {
                this._masqueradingIp = value;
            }
        }
        /// <summary>Backing field for <see cref="MasqueradingPort" /> property.</summary>
        private int? _masqueradingPort;

        /// <summary>
        /// Port used together with masquerading_ip to connect to the cluster.
        /// </summary>
        public int? MasqueradingPort
        {
            get
            {
                return this._masqueradingPort;
            }
            set
            {
                this._masqueradingPort = value;
            }
        }
        /// <summary>Backing field for <see cref="NameServerIpList" /> property.</summary>
        private string[] _nameServerIpList;

        /// <summary>The list of IP addresses of the name servers.</summary>
        public string[] NameServerIpList
        {
            get
            {
                return this._nameServerIpList;
            }
            set
            {
                this._nameServerIpList = value;
            }
        }
        /// <summary>Backing field for <see cref="NfsSubnetWhitelist" /> property.</summary>
        private string[] _nfsSubnetWhitelist;

        /// <summary>
        /// Comma separated list of subnets (of the form 'a.b.c.d/l.m.n.o') that
        /// are allowed to send NFS requests to this container. If not specified,
        /// the global NFS whitelist will be looked up for access permission.
        /// The internal subnet is always automatically considered part of the
        /// whitelist, even if the field below does not explicitly specify it.
        /// Similarly, all the hypervisor IPs are considered part of the
        /// whitelist. Finally, to permit debugging, all of the SVMs local IPs
        /// are considered to be implicitly part of the whitelist.
        /// </summary>
        public string[] NfsSubnetWhitelist
        {
            get
            {
                return this._nfsSubnetWhitelist;
            }
            set
            {
                this._nfsSubnetWhitelist = value;
            }
        }
        /// <summary>Backing field for <see cref="NtpServerIpList" /> property.</summary>
        private string[] _ntpServerIpList;

        /// <summary>The list of IP addresses or FQDNs of the NTP servers.</summary>
        public string[] NtpServerIpList
        {
            get
            {
                return this._ntpServerIpList;
            }
            set
            {
                this._ntpServerIpList = value;
            }
        }
        /// <summary>Backing field for <see cref="SmtpServer" /> property.</summary>
        private Nutanix.Powershell.Models.ISmtpServer _smtpServer;

        /// <summary>SMTP Server.</summary>
        public Nutanix.Powershell.Models.ISmtpServer SmtpServer
        {
            get
            {
                return this._smtpServer;
            }
            set
            {
                this._smtpServer = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterNetwork" /> instance.</summary>
        public ClusterNetwork()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(DomainServer), DomainServer);
            await eventListener.AssertRegEx(nameof(ExternalDataServicesIp),ExternalDataServicesIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            await eventListener.AssertRegEx(nameof(ExternalIp),ExternalIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (HttpProxyList != null ) {
                    for (int __i = 0; __i < HttpProxyList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"HttpProxyList[{__i}]", HttpProxyList[__i]);
                    }
                  }
            if (HttpProxyWhitelist != null ) {
                    for (int __i = 0; __i < HttpProxyWhitelist.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"HttpProxyWhitelist[{__i}]", HttpProxyWhitelist[__i]);
                    }
                  }
            await eventListener.AssertRegEx(nameof(MasqueradingIp),MasqueradingIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (NameServerIpList != null ) {
                    for (int __i = 0; __i < NameServerIpList.Length; __i++) {
                      await eventListener.AssertRegEx($"NameServerIpList[{__i}]",NameServerIpList[__i],@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(SmtpServer), SmtpServer);
        }
    }
    /// Cluster network.
    public partial interface IClusterNetwork : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IClusterDomainServer DomainServer { get; set; }
        string ExternalDataServicesIp { get; set; }
        string ExternalIp { get; set; }
        string ExternalSubnet { get; set; }
        Nutanix.Powershell.Models.IClusterNetworkEntity[] HttpProxyList { get; set; }
        Nutanix.Powershell.Models.IHttpProxyWhitelist[] HttpProxyWhitelist { get; set; }
        string InternalSubnet { get; set; }
        string MasqueradingIp { get; set; }
        int? MasqueradingPort { get; set; }
        string[] NameServerIpList { get; set; }
        string[] NfsSubnetWhitelist { get; set; }
        string[] NtpServerIpList { get; set; }
        Nutanix.Powershell.Models.ISmtpServer SmtpServer { get; set; }
    }
}