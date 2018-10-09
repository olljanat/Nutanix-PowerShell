namespace Sample.API.Models
{

    /// <summary>
    /// All api calls that return a list will have this metadata block
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ImageListMetadataOutputTypeConverter))]
    public partial class ImageListMetadataOutput
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageListMetadataOutput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IImageListMetadataOutput FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// All api calls that return a list will have this metadata block
    [System.ComponentModel.TypeConverter(typeof(ImageListMetadataOutputTypeConverter))]
    public partial interface IImageListMetadataOutput {

    }
}