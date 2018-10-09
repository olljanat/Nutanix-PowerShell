namespace Sample.API.Models
{

    /// <summary>Cluster analysis related values.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterAnalysisTypeConverter))]
    public partial class ClusterAnalysis
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterAnalysis" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterAnalysis FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cluster analysis related values.
    [System.ComponentModel.TypeConverter(typeof(ClusterAnalysisTypeConverter))]
    public partial interface IClusterAnalysis {

    }
}