namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// Customer information used in Certificate Signing Request for
    /// creating digital certificates.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CertificationSigningInfoTypeConverter))]
    public partial class CertificationSigningInfo
    {

        /// <summary>
        /// Creates a new instance of <see cref="CertificationSigningInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICertificationSigningInfo FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Customer information used in Certificate Signing Request for
    /// creating digital certificates.
    [System.ComponentModel.TypeConverter(typeof(CertificationSigningInfoTypeConverter))]
    public partial interface ICertificationSigningInfo {

    }
}