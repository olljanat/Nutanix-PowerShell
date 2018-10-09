namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INetworkSecurityRuleIntentInput))]
    public class NewNetworkSecurityRuleIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleIntentInput" /></summary>
        private Sample.API.Models.INetworkSecurityRuleIntentInput _networkSecurityRuleIntentInput = new Sample.API.Models.NetworkSecurityRuleIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _networkSecurityRuleIntentInput.ApiVersion = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList1
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList2
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter.KindList = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList3
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams1
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams2
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter.Params = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams3
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType1
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.FirstEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType2
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.SecondEntityFilter.Type = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType3
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>The network_security_rule kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The network_security_rule kind metadata")]
        public Sample.API.Models.INetworkSecurityRuleMetadata Metadata
        {
            set
            {
                _networkSecurityRuleIntentInput.Metadata = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string NetworkSecurityRuleDescription
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Description = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string NetworkSecurityRuleName
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Name = value;
            }
        }
        /// <summary>Type of deployment of the rule.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of deployment of the rule.")]
        public string NetworkSecurityRuleResourcesAppRuleAction
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleInboundAllowList
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesAppRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.OutboundAllowList = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesIsolationRuleAction
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule = _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesIsolationRule();
                _networkSecurityRuleIntentInput.Spec.Resources.IsolationRule.Action = value;
            }
        }
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string NetworkSecurityRuleResourcesQuarantineRuleAction
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.Action = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleInboundAllowList
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] NetworkSecurityRuleResourcesQuarantineRuleOutboundAllowList
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.OutboundAllowList = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy1
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule = _networkSecurityRuleIntentInput.Spec.Resources.AppRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesAppRule();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.AppRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType1
        {
            set
            {
                _networkSecurityRuleIntentInput.Spec = _networkSecurityRuleIntentInput.Spec ?? new Sample.API.Models.NetworkSecurityRule();
                _networkSecurityRuleIntentInput.Spec.Resources = _networkSecurityRuleIntentInput.Spec.Resources ?? new Sample.API.Models.NetworkSecurityRuleResources();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule ?? new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup = _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleIntentInput.Spec.Resources.QuarantineRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleIntentInput);
        }
    }
}