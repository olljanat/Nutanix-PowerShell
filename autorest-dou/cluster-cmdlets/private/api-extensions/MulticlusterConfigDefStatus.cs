namespace Sample.API.Models
{

    /// <summary>Status for multicluster configuration request.</summary>
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigDefStatusTypeConverter))]
    public partial class MulticlusterConfigDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="MulticlusterConfigDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMulticlusterConfigDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Status for multicluster configuration request.
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigDefStatusTypeConverter))]
    public partial interface IMulticlusterConfigDefStatus {

    }
}