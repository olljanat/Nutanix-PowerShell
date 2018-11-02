namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a vm status</summary>
    public partial class VmDefStatus : Nutanix.Powershell.Models.IVmDefStatus, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for MessageList property</summary>
        private string _messageList;

        /// <summary>Any error messages for the vm, if in an error state.</summary>
        public string MessageList
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
        private Nutanix.Powershell.Models.IVmResourcesDefStatus _resources;

        /// <summary>VM Resources Status Definition.</summary>
        public Nutanix.Powershell.Models.IVmResourcesDefStatus Resources
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

        /// <summary>The state of the vm.</summary>
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

        private Nutanix.Powershell.Models.IExecutionContext _executionContext;
        public Nutanix.Powershell.Models.IExecutionContext ExecutionContext {
            get
            {
                return this._executionContext;
            } 
            
            set
            {
                this._executionContext = value;
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
            await eventListener.AssertObjectIsValid(nameof(AvailabilityZoneReference), AvailabilityZoneReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
        /// <summary>Creates an new <see cref="VmDefStatus" /> instance.</summary>
        public VmDefStatus()
        {
        }
    }
    /// An intentful representation of a vm status
    public partial interface IVmDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IAvailabilityZoneReference AvailabilityZoneReference { get; set; }
        Nutanix.Powershell.Models.IClusterReference ClusterReference { get; set; }
        string Description { get; set; }
        string MessageList { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.IVmResourcesDefStatus Resources { get; set; }
        string State { get; set; }
        Nutanix.Powershell.Models.IExecutionContext ExecutionContext {get; set;}
    }
}