namespace Nutanix.Powershell.Models
{

    /// <summary>Specification for multicluster configuration request.</summary>
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigSpecTypeConverter))]
    public partial class MulticlusterConfigSpec
    {

        /// <summary>
        /// Creates a new instance of <see cref="MulticlusterConfigSpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IMulticlusterConfigSpec FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specification for multicluster configuration request.
    [System.ComponentModel.TypeConverter(typeof(MulticlusterConfigSpecTypeConverter))]
    public partial interface IMulticlusterConfigSpec {

    }
}