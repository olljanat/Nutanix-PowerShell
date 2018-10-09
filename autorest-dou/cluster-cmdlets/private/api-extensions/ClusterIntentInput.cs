namespace Sample.API.Models
{

    /// <summary>An intentful representation of a cluster</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterIntentInputTypeConverter))]
    public partial class ClusterIntentInput
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterIntentInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterIntentInput FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An intentful representation of a cluster
    [System.ComponentModel.TypeConverter(typeof(ClusterIntentInputTypeConverter))]
    public partial interface IClusterIntentInput {

    }
}