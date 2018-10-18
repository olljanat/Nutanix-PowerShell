namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmRecoveryPointIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmRecoveryPointIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmRecoveryPointIntentInput))]
    public class NewVmRecoveryPointIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmRecoveryPointIntentInput" /></summary>
        private Sample.API.Models.IVmRecoveryPointIntentInput _vmRecoveryPointIntentInput = new Sample.API.Models.VmRecoveryPointIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _vmRecoveryPointIntentInput.ApiVersion = value;
            }
        }
        /// <summary>The vm_recovery_point kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The vm_recovery_point kind metadata")]
        public Sample.API.Models.IVmRecoveryPointMetadata Metadata
        {
            set
            {
                _vmRecoveryPointIntentInput.Metadata = value;
            }
        }
        /// <summary>The input object that defines a vm recovery point.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The input object that defines a vm recovery point.")]
        public Sample.API.Models.IVmRecoveryPoint Spec
        {
            set
            {
                _vmRecoveryPointIntentInput.Spec = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmRecoveryPointIntentInput);
        }
    }
}