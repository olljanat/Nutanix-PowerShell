namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Indicates the mechanism guiding the VM power state transition. Currently used for the transition to "OFF" state.
    /// </summary>
    public partial class VmPowerStateMechanism : Nutanix.Powershell.Models.IVmPowerStateMechanism, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for GuestTransitionConfig property</summary>
        private Nutanix.Powershell.Models.IVmGuestPowerStateTransitionConfig _guestTransitionConfig;

        /// <summary>Extra configs related to power state transition.</summary>
        public Nutanix.Powershell.Models.IVmGuestPowerStateTransitionConfig GuestTransitionConfig
        {
            get
            {
                return this._guestTransitionConfig;
            }
            set
            {
                this._guestTransitionConfig = value;
            }
        }
        /// <summary>Backing field for Mechanism property</summary>
        private string _mechanism;

        /// <summary>Power state mechanism (ACPI/GUEST/HARD).</summary>
        public string Mechanism
        {
            get
            {
                return this._mechanism;
            }
            set
            {
                this._mechanism = value;
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
            await eventListener.AssertObjectIsValid(nameof(GuestTransitionConfig), GuestTransitionConfig);
        }
        /// <summary>Creates an new <see cref="VmPowerStateMechanism" /> instance.</summary>
        public VmPowerStateMechanism()
        {
        }
    }
    /// Indicates the mechanism guiding the VM power state transition. Currently used for the transition to "OFF" state.
    public partial interface IVmPowerStateMechanism : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IVmGuestPowerStateTransitionConfig GuestTransitionConfig { get; set; }
        string Mechanism { get; set; }
    }
}