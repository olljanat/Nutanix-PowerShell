namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmReference))]
    public class NewVmReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmReference" /></summary>
        private Sample.API.Models.IVmReference _vmReference = new Sample.API.Models.VmReference();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _vmReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _vmReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _vmReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmReference);
        }
    }
}