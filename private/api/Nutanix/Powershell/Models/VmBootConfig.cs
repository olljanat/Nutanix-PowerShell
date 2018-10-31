namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Indicates which device a VM should boot from.
    /// </summary>
    public partial class VmBootConfig : Nutanix.Powershell.Models.IVmBootConfig, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for BootDevice property</summary>
        private Nutanix.Powershell.Models.IVmBootDevice _bootDevice;

        /// <summary>
        /// Indicates which device a VM should boot from. Boot device takes precdence over boot device order. If both are given then
        /// specified boot device will be primary boot device and remaining devices will be assigned boot order according to boot
        /// device order field.
        /// </summary>
        public Nutanix.Powershell.Models.IVmBootDevice BootDevice
        {
            get
            {
                return this._bootDevice;
            }
            set
            {
                this._bootDevice = value;
            }
        }
        /// <summary>Backing field for BootDeviceOrderList property</summary>
        private string[] _bootDeviceOrderList;

        /// <summary>
        /// Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system
        /// will decide appropriate boot device order.
        /// </summary>
        public string[] BootDeviceOrderList
        {
            get
            {
                return this._bootDeviceOrderList;
            }
            set
            {
                this._bootDeviceOrderList = value;
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
            await eventListener.AssertObjectIsValid(nameof(BootDevice), BootDevice);
        }
        /// <summary>Creates an new <see cref="VmBootConfig" /> instance.</summary>
        public VmBootConfig()
        {
        }
    }
    /// Indicates which device a VM should boot from.
    public partial interface IVmBootConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IVmBootDevice BootDevice { get; set; }
        string[] BootDeviceOrderList { get; set; }
    }
}