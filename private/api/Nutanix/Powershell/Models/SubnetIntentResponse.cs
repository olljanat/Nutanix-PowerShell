namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a subnet</summary>
    public partial class SubnetIntentResponse : Nutanix.Powershell.Models.ISubnetIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
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
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.ISubnetMetadata _metadata;

        /// <summary>The subnet kind metadata</summary>
        public Nutanix.Powershell.Models.ISubnetMetadata Metadata
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
        /// <summary>Backing field for <see cref="Spec" /> property.</summary>
        private Nutanix.Powershell.Models.ISubnet _spec;

        /// <summary>An intentful representation of a subnet spec</summary>
        public Nutanix.Powershell.Models.ISubnet Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Nutanix.Powershell.Models.IVmDefStatus _status;

        /// <summary>An intentful representation of a subnet status</summary>
        public Nutanix.Powershell.Models.IVmDefStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Creates an new <see cref="SubnetIntentResponse" /> instance.</summary>
        public SubnetIntentResponse()
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
            await eventListener.AssertNotNull(nameof(ApiVersion),ApiVersion);
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
    }
    /// Response object for intentful operations on a subnet
    public partial interface ISubnetIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.ISubnetMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.ISubnet Spec { get; set; }
        Nutanix.Powershell.Models.IVmDefStatus Status { get; set; }
    }
}