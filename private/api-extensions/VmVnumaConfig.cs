namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// Indicates how VM vNUMA should be configured
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(VmVnumaConfigTypeConverter))]
    public partial class VmVnumaConfig
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmVnumaConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmVnumaConfig FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Indicates how VM vNUMA should be configured
    [System.ComponentModel.TypeConverter(typeof(VmVnumaConfigTypeConverter))]
    public partial interface IVmVnumaConfig {

    }
}