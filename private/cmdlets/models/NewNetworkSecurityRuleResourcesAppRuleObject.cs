namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleResourcesAppRule" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleResourcesAppRuleObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule))]
    public class NewNetworkSecurityRuleResourcesAppRuleObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleResourcesAppRule" /></summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule _networkSecurityRuleResourcesAppRule = new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
        /// <summary>Type of deployment of the rule.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of deployment of the rule.")]
        public string Action
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.Action = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.TargetGroup = _networkSecurityRuleResourcesAppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter = _networkSecurityRuleResourcesAppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.TargetGroup = _networkSecurityRuleResourcesAppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter = _networkSecurityRuleResourcesAppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.TargetGroup = _networkSecurityRuleResourcesAppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter = _networkSecurityRuleResourcesAppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResourcesAppRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] InboundAllowList
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] OutboundAllowList
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.OutboundAllowList = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.TargetGroup = _networkSecurityRuleResourcesAppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResourcesAppRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType
        {
            set
            {
                _networkSecurityRuleResourcesAppRule.TargetGroup = _networkSecurityRuleResourcesAppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResourcesAppRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleResourcesAppRule);
        }
    }
}