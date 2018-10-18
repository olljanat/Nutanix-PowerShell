namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The output object that defines a VM snapshot</summary>
    public partial class VmSnapshotDefStatus : Sample.API.Models.IVmSnapshotDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ConsistencyGroupUuid property</summary>
        private string _consistencyGroupUuid;

        /// <summary>
        /// This field is same for all the entities (irrespective of kind) that
        /// were snapshotted together.
        /// </summary>
        public string ConsistencyGroupUuid
        {
            get
            {
                return this._consistencyGroupUuid;
            }
            set
            {
                this._consistencyGroupUuid = value;
            }
        }
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
        /// <summary>Backing field for LocationAgnosticUuid property</summary>
        private string _locationAgnosticUuid;

        /// <summary>
        /// If a snapshot is replicated to a different clusters, then all the
        /// instances of same snapshot will share this UUID.
        /// </summary>
        public string LocationAgnosticUuid
        {
            get
            {
                return this._locationAgnosticUuid;
            }
            set
            {
                this._locationAgnosticUuid = value;
            }
        }
        /// <summary>Backing field for MessageList property</summary>
        private Sample.API.Models.IMessageResource[] _messageList;

        /// <summary>Any error messages for the {kind}}, if in an error state.</summary>
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
        private Sample.API.Models.IVmSnapshotDefStatusReplicationTargetListItemType[] _replicationTargetList;

        /// <summary>
        /// This describes a list replication targets where this snapshot exists
        /// or needs to be replicated to. This is to support the replication and
        /// retrieve of the snapshot.
        /// </summary>
        public Sample.API.Models.IVmSnapshotDefStatusReplicationTargetListItemType[] ReplicationTargetList
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
        private Sample.API.Models.IVmSnapshotDefStatusResources _resources;

        /// <summary>Snapshot Resources</summary>
        public Sample.API.Models.IVmSnapshotDefStatusResources Resources
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
        /// <summary>Backing field for SnapshotFileList property</summary>
        private Sample.API.Models.IVmSnapshotDefStatusSnapshotFileListItemType[] _snapshotFileList;

        /// <summary>
        /// Describes the files that are included in the snapshot.
        /// </summary>
        public Sample.API.Models.IVmSnapshotDefStatusSnapshotFileListItemType[] SnapshotFileList
        {
            get
            {
                return this._snapshotFileList;
            }
            set
            {
                this._snapshotFileList = value;
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
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the VM snapshot.</summary>
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
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertRegEx(nameof(ConsistencyGroupUuid),ConsistencyGroupUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
            await eventListener.AssertRegEx(nameof(LocationAgnosticUuid),LocationAgnosticUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            if (ReplicationTargetList != null ) {
                    for (int __i = 0; __i < ReplicationTargetList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ReplicationTargetList[{__i}]", ReplicationTargetList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
            await eventListener.AssertNotNull(nameof(SnapshotFileList), SnapshotFileList);
            if (SnapshotFileList != null ) {
                    for (int __i = 0; __i < SnapshotFileList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"SnapshotFileList[{__i}]", SnapshotFileList[__i]);
                    }
                  }
        }
        /// <summary>Creates an new <see cref="VmSnapshotDefStatus" /> instance.</summary>
        public VmSnapshotDefStatus()
        {
        }
    }
    /// The output object that defines a VM snapshot
    public partial interface IVmSnapshotDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ConsistencyGroupUuid { get; set; }
        int? ExpirationTimeMsecs { get; set; }
        string LocationAgnosticUuid { get; set; }
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Sample.API.Models.IVmSnapshotDefStatusReplicationTargetListItemType[] ReplicationTargetList { get; set; }
        Sample.API.Models.IVmSnapshotDefStatusResources Resources { get; set; }
        Sample.API.Models.IVmSnapshotDefStatusSnapshotFileListItemType[] SnapshotFileList { get; set; }
        string SnapshotType { get; set; }
        string State { get; set; }
    }
}