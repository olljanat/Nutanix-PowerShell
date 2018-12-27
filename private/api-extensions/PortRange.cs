namespace Nutanix.Powershell.Models
{

    /// <summary>Range of TCP/UDP ports.</summary>
    [System.ComponentModel.TypeConverter(typeof(PortRangeTypeConverter))]
    public partial class PortRange
    {

        /// <summary>
        /// Creates a new instance of <see cref="PortRange" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IPortRange FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Range of TCP/UDP ports.
    [System.ComponentModel.TypeConverter(typeof(PortRangeTypeConverter))]
    public partial interface IPortRange {

    }
}