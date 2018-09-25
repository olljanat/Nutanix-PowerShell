namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Extra configs related to power state transition.</summary>
    public partial class VmGuestPowerStateTransitionConfig : Nutanix.Powershell.Models.IVmGuestPowerStateTransitionConfig
    {
        /// <summary>Backing field for EnableScriptExec property</summary>
        private bool? _enableScriptExec;

        /// <summary>Indicates whether to execute set script before ngt shutdown/reboot.</summary>
        public bool? EnableScriptExec
        {
            get
            {
                return this._enableScriptExec;
            }
            set
            {
                this._enableScriptExec = value;
            }
        }
        /// <summary>Backing field for ShouldFailOnScriptFailure property</summary>
        private bool? _shouldFailOnScriptFailure;

        /// <summary>Indicates whether to abort ngt shutdown/reboot if script fails.</summary>
        public bool? ShouldFailOnScriptFailure
        {
            get
            {
                return this._shouldFailOnScriptFailure;
            }
            set
            {
                this._shouldFailOnScriptFailure = value;
            }
        }
        /// <summary>Creates an new <see cref="VmGuestPowerStateTransitionConfig" /> instance.</summary>
        public VmGuestPowerStateTransitionConfig()
        {
        }
    }
    /// Extra configs related to power state transition.
    public partial interface IVmGuestPowerStateTransitionConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        bool? EnableScriptExec { get; set; }
        bool? ShouldFailOnScriptFailure { get; set; }
    }
}