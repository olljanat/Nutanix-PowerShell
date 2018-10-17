namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmGuestPowerStateTransitionConfig" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmGuestPowerStateTransitionConfigObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmGuestPowerStateTransitionConfig))]
    public class NewVmGuestPowerStateTransitionConfigObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmGuestPowerStateTransitionConfig" /></summary>
        private Sample.API.Models.IVmGuestPowerStateTransitionConfig _vmGuestPowerStateTransitionConfig = new Sample.API.Models.VmGuestPowerStateTransitionConfig();
        /// <summary>Indicates whether to execute set script before ngt shutdown/reboot.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether to execute set script before ngt shutdown/reboot.")]
        public System.Management.Automation.SwitchParameter EnableScriptExec
        {
            set
            {
                _vmGuestPowerStateTransitionConfig.EnableScriptExec = value.ToBool();
            }
        }
        /// <summary>Indicates whether to abort ngt shutdown/reboot if script fails.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether to abort ngt shutdown/reboot if script fails.")]
        public System.Management.Automation.SwitchParameter ShouldFailOnScriptFailure
        {
            set
            {
                _vmGuestPowerStateTransitionConfig.ShouldFailOnScriptFailure = value.ToBool();
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmGuestPowerStateTransitionConfig);
        }
    }
}