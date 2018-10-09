namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster network entity.</summary>
    public partial class ClusterNetworkEntity : Sample.API.Models.IClusterNetworkEntity, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Address property</summary>
        private Sample.API.Models.IAddress _address;

        /// <summary>Host address.</summary>
        public Sample.API.Models.IAddress Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        /// <summary>Backing field for Credentials property</summary>
        private Sample.API.Models.ICredentials _credentials;

        /// <summary>Credentials to login server</summary>
        public Sample.API.Models.ICredentials Credentials
        {
            get
            {
                return this._credentials;
            }
            set
            {
                this._credentials = value;
            }
        }
        /// <summary>Backing field for ProxyTypeList property</summary>
        private string[] _proxyTypeList;

        public string[] ProxyTypeList
        {
            get
            {
                return this._proxyTypeList;
            }
            set
            {
                this._proxyTypeList = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterNetworkEntity" /> instance.</summary>
        public ClusterNetworkEntity()
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
            await eventListener.AssertNotNull(nameof(Address), Address);
            await eventListener.AssertObjectIsValid(nameof(Address), Address);
            await eventListener.AssertObjectIsValid(nameof(Credentials), Credentials);
        }
    }
    /// Cluster network entity.
    public partial interface IClusterNetworkEntity : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IAddress Address { get; set; }
        Sample.API.Models.ICredentials Credentials { get; set; }
        string[] ProxyTypeList { get; set; }
    }
}