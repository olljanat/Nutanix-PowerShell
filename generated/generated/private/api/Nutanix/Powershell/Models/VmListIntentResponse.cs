namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operation of vms</summary>
    public partial class VmListIntentResponse : Nutanix.Powershell.Models.IVmListIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for Entities property</summary>
        private string _entities;

        public string Entities
        {
            get
            {
                return this._entities;
            }
            set
            {
                this._entities = value;
            }
        }
        /// <summary>Backing field for Metadata property</summary>
        private Nutanix.Powershell.Models.IVmListMetadataOutput _metadata;

        /// <summary>
        /// All api calls that return a list will have this metadata block
        /// </summary>
        public Nutanix.Powershell.Models.IVmListMetadataOutput Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(ApiVersion),ApiVersion);
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
        }
        /// <summary>Creates an new <see cref="VmListIntentResponse" /> instance.</summary>
        public VmListIntentResponse()
        {
        }
    }
    /// Response object for intentful operation of vms
    public partial interface IVmListIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Entities { get; set; }
        Nutanix.Powershell.Models.IVmListMetadataOutput Metadata { get; set; }
    }
}