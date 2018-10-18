namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The output object that defines a vm recovery point</summary>
    public partial class VmRecoveryPointDefStatus : Sample.API.Models.IVmRecoveryPointDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AvailabilityZoneReference property</summary>
        private Sample.API.Models.IAvailabilityZoneReference _availabilityZoneReference;

        /// <summary>
        /// Reference to the availability zone where this recovery point is
        /// located.
        /// </summary>
        public Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference
        {
            get
            {
                return this._availabilityZoneReference;
            }
            set
            {
                this._availabilityZoneReference = value;
            }
        }
        /// <summary>Backing field for ClusterReference property</summary>
        private Sample.API.Models.IClusterReference _clusterReference;

        /// <summary>
        /// Reference to the cluster in the availability zone where this recovery
        /// point is located.
        /// </summary>
        public Sample.API.Models.IClusterReference ClusterReference
        {
            get
            {
                return this._clusterReference;
            }
            set
            {
                this._clusterReference = value;
            }
        }
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
        /// <summary>Backing field for CreationTime property</summary>
        private string _creationTime;

        /// <summary>
        /// The time when the the recovery point is created. This is in internet
        /// date/time format (RFC 3339). For example, 1985-04-12T23:20:50.52Z,
        /// this represents 20 minutes and 50.52 seconds after the 23rd hour of
        /// April 12th, 1985 in UTC.
        /// </summary>
        public string CreationTime
        {
            get
            {
                return this._creationTime;
            }
            set
            {
                this._creationTime = value;
            }
        }
        /// <summary>Backing field for ExpirationTime property</summary>
        private string _expirationTime;

        /// <summary>
        /// The time when this recovery point expires and will be garbage
        /// collected. This is in internet date/time format (RFC 3339). For
        /// example, 1985-04-12T23:20:50.52Z, this represents 20 minutes and
        /// 50.52 seconds after the 23rd hour of April 12th, 1985 in UTC. If not
        /// set, then the recovery point never expires.
        /// </summary>
        public string ExpirationTime
        {
            get
            {
                return this._expirationTime;
            }
            set
            {
                this._expirationTime = value;
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

        /// <summary>Name of the recovery point.</summary>
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
        /// <summary>Backing field for RecoveryPointType property</summary>
        private string _recoveryPointType;

        /// <summary>Crash consistent or Application Consistent recovery point</summary>
        public string RecoveryPointType
        {
            get
            {
                return this._recoveryPointType;
            }
            set
            {
                this._recoveryPointType = value;
            }
        }
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IVmRecoveryPointDefStatusResources _resources;

        /// <summary>Recovery point resources</summary>
        public Sample.API.Models.IVmRecoveryPointDefStatusResources Resources
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

        /// <summary>The state of the vm recovery point.</summary>
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
            await eventListener.AssertObjectIsValid(nameof(AvailabilityZoneReference), AvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertRegEx(nameof(ConsistencyGroupUuid),ConsistencyGroupUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
        /// <summary>Creates an new <see cref="VmRecoveryPointDefStatus" /> instance.</summary>
        public VmRecoveryPointDefStatus()
        {
        }
    }
    /// The output object that defines a vm recovery point
    public partial interface IVmRecoveryPointDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Sample.API.Models.IClusterReference ClusterReference { get; set; }
        string ConsistencyGroupUuid { get; set; }
        string CreationTime { get; set; }
        string ExpirationTime { get; set; }
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        string RecoveryPointType { get; set; }
        Sample.API.Models.IVmRecoveryPointDefStatusResources Resources { get; set; }
        string State { get; set; }
    }
}