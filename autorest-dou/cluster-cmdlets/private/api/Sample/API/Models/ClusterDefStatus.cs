namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cluster status definition. A Nutanix cluster is comprised of three or
    /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
    /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
    /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
    /// runs on each node in the cluster. The CVM enables each node to share
    /// local storage from all nodes in the cluster.
    /// </summary>
    public partial class ClusterDefStatus : Sample.API.Models.IClusterDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for MessageList property</summary>
        private Sample.API.Models.IMessageResource[] _messageList;

        public Sample.API.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            set
            {
                this._messageList = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Cluster Name.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IClusterDefStatusResources _resources;

        /// <summary>Cluster resources.</summary>
        public Sample.API.Models.IClusterDefStatusResources Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the cluster entity.</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterDefStatus" /> instance.</summary>
        public ClusterDefStatus()
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
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Cluster status definition. A Nutanix cluster is comprised of three or
    /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
    /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
    /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
    /// runs on each node in the cluster. The CVM enables each node to share
    /// local storage from all nodes in the cluster.
    public partial interface IClusterDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Sample.API.Models.IClusterDefStatusResources Resources { get; set; }
        string State { get; set; }
    }
}