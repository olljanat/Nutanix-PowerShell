namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The input object that defines a vm recovery point.</summary>
    public partial class VmRecoveryPoint : Sample.API.Models.IVmRecoveryPoint, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AvailabilityZoneReference property</summary>
        private Sample.API.Models.IAvailabilityZoneReference _availabilityZoneReference;

        /// <summary>
        /// Reference to the availability zone where this recovery point is
        /// located
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
        /// <summary>Backing field for CreationTime property</summary>
        private System.DateTime? _creationTime;

        /// <summary>
        /// The time when the the recovery point is created. This is in internet
        /// date/time format (RFC 3339). For example, 1985-04-12T23:20:50.52Z,
        /// this represents 20 minutes and 50.52 seconds after the 23rd hour of
        /// April 12th, 1985 in UTC.
        /// </summary>
        public System.DateTime? CreationTime
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
        private System.DateTime? _expirationTime;

        /// <summary>
        /// The time when this recovery point expires and will be garbage
        /// collected. This is in internet date/time format (RFC 3339). For
        /// example, 1985-04-12T23:20:50.52Z, this represents 20 minutes and
        /// 50.52 seconds after the 23rd hour of April 12th, 1985 in UTC. If not
        /// set, then the recovery point never expires.
        /// </summary>
        public System.DateTime? ExpirationTime
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
        private Sample.API.Models.IVmRecoveryPointResources _resources;

        /// <summary>Recovery point resources</summary>
        public Sample.API.Models.IVmRecoveryPointResources Resources
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
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertObjectIsValid(nameof(AvailabilityZoneReference), AvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
        /// <summary>Creates an new <see cref="VmRecoveryPoint" /> instance.</summary>
        public VmRecoveryPoint()
        {
        }
    }
    /// The input object that defines a vm recovery point.
    public partial interface IVmRecoveryPoint : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Sample.API.Models.IClusterReference ClusterReference { get; set; }
        System.DateTime? CreationTime { get; set; }
        System.DateTime? ExpirationTime { get; set; }
        string Name { get; set; }
        string RecoveryPointType { get; set; }
        Sample.API.Models.IVmRecoveryPointResources Resources { get; set; }
    }
}