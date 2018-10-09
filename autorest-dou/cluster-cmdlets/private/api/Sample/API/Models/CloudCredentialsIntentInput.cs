namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a cloud_credentials</summary>
    public partial class CloudCredentialsIntentInput : Sample.API.Models.ICloudCredentialsIntentInput, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Metadata property</summary>
        private Sample.API.Models.ICloudCredentialsMetadata _metadata;

        /// <summary>The cloud_credentials kind metadata</summary>
        public Sample.API.Models.ICloudCredentialsMetadata Metadata
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
        /// <summary>Backing field for Spec property</summary>
        private Sample.API.Models.ICloudCredentials _spec;

        /// <summary>Cloud credentials spec</summary>
        public Sample.API.Models.ICloudCredentials Spec
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
        /// <summary>Creates an new <see cref="CloudCredentialsIntentInput" /> instance.</summary>
        public CloudCredentialsIntentInput()
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
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertNotNull(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
        }
    }
    /// An intentful representation of a cloud_credentials
    public partial interface ICloudCredentialsIntentInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.ICloudCredentialsMetadata Metadata { get; set; }
        Sample.API.Models.ICloudCredentials Spec { get; set; }
    }
}