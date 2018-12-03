namespace Nutanix.Powershell.Models
{

    /// <summary>The subnet kind metadata</summary>
    [System.ComponentModel.TypeConverter(typeof(SubnetMetadataTypeConverter))]
    public partial class SubnetMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="SubnetMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ISubnetMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The subnet kind metadata
    [System.ComponentModel.TypeConverter(typeof(SubnetMetadataTypeConverter))]
    public partial interface ISubnetMetadata {

    }
}