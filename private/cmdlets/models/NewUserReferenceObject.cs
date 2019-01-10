namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="UserReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"UserReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IUserReference))]
    public class NewUserReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="UserReference" /></summary>
        private Nutanix.Powershell.Models.IUserReference _userReference = new Nutanix.Powershell.Models.UserReference();
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
            _userReference.Kind = "user";
            WriteObject(_userReference);
        }
    }
}