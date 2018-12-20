namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CategoryFilter" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CategoryFilterObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICategoryFilter))]
    public class NewCategoryFilterObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CategoryFilter" /></summary>
        private Nutanix.Powershell.Models.ICategoryFilter _categoryFilter = new Nutanix.Powershell.Models.CategoryFilter();
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] KindList
        {
            set
            {
                _categoryFilter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> Params
        {
            set
            {
                _categoryFilter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string Type
        {
            set
            {
                _categoryFilter.Type = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_categoryFilter);
        }
    }
}