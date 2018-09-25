namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Indicates which device a VM should boot from. One of disk_address or mac_address should be provided.
    /// </summary>
    public partial class VmBootDevice : Nutanix.Powershell.Models.IVmBootDevice, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DiskAddress property</summary>
        private Nutanix.Powershell.Models.IDiskAddress _diskAddress;

        /// <summary>Address of disk to boot from.</summary>
        public Nutanix.Powershell.Models.IDiskAddress DiskAddress
        {
            get
            {
                return this._diskAddress;
            }
            set
            {
                this._diskAddress = value;
            }
        }
        /// <summary>Backing field for MacAddress property</summary>
        private string _macAddress;

        /// <summary>MAC address of nic to boot from.</summary>
        public string MacAddress
        {
            get
            {
                return this._macAddress;
            }
            set
            {
                this._macAddress = value;
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
            await eventListener.AssertObjectIsValid(nameof(DiskAddress), DiskAddress);
            await eventListener.AssertRegEx(nameof(MacAddress),MacAddress,@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$");
        }
        /// <summary>Creates an new <see cref="VmBootDevice" /> instance.</summary>
        public VmBootDevice()
        {
        }
    }
    /// Indicates which device a VM should boot from. One of disk_address or mac_address should be provided.
    public partial interface IVmBootDevice : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IDiskAddress DiskAddress { get; set; }
        string MacAddress { get; set; }
    }
}