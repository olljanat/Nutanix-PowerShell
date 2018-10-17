namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="UserReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"UserReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IUserReference))]
    public class NewUserReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="UserReference" /></summary>
        private Sample.API.Models.IUserReference _userReference = new Sample.API.Models.UserReference();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _userReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _userReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _userReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_userReference);
        }
    }
}