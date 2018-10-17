namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a vm_recovery_point</summary>
    public partial class VmRecoveryPointIntentResponse : Sample.API.Models.IVmRecoveryPointIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        private Sample.API.Models.IVmRecoveryPointMetadata _metadata;

        /// <summary>The vm_recovery_point kind metadata</summary>
        public Sample.API.Models.IVmRecoveryPointMetadata Metadata
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
        private Sample.API.Models.IVmRecoveryPoint _spec;

        /// <summary>The input object that defines a vm recovery point.</summary>
        public Sample.API.Models.IVmRecoveryPoint Spec
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
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Models.IVmRecoveryPointDefStatus _status;

        /// <summary>The output object that defines a vm recovery point</summary>
        public Sample.API.Models.IVmRecoveryPointDefStatus Status
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
        /// <summary>Creates an new <see cref="VmRecoveryPointIntentResponse" /> instance.</summary>
        public VmRecoveryPointIntentResponse()
        {
        }
    }
    /// Response object for intentful operations on a vm_recovery_point
    public partial interface IVmRecoveryPointIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IVmRecoveryPointMetadata Metadata { get; set; }
        Sample.API.Models.IVmRecoveryPoint Spec { get; set; }
        Sample.API.Models.IVmRecoveryPointDefStatus Status { get; set; }
    }
}