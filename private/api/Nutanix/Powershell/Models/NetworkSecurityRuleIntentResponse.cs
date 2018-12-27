namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a network_security_rule</summary>
    public partial class NetworkSecurityRuleIntentResponse : Nutanix.Powershell.Models.INetworkSecurityRuleIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleMetadata _metadata;

        /// <summary>The network_security_rule kind metadata</summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for <see cref="Spec" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRule _spec;

        /// <summary>Network security rule</summary>
        public Nutanix.Powershell.Models.INetworkSecurityRule Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkSecurityRuleDefStatus _status;

        /// <summary>Network security rule status</summary>
        public Nutanix.Powershell.Models.INetworkSecurityRuleDefStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkSecurityRuleIntentResponse" /> instance.</summary>
        public NetworkSecurityRuleIntentResponse()
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
            await eventListener.AssertNotNull(nameof(ApiVersion),ApiVersion);
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
    }
    /// Response object for intentful operations on a network_security_rule
    public partial interface INetworkSecurityRuleIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRule Spec { get; set; }
        Nutanix.Powershell.Models.INetworkSecurityRuleDefStatus Status { get; set; }
    }
}