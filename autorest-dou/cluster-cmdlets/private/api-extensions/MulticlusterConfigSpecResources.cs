namespace Sample.API.Models
{

    /// <summary>Multicluster config resources.</summary>
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigSpecResourcesTypeConverter))]
    public partial class MulticlusterConfigSpecResources
    {

        /// <summary>
        /// Creates a new instance of <see cref="MulticlusterConfigSpecResources" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IMulticlusterConfigSpecResources FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Multicluster config resources.
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigSpecResourcesTypeConverter))]
    public partial interface IMulticlusterConfigSpecResources {

    }
}