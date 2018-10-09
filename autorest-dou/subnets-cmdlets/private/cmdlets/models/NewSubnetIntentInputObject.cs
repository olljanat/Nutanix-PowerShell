namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="SubnetIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"SubnetIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.ISubnetIntentInput))]
    public class NewSubnetIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="SubnetIntentInput" /></summary>
        private Sample.API.Models.ISubnetIntentInput _subnetIntentInput = new Sample.API.Models.SubnetIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _subnetIntentInput.ApiVersion = value;
            }
        }
        /// <summary>The subnet kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The subnet kind metadata")]
        public Sample.API.Models.ISubnetMetadata Metadata
        {
            set
            {
                _subnetIntentInput.Metadata = value;
            }
        }
        /// <summary>An intentful representation of a subnet spec</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "An intentful representation of a subnet spec")]
        public Sample.API.Models.ISubnet Spec
        {
            set
            {
                _subnetIntentInput.Spec = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_subnetIntentInput);
        }
    }
}