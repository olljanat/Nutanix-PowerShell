namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Information regarding Nutanix Guest Tools.</summary>
    public partial class NutanixGuestToolsStatus : Sample.API.Models.INutanixGuestToolsStatus
    {
        /// <summary>Backing field for AvailableVersion property</summary>
        private string _availableVersion;

        /// <summary>Version of Nutanix Guest Tools available on the cluster.</summary>
        public string AvailableVersion
        {
            get
            {
                return this._availableVersion;
            }
            set
            {
                this._availableVersion = value;
            }
        }
        /// <summary>Backing field for EnabledCapabilityList property</summary>
        private string[] _enabledCapabilityList;

        /// <summary>Application names that are enabled.</summary>
        public string[] EnabledCapabilityList
        {
            get
            {
                return this._enabledCapabilityList;
            }
            set
            {
                this._enabledCapabilityList = value;
            }
        }
        /// <summary>Backing field for GuestOsVersion property</summary>
        private string _guestOsVersion;

        /// <summary>Version of the operating system on the VM.</summary>
        public string GuestOsVersion
        {
            get
            {
                return this._guestOsVersion;
            }
            set
            {
                this._guestOsVersion = value;
            }
        }
        /// <summary>Backing field for IsReachable property</summary>
        private bool? _isReachable;

        /// <summary>Communication from VM to CVM is active or not.</summary>
        public bool? IsReachable
        {
            get
            {
                return this._isReachable;
            }
            set
            {
                this._isReachable = value;
            }
        }
        /// <summary>Backing field for IsoMountState property</summary>
        private string _isoMountState;

        /// <summary>
        /// Desired mount state of Nutanix Guest Tools ISO.
        /// </summary>
        public string IsoMountState
        {
            get
            {
                return this._isoMountState;
            }
            set
            {
                this._isoMountState = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>Nutanix Guest Tools is enabled or not.</summary>
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
        /// <summary>Backing field for Version property</summary>
        private string _version;

        /// <summary>Version of Nutanix Guest Tools installed on the VM.</summary>
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>Backing field for VmMobilityDriversInstalled property</summary>
        private bool? _vmMobilityDriversInstalled;

        /// <summary>Whether VM mobility drivers are installed in the VM.</summary>
        public bool? VmMobilityDriversInstalled
        {
            get
            {
                return this._vmMobilityDriversInstalled;
            }
            set
            {
                this._vmMobilityDriversInstalled = value;
            }
        }
        /// <summary>Backing field for VssSnapshotCapable property</summary>
        private bool? _vssSnapshotCapable;

        /// <summary>
        /// Whether the VM is configured to take VSS snapshots through NGT.
        /// </summary>
        public bool? VssSnapshotCapable
        {
            get
            {
                return this._vssSnapshotCapable;
            }
            set
            {
                this._vssSnapshotCapable = value;
            }
        }
        /// <summary>Creates an new <see cref="NutanixGuestToolsStatus" /> instance.</summary>
        public NutanixGuestToolsStatus()
        {
        }
    }
    /// Information regarding Nutanix Guest Tools.
    public partial interface INutanixGuestToolsStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string AvailableVersion { get; set; }
        string[] EnabledCapabilityList { get; set; }
        string GuestOsVersion { get; set; }
        bool? IsReachable { get; set; }
        string IsoMountState { get; set; }
        string State { get; set; }
        string Version { get; set; }
        bool? VmMobilityDriversInstalled { get; set; }
        bool? VssSnapshotCapable { get; set; }
    }
}