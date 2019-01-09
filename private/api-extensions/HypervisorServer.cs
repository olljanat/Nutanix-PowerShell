namespace Nutanix.Powershell.Models
{

    /// <summary>Hypervisor server information.</summary>
    [System.ComponentModel.TypeConverter(typeof(HypervisorServerTypeConverter))]
    public partial class HypervisorServer
    {

        /// <summary>
        /// Creates a new instance of <see cref="HypervisorServer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IHypervisorServer FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Hypervisor server information.
    [System.ComponentModel.TypeConverter(typeof(HypervisorServerTypeConverter))]
    public partial interface IHypervisorServer {

    }
}