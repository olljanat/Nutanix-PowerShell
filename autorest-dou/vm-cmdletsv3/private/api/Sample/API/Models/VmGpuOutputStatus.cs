namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Graphics resource status information for the Virtual Machine.</summary>
    public partial class VmGpuOutputStatus : Sample.API.Models.IVmGpuOutputStatus, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Fraction property</summary>
        private int? _fraction;

        /// <summary>Fraction of the physical GPU assigned.</summary>
        public int? Fraction
        {
            get
            {
                return this._fraction;
            }
            set
            {
                this._fraction = value;
            }
        }
        /// <summary>Backing field for FrameBufferSizeMib property</summary>
        private long? _frameBufferSizeMib;

        /// <summary>GPU frame buffer size in MiB.</summary>
        public long? FrameBufferSizeMib
        {
            get
            {
                return this._frameBufferSizeMib;
            }
            set
            {
                this._frameBufferSizeMib = value;
            }
        }
        /// <summary>Backing field for GuestDriverVersion property</summary>
        private string _guestDriverVersion;

        /// <summary>Last determined guest driver version.</summary>
        public string GuestDriverVersion
        {
            get
            {
                return this._guestDriverVersion;
            }
            set
            {
                this._guestDriverVersion = value;
            }
        }
        /// <summary>Backing field for Mode property</summary>
        private string _mode;

        /// <summary>The mode of this GPU</summary>
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
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Name of the GPU resource.</summary>
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
        /// <summary>Backing field for NumVirtualDisplayHeads property</summary>
        private int? _numVirtualDisplayHeads;

        /// <summary>Number of supported virtual display heads.</summary>
        public int? NumVirtualDisplayHeads
        {
            get
            {
                return this._numVirtualDisplayHeads;
            }
            set
            {
                this._numVirtualDisplayHeads = value;
            }
        }
        /// <summary>Backing field for PciAddress property</summary>
        private string _pciAddress;

        /// <summary>
        /// GPU {segment:bus:device:function} (sbdf) address if assigned.
        /// </summary>
        public string PciAddress
        {
            get
            {
                return this._pciAddress;
            }
            set
            {
                this._pciAddress = value;
            }
        }
        /// <summary>Backing field for Uuid property</summary>
        private string _uuid;

        /// <summary>UUID of the GPU.</summary>
        public string Uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
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
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
        /// <summary>Creates an new <see cref="VmGpuOutputStatus" /> instance.</summary>
        public VmGpuOutputStatus()
        {
        }
    }
    /// Graphics resource status information for the Virtual Machine.
    public partial interface IVmGpuOutputStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? DeviceId { get; set; }
        int? Fraction { get; set; }
        long? FrameBufferSizeMib { get; set; }
        string GuestDriverVersion { get; set; }
        string Mode { get; set; }
        string Name { get; set; }
        int? NumVirtualDisplayHeads { get; set; }
        string PciAddress { get; set; }
        string Uuid { get; set; }
        string Vendor { get; set; }
    }
}