namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a cluster</summary>
    public partial class ClusterIntentInput : Sample.API.Models.IClusterIntentInput, Microsoft.Rest.ClientRuntime.IValidates
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
        private Sample.API.Models.IClusterMetadata _metadata;

        /// <summary>The cluster kind metadata</summary>
        public Sample.API.Models.IClusterMetadata Metadata
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
        private Sample.API.Models.ICluster _spec;

        /// <summary>Cluster Definition.</summary>
        public Sample.API.Models.ICluster Spec
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
        /// <summary>Creates an new <see cref="ClusterIntentInput" /> instance.</summary>
        public ClusterIntentInput()
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
    /// An intentful representation of a cluster
    public partial interface IClusterIntentInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IClusterMetadata Metadata { get; set; }
        Sample.API.Models.ICluster Spec { get; set; }
    }
}