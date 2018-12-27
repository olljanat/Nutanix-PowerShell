namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.INetworkSecurityRuleResources))]
    public class NewNetworkSecurityRuleResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleResources" /></summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResources _networkSecurityRuleResources = new Nutanix.Powershell.Models.NetworkSecurityRuleResources();
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.TargetGroup = _networkSecurityRuleResources.AppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter = _networkSecurityRuleResources.AppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList1
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter = _networkSecurityRuleResources.IsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList2
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter = _networkSecurityRuleResources.IsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList3
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup = _networkSecurityRuleResources.QuarantineRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.TargetGroup = _networkSecurityRuleResources.AppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter = _networkSecurityRuleResources.AppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams1
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter = _networkSecurityRuleResources.IsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams2
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter = _networkSecurityRuleResources.IsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams3
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup = _networkSecurityRuleResources.QuarantineRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.TargetGroup = _networkSecurityRuleResources.AppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter = _networkSecurityRuleResources.AppRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.AppRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType1
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter = _networkSecurityRuleResources.IsolationRule.FirstEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.FirstEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType2
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter = _networkSecurityRuleResources.IsolationRule.SecondEntityFilter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.IsolationRule.SecondEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType3
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup = _networkSecurityRuleResources.QuarantineRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter ?? new Nutanix.Powershell.Models.CategoryFilter();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>Type of deployment of the rule.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of deployment of the rule.")]
        public string NetworkSecurityRuleResourcesAppRuleAction
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleInboundAllowList
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.OutboundAllowList = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesIsolationRuleAction
        {
            set
            {
                _networkSecurityRuleResources.IsolationRule = _networkSecurityRuleResources.IsolationRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleResources.IsolationRule.Action = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesQuarantineRuleAction
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleInboundAllowList
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Nutanix.Powershell.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.OutboundAllowList = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.TargetGroup = _networkSecurityRuleResources.AppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.AppRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy1
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup = _networkSecurityRuleResources.QuarantineRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType
        {
            set
            {
                _networkSecurityRuleResources.AppRule = _networkSecurityRuleResources.AppRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleResources.AppRule.TargetGroup = _networkSecurityRuleResources.AppRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.AppRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType1
        {
            set
            {
                _networkSecurityRuleResources.QuarantineRule = _networkSecurityRuleResources.QuarantineRule ?? new Nutanix.Powershell.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup = _networkSecurityRuleResources.QuarantineRule.TargetGroup ?? new Nutanix.Powershell.Models.TargetGroup();
                _networkSecurityRuleResources.QuarantineRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleResources);
        }
    }
}