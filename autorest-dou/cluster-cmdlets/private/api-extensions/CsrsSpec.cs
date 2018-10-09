namespace Sample.API.Models
{

    /// <summary>
    /// Spec for CSRs download. If node uuid list is empty, all cluster nodes will
    /// be assumed.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CsrsSpecTypeConverter))]
    public partial class CsrsSpec
    {

        /// <summary>
        /// Creates a new instance of <see cref="CsrsSpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICsrsSpec FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Spec for CSRs download. If node uuid list is empty, all cluster nodes will
    /// be assumed.
    [System.ComponentModel.TypeConverter(typeof(CsrsSpecTypeConverter))]
    public partial interface ICsrsSpec {

    }
}