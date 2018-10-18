namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>VirtualMachine Disk (VM Disk).</summary>
    public partial class VmDisk : Sample.API.Models.IVmDisk, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DataSourceReference property</summary>
        private Sample.API.Models.IReference _dataSourceReference;

        /// <summary>Reference to a kind</summary>
        public Sample.API.Models.IReference DataSourceReference
        {
            get
            {
                return this._dataSourceReference;
            }
            set
            {
                this._dataSourceReference = value;
            }
        }
        /// <summary>Backing field for DeviceProperties property</summary>
        private Sample.API.Models.IVmDiskDeviceProperties _deviceProperties;

        public Sample.API.Models.IVmDiskDeviceProperties DeviceProperties
        {
            get
            {
                return this._deviceProperties;
            }
            set
            {
                this._deviceProperties = value;
            }
        }
        /// <summary>Backing field for DiskSizeBytes property</summary>
        private long? _diskSizeBytes;

        /// <summary>Size of the disk in Bytes.</summary>
        public long? DiskSizeBytes
        {
            get
            {
                return this._diskSizeBytes;
            }
            set
            {
                this._diskSizeBytes = value;
            }
        }
        /// <summary>Backing field for DiskSizeMib property</summary>
        private int? _diskSizeMib;

        /// <summary>
        /// Size of the disk in MiB. Must match the size specified in 'disk_size_bytes' - rounded up to the nearest MiB - when that
        /// field is present.
        /// </summary>
        public int? DiskSizeMib
        {
            get
            {
                return this._diskSizeMib;
            }
            set
            {
                this._diskSizeMib = value;
            }
        }
        /// <summary>Backing field for Uuid property</summary>
        private string _uuid;

        /// <summary>
        /// The device ID which is used to uniquely identify this particular disk.
        /// </summary>
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
        /// <summary>Backing field for VolumeGroupReference property</summary>
        private Sample.API.Models.IReference _volumeGroupReference;

        /// <summary>Reference to a kind</summary>
        public Sample.API.Models.IReference VolumeGroupReference
        {
            get
            {
                return this._volumeGroupReference;
            }
            set
            {
                this._volumeGroupReference = value;
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
            await eventListener.AssertObjectIsValid(nameof(DataSourceReference), DataSourceReference);
            await eventListener.AssertObjectIsValid(nameof(DeviceProperties), DeviceProperties);
            await eventListener.AssertIsGreaterThanOrEqual(nameof(DiskSizeBytes),DiskSizeBytes,1);
            await eventListener.AssertIsGreaterThanOrEqual(nameof(DiskSizeMib),DiskSizeMib,1);
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
            await eventListener.AssertObjectIsValid(nameof(VolumeGroupReference), VolumeGroupReference);
        }
        /// <summary>Creates an new <see cref="VmDisk" /> instance.</summary>
        public VmDisk()
        {
        }
    }
    /// VirtualMachine Disk (VM Disk).
    public partial interface IVmDisk : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IReference DataSourceReference { get; set; }
        Sample.API.Models.IVmDiskDeviceProperties DeviceProperties { get; set; }
        long? DiskSizeBytes { get; set; }
        int? DiskSizeMib { get; set; }
        string Uuid { get; set; }
        Sample.API.Models.IReference VolumeGroupReference { get; set; }
    }
}