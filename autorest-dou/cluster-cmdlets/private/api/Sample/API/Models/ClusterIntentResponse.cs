namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a cluster</summary>
    public partial class ClusterIntentResponse : Sample.API.Models.IClusterIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Models.IClusterDefStatus _status;

        /// <summary>
        /// Cluster status definition. A Nutanix cluster is comprised of three or
        /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
        /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
        /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
        /// runs on each node in the cluster. The CVM enables each node to share
        /// local storage from all nodes in the cluster.
        /// </summary>
        public Sample.API.Models.IClusterDefStatus Status
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
        /// <summary>Creates an new <see cref="ClusterIntentResponse" /> instance.</summary>
        public ClusterIntentResponse()
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
    /// Response object for intentful operations on a cluster
    public partial interface IClusterIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IClusterMetadata Metadata { get; set; }
        Sample.API.Models.ICluster Spec { get; set; }
        Sample.API.Models.IClusterDefStatus Status { get; set; }
    }
}