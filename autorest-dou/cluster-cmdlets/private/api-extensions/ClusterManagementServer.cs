namespace Sample.API.Models
{

    /// <summary>Cluster Management server information.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterManagementServerTypeConverter))]
    public partial class ClusterManagementServer
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterManagementServer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterManagementServer FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cluster Management server information.
    [System.ComponentModel.TypeConverter(typeof(ClusterManagementServerTypeConverter))]
    public partial interface IClusterManagementServer {

    }
}