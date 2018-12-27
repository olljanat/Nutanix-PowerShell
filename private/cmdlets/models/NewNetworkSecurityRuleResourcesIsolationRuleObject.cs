namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleResourcesIsolationRule" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleResourcesIsolationRuleObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule))]
    public class NewNetworkSecurityRuleResourcesIsolationRuleObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleResourcesIsolationRule" /></summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule _networkSecurityRuleResourcesIsolationRule = new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string Action
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.Action = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter = _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList1
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter = _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter = _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams1
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter = _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter = _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.FirstEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType1
        {
            set
            {
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter = _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesIsolationRule.SecondEntityFilter.Type = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleResourcesIsolationRule);
        }
    }
}