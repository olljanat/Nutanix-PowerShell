namespace Sample.API.Models
{

    /// <summary>
    /// Specify the cluster and image(s) from the cluster to migrate to PC
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ImageMigrateInputTypeConverter))]
    public partial class ImageMigrateInput
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageMigrateInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IImageMigrateInput FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specify the cluster and image(s) from the cluster to migrate to PC
    [System.ComponentModel.TypeConverter(typeof(ImageMigrateInputTypeConverter))]
    public partial interface IImageMigrateInput {

    }
}