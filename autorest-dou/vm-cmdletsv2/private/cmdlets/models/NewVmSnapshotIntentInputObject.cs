namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmSnapshotIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmSnapshotIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmSnapshotIntentInput))]
    public class NewVmSnapshotIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmSnapshotIntentInput" /></summary>
        private Sample.API.Models.IVmSnapshotIntentInput _vmSnapshotIntentInput = new Sample.API.Models.VmSnapshotIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _vmSnapshotIntentInput.ApiVersion = value;
            }
        }
        /// <summary>The vm_snapshot kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The vm_snapshot kind metadata")]
        public Sample.API.Models.IVmSnapshotMetadata Metadata
        {
            set
            {
                _vmSnapshotIntentInput.Metadata = value;
            }
        }
        /// <summary>The input object that defines a VM snapshot</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The input object that defines a VM snapshot")]
        public Sample.API.Models.IVmSnapshot Spec
        {
            set
            {
                _vmSnapshotIntentInput.Spec = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmSnapshotIntentInput);
        }
    }
}