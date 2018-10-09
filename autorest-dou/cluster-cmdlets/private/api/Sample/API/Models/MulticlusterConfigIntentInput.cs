namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a multicluster config spec.</summary>
    public partial class MulticlusterConfigIntentInput : Sample.API.Models.IMulticlusterConfigIntentInput, Microsoft.Rest.ClientRuntime.IValidates
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
        private Sample.API.Models.IMulticlusterConfigMetadata _metadata;

        /// <summary>The multicluster_config kind metadata</summary>
        public Sample.API.Models.IMulticlusterConfigMetadata Metadata
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
        private Sample.API.Models.IMulticlusterConfigSpec _spec;

        /// <summary>Specification for multicluster configuration request.</summary>
        public Sample.API.Models.IMulticlusterConfigSpec Spec
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
        /// <summary>Creates an new <see cref="MulticlusterConfigIntentInput" /> instance.</summary>
        public MulticlusterConfigIntentInput()
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
            await eventListener.AssertNotNull(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
        }
    }
    /// An intentful representation of a multicluster config spec.
    public partial interface IMulticlusterConfigIntentInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IMulticlusterConfigMetadata Metadata { get; set; }
        Sample.API.Models.IMulticlusterConfigSpec Spec { get; set; }
    }
}