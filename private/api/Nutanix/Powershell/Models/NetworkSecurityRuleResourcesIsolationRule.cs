namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>These rules are used for environmental isolation.</summary>
    public partial class NetworkSecurityRuleResourcesIsolationRule : Nutanix.Powershell.Models.INetworkSecurityRuleResourcesIsolationRule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>Type of action.</summary>
        public string Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
        /// <summary>Backing field for <see cref="FirstEntityFilter" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryFilter _firstEntityFilter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Nutanix.Powershell.Models.ICategoryFilter FirstEntityFilter
        {
            get
            {
                return this._firstEntityFilter;
            }
            set
            {
                this._firstEntityFilter = value;
            }
        }
        /// <summary>Backing field for <see cref="SecondEntityFilter" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryFilter _secondEntityFilter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Nutanix.Powershell.Models.ICategoryFilter SecondEntityFilter
        {
            get
            {
                return this._secondEntityFilter;
            }
            set
            {
                this._secondEntityFilter = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="NetworkSecurityRuleResourcesIsolationRule" /> instance.
        /// </summary>
        public NetworkSecurityRuleResourcesIsolationRule()
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
            await eventListener.AssertObjectIsValid(nameof(FirstEntityFilter), FirstEntityFilter);
            await eventListener.AssertObjectIsValid(nameof(SecondEntityFilter), SecondEntityFilter);
        }
    }
    /// These rules are used for environmental isolation.
    public partial interface INetworkSecurityRuleResourcesIsolationRule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Action { get; set; }
        Nutanix.Powershell.Models.ICategoryFilter FirstEntityFilter { get; set; }
        Nutanix.Powershell.Models.ICategoryFilter SecondEntityFilter { get; set; }
    }
}