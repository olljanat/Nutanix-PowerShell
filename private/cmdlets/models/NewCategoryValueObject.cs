namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CategoryValue" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CategoryValueObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICategoryValue))]
    public class NewCategoryValueObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CategoryValue" /></summary>
        private Nutanix.Powershell.Models.ICategoryValue _categoryValue = new Nutanix.Powershell.Models.CategoryValue();
        /// <summary>API version.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "API version.")]
        public string ApiVersion
        {
            set
            {
                _categoryValue.ApiVersion = value;
            }
        }
        /// <summary>Description of the category value.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Description of the category value.")]
        public string Description
        {
            set
            {
                _categoryValue.Description = value;
            }
        }
        /// <summary>Value for the category.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Value for the category.")]
        public string Value
        {
            set
            {
                _categoryValue.Value = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_categoryValue);
        }
    }
}