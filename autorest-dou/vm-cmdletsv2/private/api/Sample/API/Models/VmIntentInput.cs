namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a vm</summary>
    public partial class VmIntentInput : Sample.API.Models.IVmIntentInput, Microsoft.Rest.ClientRuntime.IValidates
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
        private Sample.API.Models.IVmMetadata _metadata;

        /// <summary>The vm kind metadata</summary>
        public Sample.API.Models.IVmMetadata Metadata
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
        private Sample.API.Models.IVm _spec;

        /// <summary>An intentful representation of a vm spec</summary>
        public Sample.API.Models.IVm Spec
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
        /// <summary>Creates an new <see cref="VmIntentInput" /> instance.</summary>
        public VmIntentInput()
        {
        }
    }
    /// An intentful representation of a vm
    public partial interface IVmIntentInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IVmMetadata Metadata { get; set; }
        Sample.API.Models.IVm Spec { get; set; }
    }
}