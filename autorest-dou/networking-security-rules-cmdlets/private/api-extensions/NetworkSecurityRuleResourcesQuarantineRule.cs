namespace Sample.API.Models
{

    /// <summary>
    /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
    /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityRuleResourcesQuarantineRuleTypeConverter))]
    public partial class NetworkSecurityRuleResourcesQuarantineRule
    {

        /// <summary>
        /// Creates a new instance of <see cref="NetworkSecurityRuleResourcesQuarantineRule" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
    /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityRuleResourcesQuarantineRuleTypeConverter))]
    public partial interface INetworkSecurityRuleResourcesQuarantineRule {

    }
}