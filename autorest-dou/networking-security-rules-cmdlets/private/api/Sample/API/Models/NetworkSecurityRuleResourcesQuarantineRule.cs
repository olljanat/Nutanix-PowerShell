namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
    /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
    /// </summary>
    public partial class NetworkSecurityRuleResourcesQuarantineRule : Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for InboundAllowList property</summary>
        private Sample.API.Models.INetworkRule[] _inboundAllowList;

        public Sample.API.Models.INetworkRule[] InboundAllowList
        {
            get
            {
                return this._inboundAllowList;
            }
            set
            {
                this._inboundAllowList = value;
            }
        }
        /// <summary>Backing field for OutboundAllowList property</summary>
        private Sample.API.Models.INetworkRule[] _outboundAllowList;

        public Sample.API.Models.INetworkRule[] OutboundAllowList
        {
            get
            {
                return this._outboundAllowList;
            }
            set
            {
                this._outboundAllowList = value;
            }
        }
        /// <summary>Backing field for TargetGroup property</summary>
        private Sample.API.Models.ITargetGroup _targetGroup;

        /// <summary>Target group</summary>
        public Sample.API.Models.ITargetGroup TargetGroup
        {
            get
            {
                return this._targetGroup;
            }
            set
            {
                this._targetGroup = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="NetworkSecurityRuleResourcesQuarantineRule" /> instance.
        /// </summary>
        public NetworkSecurityRuleResourcesQuarantineRule()
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
            if (InboundAllowList != null ) {
                    for (int __i = 0; __i < InboundAllowList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"InboundAllowList[{__i}]", InboundAllowList[__i]);
                    }
                  }
            if (OutboundAllowList != null ) {
                    for (int __i = 0; __i < OutboundAllowList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"OutboundAllowList[{__i}]", OutboundAllowList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(TargetGroup), TargetGroup);
        }
    }
    /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
    /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
    public partial interface INetworkSecurityRuleResourcesQuarantineRule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Action { get; set; }
        Sample.API.Models.INetworkRule[] InboundAllowList { get; set; }
        Sample.API.Models.INetworkRule[] OutboundAllowList { get; set; }
        Sample.API.Models.ITargetGroup TargetGroup { get; set; }
    }
}