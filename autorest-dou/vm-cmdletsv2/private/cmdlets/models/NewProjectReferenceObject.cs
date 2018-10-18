namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ProjectReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ProjectReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IProjectReference))]
    public class NewProjectReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ProjectReference" /></summary>
        private Sample.API.Models.IProjectReference _projectReference = new Sample.API.Models.ProjectReference();
        /// <summary>The kind name</summary>
        public string Kind
        {
            set
            {
                _projectReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _projectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _projectReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _projectReference.Kind = "project";
            WriteObject(_projectReference);
        }
    }
}