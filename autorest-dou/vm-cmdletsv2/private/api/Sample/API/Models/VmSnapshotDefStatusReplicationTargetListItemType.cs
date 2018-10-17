namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class VmSnapshotDefStatusReplicationTargetListItemType : Sample.API.Models.IVmSnapshotDefStatusReplicationTargetListItemType, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AvailabilityZoneReference property</summary>
        private Sample.API.Models.IAvailabilityZoneReference _availabilityZoneReference;

        /// <summary>The reference to a availability_zone</summary>
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

        /// <summary>UUID of cluster in the availability zone.</summary>
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
        }
        /// <summary>
        /// Creates an new <see cref="VmSnapshotDefStatusReplicationTargetListItemType" /> instance.
        /// </summary>
        public VmSnapshotDefStatusReplicationTargetListItemType()
        {
        }
    }
    public partial interface IVmSnapshotDefStatusReplicationTargetListItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Sample.API.Models.IClusterReference ClusterReference { get; set; }
    }
}