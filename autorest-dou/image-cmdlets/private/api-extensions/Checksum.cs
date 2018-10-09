namespace Sample.API.Models
{

    /// <summary>Image checksum</summary>
    [System.ComponentModel.TypeConverter(typeof(ChecksumTypeConverter))]
    public partial class Checksum
    {

        /// <summary>
        /// Creates a new instance of <see cref="Checksum" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IChecksum FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Image checksum
    [System.ComponentModel.TypeConverter(typeof(ChecksumTypeConverter))]
    public partial interface IChecksum {

    }
}