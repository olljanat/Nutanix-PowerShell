namespace Nutanix.Powershell.Models
{

    /// <summary>CA chain spec</summary>
    [System.ComponentModel.TypeConverter(typeof(CaChainSpecTypeConverter))]
    public partial class CaChainSpec
    {

        /// <summary>
        /// Creates a new instance of <see cref="CaChainSpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICaChainSpec FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// CA chain spec
    [System.ComponentModel.TypeConverter(typeof(CaChainSpecTypeConverter))]
    public partial interface ICaChainSpec {

    }
}