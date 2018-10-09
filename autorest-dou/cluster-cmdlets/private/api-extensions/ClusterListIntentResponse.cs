namespace Sample.API.Models
{

    /// <summary>Response object for intentful operation of clusters</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterListIntentResponseTypeConverter))]
    public partial class ClusterListIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterListIntentResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterListIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operation of clusters
    [System.ComponentModel.TypeConverter(typeof(ClusterListIntentResponseTypeConverter))]
    public partial interface IClusterListIntentResponse {

    }
}