namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Network rule</summary>
    public partial class NetworkRule : Nutanix.Powershell.Models.INetworkRule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private string _expirationTime;

        /// <summary>Timestamp of expiration time.</summary>
        public string ExpirationTime
        {
            get
            {
                return this._expirationTime;
            }
            set
            {
                this._expirationTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryFilter _filter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Nutanix.Powershell.Models.ICategoryFilter Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
            }
        }
        /// <summary>Backing field for <see cref="IcmpTypeCodeList" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkRuleIcmpTypeCodeListItemType[] _icmpTypeCodeList;

        /// <summary>List of ICMP types and codes allowed by this rule.</summary>
        public Nutanix.Powershell.Models.INetworkRuleIcmpTypeCodeListItemType[] IcmpTypeCodeList
        {
            get
            {
                return this._icmpTypeCodeList;
            }
            set
            {
                this._icmpTypeCodeList = value;
            }
        }
        /// <summary>Backing field for <see cref="IpSubnet" /> property.</summary>
        private Nutanix.Powershell.Models.IIpSubnet _ipSubnet;

        /// <summary>IP subnet provided as an address and prefix length.</summary>
        public Nutanix.Powershell.Models.IIpSubnet IpSubnet
        {
            get
            {
                return this._ipSubnet;
            }
            set
            {
                this._ipSubnet = value;
            }
        }
        /// <summary>Backing field for <see cref="NetworkFunctionChainReference" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkFunctionChainReference _networkFunctionChainReference;

        /// <summary>The reference to a network_function_chain</summary>
        public Nutanix.Powershell.Models.INetworkFunctionChainReference NetworkFunctionChainReference
        {
            get
            {
                return this._networkFunctionChainReference;
            }
            set
            {
                this._networkFunctionChainReference = value;
            }
        }
        /// <summary>Backing field for <see cref="PeerSpecificationType" /> property.</summary>
        private string _peerSpecificationType;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public string PeerSpecificationType
        {
            get
            {
                return this._peerSpecificationType;
            }
            set
            {
                this._peerSpecificationType = value;
            }
        }
        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>
        /// Select a protocol to allow. Multiple protocols can be allowed by repeating network_rule object. If a protocol is not configured
        /// in the network_rule object then it is allowed.
        /// </summary>
        public string Protocol
        {
            get
            {
                return this._protocol;
            }
            set
            {
                this._protocol = value;
            }
        }
        /// <summary>Backing field for <see cref="TcpPortRangeList" /> property.</summary>
        private Nutanix.Powershell.Models.IPortRange[] _tcpPortRangeList;

        /// <summary>List of TCP ports that are allowed by this rule.</summary>
        public Nutanix.Powershell.Models.IPortRange[] TcpPortRangeList
        {
            get
            {
                return this._tcpPortRangeList;
            }
            set
            {
                this._tcpPortRangeList = value;
            }
        }
        /// <summary>Backing field for <see cref="UdpPortRangeList" /> property.</summary>
        private Nutanix.Powershell.Models.IPortRange[] _udpPortRangeList;

        /// <summary>List of UDP ports that are allowed by this rule.</summary>
        public Nutanix.Powershell.Models.IPortRange[] UdpPortRangeList
        {
            get
            {
                return this._udpPortRangeList;
            }
            set
            {
                this._udpPortRangeList = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkRule" /> instance.</summary>
        public NetworkRule()
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
            await eventListener.AssertMaximumLength(nameof(ExpirationTime),ExpirationTime,64);
            await eventListener.AssertObjectIsValid(nameof(Filter), Filter);
            if (IcmpTypeCodeList != null ) {
                    for (int __i = 0; __i < IcmpTypeCodeList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"IcmpTypeCodeList[{__i}]", IcmpTypeCodeList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(IpSubnet), IpSubnet);
            await eventListener.AssertObjectIsValid(nameof(NetworkFunctionChainReference), NetworkFunctionChainReference);
            if (TcpPortRangeList != null ) {
                    for (int __i = 0; __i < TcpPortRangeList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"TcpPortRangeList[{__i}]", TcpPortRangeList[__i]);
                    }
                  }
            if (UdpPortRangeList != null ) {
                    for (int __i = 0; __i < UdpPortRangeList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"UdpPortRangeList[{__i}]", UdpPortRangeList[__i]);
                    }
                  }
        }
    }
    /// Network rule
    public partial interface INetworkRule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ExpirationTime { get; set; }
        Nutanix.Powershell.Models.ICategoryFilter Filter { get; set; }
        Nutanix.Powershell.Models.INetworkRuleIcmpTypeCodeListItemType[] IcmpTypeCodeList { get; set; }
        Nutanix.Powershell.Models.IIpSubnet IpSubnet { get; set; }
        Nutanix.Powershell.Models.INetworkFunctionChainReference NetworkFunctionChainReference { get; set; }
        string PeerSpecificationType { get; set; }
        string Protocol { get; set; }
        Nutanix.Powershell.Models.IPortRange[] TcpPortRangeList { get; set; }
        Nutanix.Powershell.Models.IPortRange[] UdpPortRangeList { get; set; }
    }
}