namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmIntentInput))]
    public class NewVmIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmIntentInput" /></summary>
        private Sample.API.Models.IVmIntentInput _vmIntentInput = new Sample.API.Models.VmIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        public string ApiVersion
        {
            set
            {
                _vmIntentInput.ApiVersion = value;
            }
        }
        /// <summary>The vm kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The vm kind metadata")]
        public Sample.API.Models.IVmMetadata Metadata
        {
            set
            {
                _vmIntentInput.Metadata = value;
            }
        }
        /// <summary>An intentful representation of a vm spec</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "An intentful representation of a vm spec")]
        public Sample.API.Models.IVm Spec
        {
            set
            {
                _vmIntentInput.Spec = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _vmIntentInput.ApiVersion = "3.1";
            WriteObject(_vmIntentInput);
        }
    }
}