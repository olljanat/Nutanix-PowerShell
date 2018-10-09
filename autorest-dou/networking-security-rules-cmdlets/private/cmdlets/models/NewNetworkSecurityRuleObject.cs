namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRule" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INetworkSecurityRule))]
    public class NewNetworkSecurityRuleObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRule" /></summary>
        private Sample.API.Models.INetworkSecurityRule _networkSecurityRule = new Sample.API.Models.NetworkSecurityRule();
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.TargetGroup = _networkSecurityRule.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter = _networkSecurityRule.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList1
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList2
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList3
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup = _networkSecurityRule.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.TargetGroup = _networkSecurityRule.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter = _networkSecurityRule.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams1
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams2
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams3
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup = _networkSecurityRule.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.TargetGroup = _networkSecurityRule.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter = _networkSecurityRule.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.AppRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType1
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.FirstEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType2
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.IsolationRule.SecondEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType3
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup = _networkSecurityRule.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Description
        {
            set
            {
                _networkSecurityRule.Description = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _networkSecurityRule.Name = value;
            }
        }
        /// <summary>Type of deployment of the rule.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of deployment of the rule.")]
        public string NetworkSecurityRuleResourcesAppRuleAction
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleInboundAllowList
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.OutboundAllowList = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesIsolationRuleAction
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.IsolationRule = _networkSecurityRule.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRule.Resources.IsolationRule.Action = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesQuarantineRuleAction
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleInboundAllowList
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.OutboundAllowList = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.TargetGroup = _networkSecurityRule.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.AppRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy1
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup = _networkSecurityRule.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.AppRule = _networkSecurityRule.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRule.Resources.AppRule.TargetGroup = _networkSecurityRule.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.AppRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType1
        {
            set
            {
                _networkSecurityRule.Resources = _networkSecurityRule.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRule.Resources.QuarantineRule = _networkSecurityRule.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup = _networkSecurityRule.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRule.Resources.QuarantineRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRule);
        }
    }
}