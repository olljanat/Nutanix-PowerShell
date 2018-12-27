namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Network security rule status</summary>
    public partial class NetworkSecurityRuleDefStatus : Nutanix.Powershell.Models.INetworkSecurityRuleDefStatus, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for <see cref="MessageList" /> property.</summary>
        private Nutanix.Powershell.Models.IMessageResource[] _messageList;

        public Nutanix.Powershell.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            set
            {
                this._messageList = value;
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
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkSecurityRuleDefStatus" /> instance.</summary>
        public NetworkSecurityRuleDefStatus()
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
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Network security rule status
    public partial interface INetworkSecurityRuleDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Description { get; set; }
        Nutanix.Powershell.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleResources Resources { get; set; }
        string State { get; set; }
    }
}