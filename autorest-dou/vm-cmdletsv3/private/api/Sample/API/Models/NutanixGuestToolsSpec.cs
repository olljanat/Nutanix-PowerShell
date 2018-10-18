namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Information regarding Nutanix Guest Tools.</summary>
    public partial class NutanixGuestToolsSpec : Sample.API.Models.INutanixGuestToolsSpec
    {
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
        /// <summary>Creates an new <see cref="NutanixGuestToolsSpec" /> instance.</summary>
        public NutanixGuestToolsSpec()
        {
        }
    }
    /// Information regarding Nutanix Guest Tools.
    public partial interface INutanixGuestToolsSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string[] EnabledCapabilityList { get; set; }
        string IsoMountState { get; set; }
        string State { get; set; }
    }
}