namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cloud credentials resources</summary>
    public partial class CloudCredentialsResources : Sample.API.Models.ICloudCredentialsResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CloudType property</summary>
        private string _cloudType;

        /// <summary>Cloud site type</summary>
        public string CloudType
        {
            get
            {
                return this._cloudType;
            }
            set
            {
                this._cloudType = value;
            }
        }
        /// <summary>Backing field for IsDefault property</summary>
        private bool? _isDefault;

        /// <summary>Indicates if it is the default credentials</summary>
        public bool? IsDefault
        {
            get
            {
                return this._isDefault;
            }
            set
            {
                this._isDefault = value;
            }
        }
        /// <summary>Backing field for KeyId property</summary>
        private string _keyId;

        /// <summary>
        /// Access key for AWS, or subscription id for Azure
        /// </summary>
        public string KeyId
        {
            get
            {
                return this._keyId;
            }
            set
            {
                this._keyId = value;
            }
        }
        /// <summary>Backing field for SecureId property</summary>
        private string _secureId;

        /// <summary>
        /// Secret key for AWS, or full file path of the Azure client certificate
        /// file(<file_name>.pem)
        /// </summary>
        public string SecureId
        {
            get
            {
                return this._secureId;
            }
            set
            {
                this._secureId = value;
            }
        }
        /// <summary>Creates an new <see cref="CloudCredentialsResources" /> instance.</summary>
        public CloudCredentialsResources()
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
            await eventListener.AssertNotNull(nameof(CloudType),CloudType);
        }
    }
    /// Cloud credentials resources
    public partial interface ICloudCredentialsResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string CloudType { get; set; }
        bool? IsDefault { get; set; }
        string KeyId { get; set; }
        string SecureId { get; set; }
    }
}