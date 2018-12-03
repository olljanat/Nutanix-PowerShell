namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>IP config.</summary>
    public partial class IpConfig : Nutanix.Powershell.Models.IIpConfig, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="DefaultGatewayIp" /> property.</summary>
        private string _defaultGatewayIp;

        /// <summary>Default gateway IP address.</summary>
        public string DefaultGatewayIp
        {
            get
            {
                return this._defaultGatewayIp;
            }
            set
            {
                this._defaultGatewayIp = value;
            }
        }
        /// <summary>Backing field for <see cref="DhcpOptions" /> property.</summary>
        private Nutanix.Powershell.Models.IDhcpOptions _dhcpOptions;

        /// <summary>Spec for defining DHCP options.</summary>
        public Nutanix.Powershell.Models.IDhcpOptions DhcpOptions
        {
            get
            {
                return this._dhcpOptions;
            }
            set
            {
                this._dhcpOptions = value;
            }
        }
        /// <summary>Backing field for <see cref="DhcpServerAddress" /> property.</summary>
        private Nutanix.Powershell.Models.IAddress _dhcpServerAddress;

        /// <summary>Host address.</summary>
        public Nutanix.Powershell.Models.IAddress DhcpServerAddress
        {
            get
            {
                return this._dhcpServerAddress;
            }
            set
            {
                this._dhcpServerAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="PoolList" /> property.</summary>
        private Nutanix.Powershell.Models.IIpPool[] _poolList;

        public Nutanix.Powershell.Models.IIpPool[] PoolList
        {
            get
            {
                return this._poolList;
            }
            set
            {
                this._poolList = value;
            }
        }
        /// <summary>Backing field for <see cref="PrefixLength" /> property.</summary>
        private int? _prefixLength;

        public int? PrefixLength
        {
            get
            {
                return this._prefixLength;
            }
            set
            {
                this._prefixLength = value;
            }
        }
        /// <summary>Backing field for <see cref="SubnetIp" /> property.</summary>
        private string _subnetIp;

        /// <summary>Subnet IP address.</summary>
        public string SubnetIp
        {
            get
            {
                return this._subnetIp;
            }
            set
            {
                this._subnetIp = value;
            }
        }
        /// <summary>Creates an new <see cref="IpConfig" /> instance.</summary>
        public IpConfig()
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
            await eventListener.AssertRegEx(nameof(DefaultGatewayIp),DefaultGatewayIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            await eventListener.AssertObjectIsValid(nameof(DhcpOptions), DhcpOptions);
            await eventListener.AssertObjectIsValid(nameof(DhcpServerAddress), DhcpServerAddress);
            if (PoolList != null ) {
                    for (int __i = 0; __i < PoolList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"PoolList[{__i}]", PoolList[__i]);
                    }
                  }
            await eventListener.AssertRegEx(nameof(SubnetIp),SubnetIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
    }
    /// IP config.
    public partial interface IIpConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string DefaultGatewayIp { get; set; }
        Nutanix.Powershell.Models.IDhcpOptions DhcpOptions { get; set; }
        Nutanix.Powershell.Models.IAddress DhcpServerAddress { get; set; }
        Nutanix.Powershell.Models.IIpPool[] PoolList { get; set; }
        int? PrefixLength { get; set; }
        string SubnetIp { get; set; }
    }
}