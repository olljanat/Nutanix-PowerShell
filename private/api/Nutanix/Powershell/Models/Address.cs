namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Host address.</summary>
    public partial class Address : Nutanix.Powershell.Models.IAddress, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Fqdn" /> property.</summary>
        private string _fqdn;

        /// <summary>Fully qualified domain name.</summary>
        public string Fqdn
        {
            get
            {
                return this._fqdn;
            }
            set
            {
                this._fqdn = value;
            }
        }
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
        /// <summary>Backing field for <see cref="Ipv6" /> property.</summary>
        private string _ipv6;

        /// <summary>IPV6 address.</summary>
        public string Ipv6
        {
            get
            {
                return this._ipv6;
            }
            set
            {
                this._ipv6 = value;
            }
        }
        /// <summary>Backing field for <see cref="Port" /> property.</summary>
        private int? _port;

        /// <summary>Port Number</summary>
        public int? Port
        {
            get
            {
                return this._port;
            }
            set
            {
                this._port = value;
            }
        }
        /// <summary>Creates an new <see cref="Address" /> instance.</summary>
        public Address()
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
            await eventListener.AssertRegEx(nameof(Ipv6),Ipv6,@"(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))");
        }
    }
    /// Host address.
    public partial interface IAddress : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Fqdn { get; set; }
        string Ip { get; set; }
        string Ipv6 { get; set; }
        int? Port { get; set; }
    }
}