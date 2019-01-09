namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a cluster</summary>
    public partial class ClusterIntentResource : Nutanix.Powershell.Models.IClusterIntentResource, Microsoft.Rest.ClientRuntime.IValidates
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
        private Nutanix.Powershell.Models.IClusterMetadata _metadata;

        /// <summary>The cluster kind metadata</summary>
        public Nutanix.Powershell.Models.IClusterMetadata Metadata
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
        private Nutanix.Powershell.Models.ICluster _spec;

        /// <summary>Cluster Definition.</summary>
        public Nutanix.Powershell.Models.ICluster Spec
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
        private Nutanix.Powershell.Models.IClusterDefStatus _status;

        /// <summary>
        /// Cluster status definition. A Nutanix cluster is comprised of three or
        /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
        /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
        /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
        /// runs on each node in the cluster. The CVM enables each node to share
        /// local storage from all nodes in the cluster.
        /// </summary>
        public Nutanix.Powershell.Models.IClusterDefStatus Status
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
        /// <summary>Creates an new <see cref="ClusterIntentResource" /> instance.</summary>
        public ClusterIntentResource()
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
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
    }
    /// Response object for intentful operations on a cluster
    public partial interface IClusterIntentResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.IClusterMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.ICluster Spec { get; set; }
        Nutanix.Powershell.Models.IClusterDefStatus Status { get; set; }
    }
}