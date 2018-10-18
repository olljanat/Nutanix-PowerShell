namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The input object that defines a VM snapshot</summary>
    public partial class VmSnapshot : Sample.API.Models.IVmSnapshot, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ExpirationTimeMsecs property</summary>
        private int? _expirationTimeMsecs;

        /// <summary>
        /// The time when this snapshot expires and will be garbage collected.
        /// If not set, then the snapshot never expires.
        /// </summary>
        public int? ExpirationTimeMsecs
        {
            get
            {
                return this._expirationTimeMsecs;
            }
            set
            {
                this._expirationTimeMsecs = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Name of the snapshot</summary>
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
        /// <summary>Backing field for ReplicationTargetList property</summary>
        private Sample.API.Models.IVmSnapshotReplicationTargetListItemType[] _replicationTargetList;

        /// <summary>
        /// This describes a list replication targets where this snapshot exists
        /// or needs to be replicated to. This is to support the replication and
        /// retrieve of the snapshot.
        /// </summary>
        public Sample.API.Models.IVmSnapshotReplicationTargetListItemType[] ReplicationTargetList
        {
            get
            {
                return this._replicationTargetList;
            }
            set
            {
                this._replicationTargetList = value;
            }
        }
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IVmSnapshotResources _resources;

        /// <summary>Snapshot Resources</summary>
        public Sample.API.Models.IVmSnapshotResources Resources
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
        /// <summary>Backing field for SnapshotType property</summary>
        private string _snapshotType;

        /// <summary>Crash consistent or Application Consistent snapshot</summary>
        public string SnapshotType
        {
            get
            {
                return this._snapshotType;
            }
            set
            {
                this._snapshotType = value;
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
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            if (ReplicationTargetList != null ) {
                    for (int __i = 0; __i < ReplicationTargetList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ReplicationTargetList[{__i}]", ReplicationTargetList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
        /// <summary>Creates an new <see cref="VmSnapshot" /> instance.</summary>
        public VmSnapshot()
        {
        }
    }
    /// The input object that defines a VM snapshot
    public partial interface IVmSnapshot : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? ExpirationTimeMsecs { get; set; }
        string Name { get; set; }
        Sample.API.Models.IVmSnapshotReplicationTargetListItemType[] ReplicationTargetList { get; set; }
        Sample.API.Models.IVmSnapshotResources Resources { get; set; }
        string SnapshotType { get; set; }
    }
}