namespace Sample.API.Models
{

    /// <summary>Spec for defining DHCP options.</summary>
    [System.ComponentModel.TypeConverter(typeof(DhcpOptionsTypeConverter))]
    public partial class DhcpOptions
    {

        /// <summary>
        /// Creates a new instance of <see cref="DhcpOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IDhcpOptions FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Spec for defining DHCP options.
    [System.ComponentModel.TypeConverter(typeof(DhcpOptionsTypeConverter))]
    public partial interface IDhcpOptions {

    }
}