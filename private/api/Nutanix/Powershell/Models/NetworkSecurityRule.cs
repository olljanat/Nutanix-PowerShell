namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Network security rule</summary>
    public partial class NetworkSecurityRule : Nutanix.Powershell.Models.INetworkSecurityRule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Resources" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleResources _resources;

        /// <summary>Network security rule resources</summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleResources Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkSecurityRule" /> instance.</summary>
        public NetworkSecurityRule()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertMaximumLength(nameof(Description),Description,1000);
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Network security rule
    public partial interface INetworkSecurityRule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Description { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleResources Resources { get; set; }
    }
}