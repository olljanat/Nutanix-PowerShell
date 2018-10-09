namespace Sample.API.Models
{

    /// <summary>Input spec for certificate upload.</summary>
    [System.ComponentModel.TypeConverter(typeof(CertificateSpecUploadInputTypeConverter))]
    public partial class CertificateSpecUploadInput
    {

        /// <summary>
        /// Creates a new instance of <see cref="CertificateSpecUploadInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICertificateSpecUploadInput FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Input spec for certificate upload.
    [System.ComponentModel.TypeConverter(typeof(CertificateSpecUploadInputTypeConverter))]
    public partial interface ICertificateSpecUploadInput {

    }
}