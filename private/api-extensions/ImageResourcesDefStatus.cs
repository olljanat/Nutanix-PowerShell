namespace Nutanix.Powershell.Models
{

    /// <summary>Describes the image status resources object.</summary>
    [System.ComponentModel.TypeConverter(typeof(ImageResourcesDefStatusTypeConverter))]
    public partial class ImageResourcesDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageResourcesDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IImageResourcesDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the image status resources object.
    [System.ComponentModel.TypeConverter(typeof(ImageResourcesDefStatusTypeConverter))]
    public partial interface IImageResourcesDefStatus {

    }
}