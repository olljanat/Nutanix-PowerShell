namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Graphics resource information for the Virtual Machine.</summary>
    public partial class VmGpu : Nutanix.Powershell.Models.IVmGpu
    {
        /// <summary>Backing field for DeviceId property</summary>
        private int? _deviceId;

        /// <summary>The device ID of the GPU.</summary>
        public int? DeviceId
        {
            get
            {
                return this._deviceId;
            }
            set
            {
                this._deviceId = value;
            }
        }
        /// <summary>Backing field for Mode property</summary>
        private string _mode;

        /// <summary>The mode of this GPU.</summary>
        public string Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        /// <summary>Backing field for Vendor property</summary>
        private string _vendor;

        /// <summary>The vendor of the GPU.</summary>
        public string Vendor
        {
            get
            {
                return this._vendor;
            }
            set
            {
                this._vendor = value;
            }
        }
        /// <summary>Creates an new <see cref="VmGpu" /> instance.</summary>
        public VmGpu()
        {
        }
    }
    /// Graphics resource information for the Virtual Machine.
    public partial interface IVmGpu : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? DeviceId { get; set; }
        string Mode { get; set; }
        string Vendor { get; set; }
    }
}