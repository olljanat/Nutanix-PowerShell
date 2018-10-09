namespace Sample.API.Models
{

    /// <summary>An intentful representation of a image spec</summary>
    [System.ComponentModel.TypeConverter(typeof(ImageTypeConverter))]
    public partial class Image
    {

        /// <summary>
        /// Creates a new instance of <see cref="Image" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IImage FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An intentful representation of a image spec
    [System.ComponentModel.TypeConverter(typeof(ImageTypeConverter))]
    public partial interface IImage {

    }
}