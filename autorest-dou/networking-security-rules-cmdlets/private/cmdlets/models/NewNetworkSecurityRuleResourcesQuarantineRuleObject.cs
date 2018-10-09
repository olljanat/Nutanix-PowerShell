namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleResourcesQuarantineRule" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleResourcesQuarantineRuleObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule))]
    public class NewNetworkSecurityRuleResourcesQuarantineRuleObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleResourcesQuarantineRule" /></summary>
        private Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule _networkSecurityRuleResourcesQuarantineRule = new Sample.API.Models.NetworkSecurityRuleResourcesQuarantineRule();
        /// <summary>Type of action.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Type of action.")]
        public string Action
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.Action = value;
            }
        }
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup = _networkSecurityRuleResourcesQuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter = _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup = _networkSecurityRuleResourcesQuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter = _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup = _networkSecurityRuleResourcesQuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter = _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.Filter.Type = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] InboundAllowList
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.InboundAllowList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public Sample.API.Models.INetworkRule[] OutboundAllowList
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.OutboundAllowList = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string TargetGroupDefaultInternalPolicy
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup = _networkSecurityRuleResourcesQuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string TargetGroupPeerSpecificationType
        {
            set
            {
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup = _networkSecurityRuleResourcesQuarantineRule.TargetGroup ?? new Sample.API.Models.TargetGroup();
                _networkSecurityRuleResourcesQuarantineRule.TargetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleResourcesQuarantineRule);
        }
    }
}