namespace Sample.API.Models
{

    /// <summary>The input object that defines a VM snapshot</summary>
    [System.ComponentModel.TypeConverter(typeof(VmSnapshotTypeConverter))]
    public partial class VmSnapshot
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmSnapshot" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmSnapshot FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The input object that defines a VM snapshot
    [System.ComponentModel.TypeConverter(typeof(VmSnapshotTypeConverter))]
    public partial interface IVmSnapshot {

    }
}