namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Reference" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IReference))]
    public class NewReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Reference" /></summary>
        private Sample.API.Models.IReference _reference = new Sample.API.Models.Reference();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Kind
        {
            set
            {
                _reference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _reference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _reference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_reference);
        }
    }
}