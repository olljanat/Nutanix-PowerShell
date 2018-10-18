namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An IP address.</summary>
    public partial class IpAddress : Sample.API.Models.IIpAddress, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Ip property</summary>
        private string _ip;

        /// <summary>Address string.</summary>
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
        /// <summary>Backing field for Type property</summary>
        private string _type;

        /// <summary>
        /// Address type. It can only be "ASSIGNED" in the spec. If no type is
        /// specified in the spec, the default type is set to "ASSIGNED".
        /// </summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="IpAddress" /> instance.</summary>
        public IpAddress()
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
    /// An IP address.
    public partial interface IIpAddress : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Ip { get; set; }
        string Type { get; set; }
    }
}