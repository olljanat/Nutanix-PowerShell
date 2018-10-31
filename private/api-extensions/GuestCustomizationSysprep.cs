namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// If this field is set, the guest will be customized using Sysprep. Either unattend_xml or custom_key_values should be provided.
    /// If custom_key_values are provided then the unattended answer file will be generated using these key-value pairs.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(GuestCustomizationSysprepTypeConverter))]
    public partial class GuestCustomizationSysprep
    {

        /// <summary>
        /// Creates a new instance of <see cref="GuestCustomizationSysprep" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IGuestCustomizationSysprep FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// If this field is set, the guest will be customized using Sysprep. Either unattend_xml or custom_key_values should be provided.
    /// If custom_key_values are provided then the unattended answer file will be generated using these key-value pairs.
    [System.ComponentModel.TypeConverter(typeof(GuestCustomizationSysprepTypeConverter))]
    public partial interface IGuestCustomizationSysprep {

    }
}