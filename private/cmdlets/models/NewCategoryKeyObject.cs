namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CategoryKey" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CategoryKeyObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICategoryKey))]
    public class NewCategoryKeyObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CategoryKey" /></summary>
        private Nutanix.Powershell.Models.ICategoryKey _categoryKey = new Nutanix.Powershell.Models.CategoryKey();
        // <summary>Description of the category.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Description of the category.")]
        public string Description
        {
            set
            {
                _categoryKey.Description = value;
            }
        }
        /// <summary>Name of the category.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the category.")]
        public string Name
        {
            set
            {
                _categoryKey.Name = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _categoryKey.ApiVersion = "3.1";
            WriteObject(_categoryKey);
        }
    }
}