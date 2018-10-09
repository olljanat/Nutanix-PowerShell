namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Node info for this cluster.</summary>
    public partial class ClusterNodes : Sample.API.Models.IClusterNodes, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for HypervisorServerList property</summary>
        private Sample.API.Models.IHypervisorServer[] _hypervisorServerList;

        public Sample.API.Models.IHypervisorServer[] HypervisorServerList
        {
            get
            {
                return this._hypervisorServerList;
            }
            set
            {
                this._hypervisorServerList = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterNodes" /> instance.</summary>
        public ClusterNodes()
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
            if (HypervisorServerList != null ) {
                    for (int __i = 0; __i < HypervisorServerList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"HypervisorServerList[{__i}]", HypervisorServerList[__i]);
                    }
                  }
        }
    }
    /// Node info for this cluster.
    public partial interface IClusterNodes : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IHypervisorServer[] HypervisorServerList { get; set; }
    }
}