namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class VmDiskDeviceProperties : Sample.API.Models.IVmDiskDeviceProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DeviceType property</summary>
        private string _deviceType;

        public string DeviceType
        {
            get
            {
                return this._deviceType;
            }
            set
            {
                this._deviceType = value;
            }
        }
        /// <summary>Backing field for DiskAddress property</summary>
        private Sample.API.Models.IDiskAddress _diskAddress;

        /// <summary>Disk Address.</summary>
        public Sample.API.Models.IDiskAddress DiskAddress
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
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(DiskAddress), DiskAddress);
        }
        /// <summary>Creates an new <see cref="VmDiskDeviceProperties" /> instance.</summary>
        public VmDiskDeviceProperties()
        {
        }
    }
    public partial interface IVmDiskDeviceProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string DeviceType { get; set; }
        Sample.API.Models.IDiskAddress DiskAddress { get; set; }
    }
}