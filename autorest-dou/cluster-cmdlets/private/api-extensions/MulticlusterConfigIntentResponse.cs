namespace Sample.API.Models
{

    /// <summary>An intentful representation of a multicluster config response.</summary>
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigIntentResponseTypeConverter))]
    public partial class MulticlusterConfigIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="MulticlusterConfigIntentResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMulticlusterConfigIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An intentful representation of a multicluster config response.
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigIntentResponseTypeConverter))]
    public partial interface IMulticlusterConfigIntentResponse {

    }
}