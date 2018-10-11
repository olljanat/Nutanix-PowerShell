namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Disk Address.</summary>
    public partial class DiskAddress : Sample.API.Models.IDiskAddress, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AdapterType property</summary>
        private string _adapterType;

        public string AdapterType
        {
            get
            {
                return this._adapterType;
            }
            set
            {
                this._adapterType = value;
            }
        }
        /// <summary>Backing field for DeviceIndex property</summary>
        private int _deviceIndex;

        public int DeviceIndex
        {
            get
            {
                return this._deviceIndex;
            }
            set
            {
                this._deviceIndex = value;
            }
        }
        /// <summary>Creates an new <see cref="DiskAddress" /> instance.</summary>
        public DiskAddress()
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
            await eventListener.AssertNotNull(nameof(AdapterType),AdapterType);
        }
    }
    /// Disk Address.
    public partial interface IDiskAddress : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string AdapterType { get; set; }
        int DeviceIndex { get; set; }
    }
}