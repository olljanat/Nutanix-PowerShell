namespace Nutanix.Powershell.Models
{

    /// <summary>Virtual Machine NIC.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmNicTypeConverter))]
    public partial class VmNic
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmNic" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmNic FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Virtual Machine NIC.
    [System.ComponentModel.TypeConverter(typeof(VmNicTypeConverter))]
    public partial interface IVmNic {

    }
}