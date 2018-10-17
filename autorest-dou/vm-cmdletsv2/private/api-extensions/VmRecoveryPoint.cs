namespace Sample.API.Models
{

    /// <summary>The input object that defines a vm recovery point.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointTypeConverter))]
    public partial class VmRecoveryPoint
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmRecoveryPoint" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmRecoveryPoint FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The input object that defines a vm recovery point.
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointTypeConverter))]
    public partial interface IVmRecoveryPoint {

    }
}