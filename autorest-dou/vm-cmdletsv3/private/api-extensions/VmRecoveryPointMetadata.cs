namespace Sample.API.Models
{

    /// <summary>The vm_recovery_point kind metadata</summary>
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointMetadataTypeConverter))]
    public partial class VmRecoveryPointMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmRecoveryPointMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmRecoveryPointMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The vm_recovery_point kind metadata
    [System.ComponentModel.TypeConverter(typeof(VmRecoveryPointMetadataTypeConverter))]
    public partial interface IVmRecoveryPointMetadata {

    }
}