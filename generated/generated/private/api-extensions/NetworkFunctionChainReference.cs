namespace Nutanix.Powershell.Models
{

    /// <summary>The reference to a network_function_chain</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkFunctionChainReferenceTypeConverter))]
    public partial class NetworkFunctionChainReference
    {

        /// <summary>
        /// Creates a new instance of <see cref="NetworkFunctionChainReference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.INetworkFunctionChainReference FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The reference to a network_function_chain
    [System.ComponentModel.TypeConverter(typeof(NetworkFunctionChainReferenceTypeConverter))]
    public partial interface INetworkFunctionChainReference {

    }
}