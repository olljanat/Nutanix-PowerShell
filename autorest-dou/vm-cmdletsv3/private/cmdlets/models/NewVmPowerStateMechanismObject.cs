namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmPowerStateMechanism" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmPowerStateMechanismObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmPowerStateMechanism))]
    public class NewVmPowerStateMechanismObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmPowerStateMechanism" /></summary>
        private Sample.API.Models.IVmPowerStateMechanism _vmPowerStateMechanism = new Sample.API.Models.VmPowerStateMechanism();
        /// <summary>Power state mechanism (ACPI/GUEST/HARD).</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Power state mechanism (ACPI/GUEST/HARD).")]
        public string Mechanism
        {
            set
            {
                _vmPowerStateMechanism.Mechanism = value;
            }
        }
        /// <summary>Indicates whether to execute set script before ngt shutdown/reboot.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether to execute set script before ngt shutdown/reboot.")]
        public System.Management.Automation.SwitchParameter VmGuestPowerStateTransitionConfigEnableScriptExec
        {
            set
            {
                _vmPowerStateMechanism.GuestTransitionConfig = _vmPowerStateMechanism.GuestTransitionConfig ?? new Sample.API.Models.VmGuestPowerStateTransitionConfig();
                _vmPowerStateMechanism.GuestTransitionConfig.EnableScriptExec = value.ToBool();
            }
        }
        /// <summary>Indicates whether to abort ngt shutdown/reboot if script fails.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates whether to abort ngt shutdown/reboot if script fails.")]
        public System.Management.Automation.SwitchParameter VmGuestPowerStateTransitionConfigShouldFailOnScriptFailure
        {
            set
            {
                _vmPowerStateMechanism.GuestTransitionConfig = _vmPowerStateMechanism.GuestTransitionConfig ?? new Sample.API.Models.VmGuestPowerStateTransitionConfig();
                _vmPowerStateMechanism.GuestTransitionConfig.ShouldFailOnScriptFailure = value.ToBool();
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmPowerStateMechanism);
        }
    }
}