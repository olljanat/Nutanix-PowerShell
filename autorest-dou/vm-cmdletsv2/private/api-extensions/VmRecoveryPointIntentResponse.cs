namespace Sample.API.Models
{

    /// <summary>Response object for intentful operations on a vm_recovery_point</summary>
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointIntentResponseTypeConverter))]
    public partial class VmRecoveryPointIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmRecoveryPointIntentResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmRecoveryPointIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operations on a vm_recovery_point
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointIntentResponseTypeConverter))]
    public partial interface IVmRecoveryPointIntentResponse {

    }
}