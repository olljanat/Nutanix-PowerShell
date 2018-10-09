namespace Sample.API.Models
{

    /// <summary>Response object for intentful operations on a cloud_credentials</summary>
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsIntentResourceTypeConverter))]
    public partial class CloudCredentialsIntentResource
    {

        /// <summary>
        /// Creates a new instance of <see cref="CloudCredentialsIntentResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICloudCredentialsIntentResource FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operations on a cloud_credentials
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsIntentResourceTypeConverter))]
    public partial interface ICloudCredentialsIntentResource {

    }
}