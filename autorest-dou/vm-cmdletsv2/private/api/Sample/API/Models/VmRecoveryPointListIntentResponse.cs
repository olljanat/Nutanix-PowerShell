namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operation of vm_recovery_points</summary>
    public partial class VmRecoveryPointListIntentResponse : Sample.API.Models.IVmRecoveryPointListIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        private Sample.API.Models.IVmRecoveryPointIntentResource[] _entities;

        public Sample.API.Models.IVmRecoveryPointIntentResource[] Entities
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
        private Sample.API.Models.IVmRecoveryPointListMetadataOutput _metadata;

        /// <summary>
        /// All api calls that return a list will have this metadata block
        /// </summary>
        public Sample.API.Models.IVmRecoveryPointListMetadataOutput Metadata
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
            if (Entities != null ) {
                    for (int __i = 0; __i < Entities.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Entities[{__i}]", Entities[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
        }
        /// <summary>Creates an new <see cref="VmRecoveryPointListIntentResponse" /> instance.</summary>
        public VmRecoveryPointListIntentResponse()
        {
        }
    }
    /// Response object for intentful operation of vm_recovery_points
    public partial interface IVmRecoveryPointListIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IVmRecoveryPointIntentResource[] Entities { get; set; }
        Sample.API.Models.IVmRecoveryPointListMetadataOutput Metadata { get; set; }
    }
}