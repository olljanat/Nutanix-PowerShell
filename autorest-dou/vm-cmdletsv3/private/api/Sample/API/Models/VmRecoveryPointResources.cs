namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Recovery point resources</summary>
    public partial class VmRecoveryPointResources : Sample.API.Models.IVmRecoveryPointResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ParentVmReference property</summary>
        private Sample.API.Models.IVmReference _parentVmReference;

        /// <summary>
        /// Reference to vm that this recovery point is a snapshot of.
        /// </summary>
        public Sample.API.Models.IVmReference ParentVmReference
        {
            get
            {
                return this._parentVmReference;
            }
            set
            {
                this._parentVmReference = value;
            }
        }
        /// <summary>Backing field for SourceAvailabilityZoneReference property</summary>
        private Sample.API.Models.IAvailabilityZoneReference _sourceAvailabilityZoneReference;

        /// <summary>
        /// Reference to the availability zone where the source recovery
        /// point exists. This need to be set to copy a recovery from some
        /// other location.
        /// </summary>
        public Sample.API.Models.IAvailabilityZoneReference SourceAvailabilityZoneReference
        {
            get
            {
                return this._sourceAvailabilityZoneReference;
            }
            set
            {
                this._sourceAvailabilityZoneReference = value;
            }
        }
        /// <summary>Backing field for SourceClusterReference property</summary>
        private Sample.API.Models.IClusterReference _sourceClusterReference;

        /// <summary>
        /// Reference to the cluster in the source availability zone.
        /// </summary>
        public Sample.API.Models.IClusterReference SourceClusterReference
        {
            get
            {
                return this._sourceClusterReference;
            }
            set
            {
                this._sourceClusterReference = value;
            }
        }
        /// <summary>Backing field for VmRecoveryPointLocationAgnosticUuid property</summary>
        private string _vmRecoveryPointLocationAgnosticUuid;

        /// <summary>
        /// Location agnostic UUID of the recovery point. If a recovery
        /// point is replicated to a different clusters, then all the
        /// instances of same recovery point will share this UUID.
        /// </summary>
        public string VmRecoveryPointLocationAgnosticUuid
        {
            get
            {
                return this._vmRecoveryPointLocationAgnosticUuid;
            }
            set
            {
                this._vmRecoveryPointLocationAgnosticUuid = value;
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
            await eventListener.AssertObjectIsValid(nameof(ParentVmReference), ParentVmReference);
            await eventListener.AssertObjectIsValid(nameof(SourceAvailabilityZoneReference), SourceAvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(SourceClusterReference), SourceClusterReference);
            await eventListener.AssertRegEx(nameof(VmRecoveryPointLocationAgnosticUuid),VmRecoveryPointLocationAgnosticUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
        /// <summary>Creates an new <see cref="VmRecoveryPointResources" /> instance.</summary>
        public VmRecoveryPointResources()
        {
        }
    }
    /// Recovery point resources
    public partial interface IVmRecoveryPointResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IVmReference ParentVmReference { get; set; }
        Sample.API.Models.IAvailabilityZoneReference SourceAvailabilityZoneReference { get; set; }
        Sample.API.Models.IClusterReference SourceClusterReference { get; set; }
        string VmRecoveryPointLocationAgnosticUuid { get; set; }
    }
}