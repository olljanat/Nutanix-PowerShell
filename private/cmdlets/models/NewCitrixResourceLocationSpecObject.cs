namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CitrixResourceLocationSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CitrixResourceLocationSpecObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICitrixResourceLocationSpec))]
    public class NewCitrixResourceLocationSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CitrixResourceLocationSpec" /></summary>
        private Nutanix.Powershell.Models.ICitrixResourceLocationSpec _citrixResourceLocationSpec = new Nutanix.Powershell.Models.CitrixResourceLocationSpec();
        /// <summary>The resource location id.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource location id.")]
        public string Id
        {
            set
            {
                _citrixResourceLocationSpec.Id = value;
            }
        }
        /// <summary>The resource location name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource location name.")]
        public string Name
        {
            set
            {
                _citrixResourceLocationSpec.Name = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_citrixResourceLocationSpec);
        }
    }
}