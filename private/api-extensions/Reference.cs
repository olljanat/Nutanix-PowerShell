namespace Nutanix.Powershell.Models
{

    /// <summary>Reference to a kind</summary>
    [System.ComponentModel.TypeConverter(typeof(ReferenceTypeConverter))]
    public partial class Reference
    {

        /// <summary>
        /// Creates a new instance of <see cref="Reference" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IReference FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Reference to a kind
    [System.ComponentModel.TypeConverter(typeof(ReferenceTypeConverter))]
    public partial interface IReference {

    }
}