namespace Sample.API.Models
{

    /// <summary>IP pool.</summary>
    [System.ComponentModel.TypeConverter(typeof(IpPoolTypeConverter))]
    public partial class IpPool
    {

        /// <summary>
        /// Creates a new instance of <see cref="IpPool" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IIpPool FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// IP pool.
    [System.ComponentModel.TypeConverter(typeof(IpPoolTypeConverter))]
    public partial interface IIpPool {

    }
}