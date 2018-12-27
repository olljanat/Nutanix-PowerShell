namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>IP subnet provided as an address and prefix length.</summary>
    public partial class IpSubnet : Nutanix.Powershell.Models.IIpSubnet, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Ip" /> property.</summary>
        private string _ip;

        /// <summary>IPV4 address.</summary>
        public string Ip
        {
            get
            {
                return this._ip;
            }
            set
            {
                this._ip = value;
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
        /// <summary>Creates an new <see cref="IpSubnet" /> instance.</summary>
        public IpSubnet()
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
            await eventListener.AssertRegEx(nameof(Ip),Ip,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
    }
    /// IP subnet provided as an address and prefix length.
    public partial interface IIpSubnet : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Ip { get; set; }
        int? PrefixLength { get; set; }
    }
}