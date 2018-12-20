namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CategoryQueryInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CategoryQueryInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICategoryQueryInput))]
    public class NewCategoryQueryInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CategoryQueryInput" /></summary>
        private Nutanix.Powershell.Models.ICategoryQueryInput _categoryQueryInput = new Nutanix.Powershell.Models.CategoryQueryInput();
        /// <summary>API version.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "API version.")]
        public string ApiVersion
        {
            set
            {
                _categoryQueryInput.ApiVersion = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _categoryQueryInput.CategoryFilter = _categoryQueryInput.CategoryFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _categoryQueryInput.CategoryFilter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _categoryQueryInput.CategoryFilter = _categoryQueryInput.CategoryFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _categoryQueryInput.CategoryFilter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _categoryQueryInput.CategoryFilter = _categoryQueryInput.CategoryFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _categoryQueryInput.CategoryFilter.Type = value;
            }
        }
        /// <summary>The maximum number of members to return per group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The maximum number of members to return per group.")]
        public long GroupMemberCount
        {
            set
            {
                _categoryQueryInput.GroupMemberCount = value;
            }
        }
        /// <summary>The offset into the total member set to return per group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The offset into the total member set to return per group.")]
        public long GroupMemberOffset
        {
            set
            {
                _categoryQueryInput.GroupMemberOffset = value;
            }
        }
        /// <summary>
        /// USED_IN - to get policies in which specified categories are used.APPLIED_TO - to get entities attached to specified categories.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "USED_IN - to get policies in which specified categories are used.APPLIED_TO - to get entities attached to specified categories.")]
        public string UsageType
        {
            set
            {
                _categoryQueryInput.UsageType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_categoryQueryInput);
        }
    }
}