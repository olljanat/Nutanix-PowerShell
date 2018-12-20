namespace Nutanix.Powershell.Models
{

    /// <summary>Categories query response object.</summary>
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseTypeConverter))]
    public partial class CategoryQueryResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="CategoryQueryResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICategoryQueryResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Categories query response object.
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseTypeConverter))]
    public partial interface ICategoryQueryResponse {

    }
}