namespace Nutanix.Powershell.Models
{

    /// <summary>SSL certificate.</summary>
    [System.ComponentModel.TypeConverter(typeof(SslKeyTypeConverter))]
    public partial class SslKey
    {

        /// <summary>
        /// Creates a new instance of <see cref="SslKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ISslKey FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SSL certificate.
    [System.ComponentModel.TypeConverter(typeof(SslKeyTypeConverter))]
    public partial interface ISslKey {

    }
}