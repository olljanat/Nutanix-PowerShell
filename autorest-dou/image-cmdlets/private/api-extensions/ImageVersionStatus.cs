namespace Sample.API.Models
{

    /// <summary>
    /// The image version, which is composed of a product name and product version.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ImageVersionStatusTypeConverter))]
    public partial class ImageVersionStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageVersionStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IImageVersionStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The image version, which is composed of a product name and product version.
    [System.ComponentModel.TypeConverter(typeof(ImageVersionStatusTypeConverter))]
    public partial interface IImageVersionStatus {

    }
}