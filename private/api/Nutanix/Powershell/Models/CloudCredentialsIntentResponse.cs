namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a cloud_credentials</summary>
    public partial class CloudCredentialsIntentResponse : Nutanix.Powershell.Models.ICloudCredentialsIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        private Nutanix.Powershell.Models.ICloudCredentialsMetadata _metadata;

        /// <summary>The cloud_credentials kind metadata</summary>
        public Nutanix.Powershell.Models.ICloudCredentialsMetadata Metadata
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
        private Nutanix.Powershell.Models.ICloudCredentials _spec;

        /// <summary>Cloud credentials spec</summary>
        public Nutanix.Powershell.Models.ICloudCredentials Spec
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
        private Nutanix.Powershell.Models.ICloudCredentialsDefStatus _status;

        /// <summary>Cloud credentials configuration</summary>
        public Nutanix.Powershell.Models.ICloudCredentialsDefStatus Status
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
        /// <summary>Creates an new <see cref="CloudCredentialsIntentResponse" /> instance.</summary>
        public CloudCredentialsIntentResponse()
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
    /// Response object for intentful operations on a cloud_credentials
    public partial interface ICloudCredentialsIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.ICloudCredentialsMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.ICloudCredentials Spec { get; set; }
        Nutanix.Powershell.Models.ICloudCredentialsDefStatus Status { get; set; }
    }
}