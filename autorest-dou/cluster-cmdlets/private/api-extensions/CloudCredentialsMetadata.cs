namespace Sample.API.Models
{

    /// <summary>The cloud_credentials kind metadata</summary>
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsMetadataTypeConverter))]
    public partial class CloudCredentialsMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="CloudCredentialsMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICloudCredentialsMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The cloud_credentials kind metadata
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsMetadataTypeConverter))]
    public partial interface ICloudCredentialsMetadata {

    }
}