namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a vm spec</summary>
    public partial class Vm : Nutanix.Powershell.Models.IVm, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AvailabilityZoneReference property</summary>
        private Nutanix.Powershell.Models.IAvailabilityZoneReference _availabilityZoneReference;

        /// <summary>The reference to a availability_zone</summary>
        public Nutanix.Powershell.Models.IAvailabilityZoneReference AvailabilityZoneReference
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
        private Nutanix.Powershell.Models.IClusterReference _clusterReference;

        /// <summary>The reference to a cluster</summary>
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
        /// <summary>Backing field for Description property</summary>
        private string _description;

        /// <summary>A description for vm.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>vm Name.</summary>
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
        private Nutanix.Powershell.Models.IVmResources _resources;

        /// <summary>VM Resources Definition.</summary>
        public Nutanix.Powershell.Models.IVmResources Resources
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertMaximumLength(nameof(Description),Description,1000);
            await eventListener.AssertObjectIsValid(nameof(AvailabilityZoneReference), AvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
        /// <summary>Creates an new <see cref="Vm" /> instance.</summary>
        public Vm()
        {
        }
    }
    /// An intentful representation of a vm spec
    public partial interface IVm : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Nutanix.Powershell.Models.IClusterReference ClusterReference { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.IVmResources Resources { get; set; }
    }
}