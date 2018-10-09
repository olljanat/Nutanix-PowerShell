namespace Sample.API.Models
{

    /// <summary>The multicluster_config kind metadata</summary>
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigMetadataTypeConverter))]
    public partial class MulticlusterConfigMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="MulticlusterConfigMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMulticlusterConfigMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The multicluster_config kind metadata
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigMetadataTypeConverter))]
    public partial interface IMulticlusterConfigMetadata {

    }
}