namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Information regarding guest tools.</summary>
    public partial class GuestToolsStatus : Nutanix.Powershell.Models.IGuestToolsStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for NutanixGuestTools property</summary>
        private Nutanix.Powershell.Models.INutanixGuestToolsStatus _nutanixGuestTools;

        /// <summary>Nutanix Guest Tools information</summary>
        public Nutanix.Powershell.Models.INutanixGuestToolsStatus NutanixGuestTools
        {
            get
            {
                return this._nutanixGuestTools;
            }
            set
            {
                this._nutanixGuestTools = value;
            }
        }
        /// <summary>Creates an new <see cref="GuestToolsStatus" /> instance.</summary>
        public GuestToolsStatus()
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
            await eventListener.AssertObjectIsValid(nameof(NutanixGuestTools), NutanixGuestTools);
        }
    }
    /// Information regarding guest tools.
    public partial interface IGuestToolsStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.INutanixGuestToolsStatus NutanixGuestTools { get; set; }
    }
}