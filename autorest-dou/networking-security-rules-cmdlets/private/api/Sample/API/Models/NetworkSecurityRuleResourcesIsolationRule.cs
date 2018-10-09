namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>These rules are used for environmental isolation.</summary>
    public partial class NetworkSecurityRuleResourcesIsolationRule : Sample.API.Models.INetworkSecurityRuleResourcesIsolationRule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Action property</summary>
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
        /// <summary>Backing field for FirstEntityFilter property</summary>
        private Sample.API.Models.ICategoryFilter _firstEntityFilter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Sample.API.Models.ICategoryFilter FirstEntityFilter
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
        /// <summary>Backing field for SecondEntityFilter property</summary>
        private Sample.API.Models.ICategoryFilter _secondEntityFilter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Sample.API.Models.ICategoryFilter SecondEntityFilter
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
        Sample.API.Models.ICategoryFilter FirstEntityFilter { get; set; }
        Sample.API.Models.ICategoryFilter SecondEntityFilter { get; set; }
    }
}