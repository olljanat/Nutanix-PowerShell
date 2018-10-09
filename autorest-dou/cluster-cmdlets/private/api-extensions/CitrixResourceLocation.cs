namespace Sample.API.Models
{

    /// <summary>Resource Location on Citrix Cloud.</summary>
    [System.ComponentModel.TypeConverter(typeof(CitrixResourceLocationTypeConverter))]
    public partial class CitrixResourceLocation
    {

        /// <summary>
        /// Creates a new instance of <see cref="CitrixResourceLocation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICitrixResourceLocation FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Resource Location on Citrix Cloud.
    [System.ComponentModel.TypeConverter(typeof(CitrixResourceLocationTypeConverter))]
    public partial interface ICitrixResourceLocation {

    }
}