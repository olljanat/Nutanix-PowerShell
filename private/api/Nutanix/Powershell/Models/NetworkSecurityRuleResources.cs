namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Network security rule resources</summary>
    public partial class NetworkSecurityRuleResources : Nutanix.Powershell.Models.INetworkSecurityRuleResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="AppRule" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule _appRule;

        /// <summary>
        /// These rules govern what flows are allowed. Target group is a required attribute. Empty inbound_allow_list will not anything
        /// into target group. Empty outbound_allow_list will allow everything from target group.
        /// </summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule AppRule
        {
            get
            {
                return this._appRule;
            }
            set
            {
                this._appRule = value;
            }
        }
        /// <summary>Backing field for <see cref="IsolationRule" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule _isolationRule;

        /// <summary>These rules are used for environmental isolation.</summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule IsolationRule
        {
            get
            {
                return this._isolationRule;
            }
            set
            {
                this._isolationRule = value;
            }
        }
        /// <summary>Backing field for <see cref="QuarantineRule" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResourcesQuarantineRule _quarantineRule;

        /// <summary>
        /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
        /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
        /// </summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleResourcesQuarantineRule QuarantineRule
        {
            get
            {
                return this._quarantineRule;
            }
            set
            {
                this._quarantineRule = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkSecurityRuleResources" /> instance.</summary>
        public NetworkSecurityRuleResources()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(AppRule), AppRule);
            await eventListener.AssertObjectIsValid(nameof(IsolationRule), IsolationRule);
            await eventListener.AssertObjectIsValid(nameof(QuarantineRule), QuarantineRule);
        }
    }
    /// Network security rule resources
    public partial interface INetworkSecurityRuleResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule AppRule { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule IsolationRule { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleResourcesQuarantineRule QuarantineRule { get; set; }
    }
}