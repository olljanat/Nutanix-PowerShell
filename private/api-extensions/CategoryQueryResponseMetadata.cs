namespace Nutanix.Powershell.Models
{

    /// <summary>Response metadata.</summary>
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseMetadataTypeConverter))]
    public partial class CategoryQueryResponseMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="CategoryQueryResponseMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICategoryQueryResponseMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response metadata.
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseMetadataTypeConverter))]
    public partial interface ICategoryQueryResponseMetadata {

    }
}