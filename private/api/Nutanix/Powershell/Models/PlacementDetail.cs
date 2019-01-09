namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Details of the cluster where the entity need to be placed.</summary>
    public partial class PlacementDetail : Nutanix.Powershell.Models.IPlacementDetail, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ClusterIp" /> property.</summary>
        private string _clusterIp;

        /// <summary>IP of the cluster.</summary>
        public string ClusterIp
        {
            get
            {
                return this._clusterIp;
            }
            set
            {
                this._clusterIp = value;
            }
        }
        /// <summary>Backing field for <see cref="ClusterReference" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterReference _clusterReference;

        /// <summary>Reference to the cluster</summary>
        public Nutanix.Powershell.Models.IClusterReference ClusterReference
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
        /// <summary>Creates an new <see cref="PlacementDetail" /> instance.</summary>
        public PlacementDetail()
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
            await eventListener.AssertNotNull(nameof(ClusterIp),ClusterIp);
            await eventListener.AssertRegEx(nameof(ClusterIp),ClusterIp,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            await eventListener.AssertNotNull(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
        }
    }
    /// Details of the cluster where the entity need to be placed.
    public partial interface IPlacementDetail : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ClusterIp { get; set; }
        Nutanix.Powershell.Models.IClusterReference ClusterReference { get; set; }
    }
}