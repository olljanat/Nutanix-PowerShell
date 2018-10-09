namespace Sample.API.Models
{

    /// <summary>Response object for intentful operations on a subnet</summary>
    [System.ComponentModel.TypeConverter(typeof(SubnetIntentResponseTypeConverter))]
    public partial class SubnetIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="SubnetIntentResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ISubnetIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operations on a subnet
    [System.ComponentModel.TypeConverter(typeof(SubnetIntentResponseTypeConverter))]
    public partial interface ISubnetIntentResponse {

    }
}