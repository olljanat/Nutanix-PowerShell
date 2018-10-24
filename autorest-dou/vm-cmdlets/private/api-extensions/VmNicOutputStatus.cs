namespace Nutanix.Powershell.Models
{

    /// <summary>Virtual Machine NIC Status.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmNicOutputStatusTypeConverter))]
    public partial class VmNicOutputStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmNicOutputStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmNicOutputStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Virtual Machine NIC Status.
    [System.ComponentModel.TypeConverter(typeof(VmNicOutputStatusTypeConverter))]
    public partial interface IVmNicOutputStatus {

    }
}