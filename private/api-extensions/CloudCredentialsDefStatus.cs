namespace Nutanix.Powershell.Models
{

    /// <summary>Cloud credentials configuration</summary>
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsDefStatusTypeConverter))]
    public partial class CloudCredentialsDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="CloudCredentialsDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICloudCredentialsDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cloud credentials configuration
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsDefStatusTypeConverter))]
    public partial interface ICloudCredentialsDefStatus {

    }
}