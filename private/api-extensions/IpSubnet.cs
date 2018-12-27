namespace Nutanix.Powershell.Models
{

    /// <summary>IP subnet provided as an address and prefix length.</summary>
    [System.ComponentModel.TypeConverter(typeof(IpSubnetTypeConverter))]
    public partial class IpSubnet
    {

        /// <summary>
        /// Creates a new instance of <see cref="IpSubnet" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IIpSubnet FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// IP subnet provided as an address and prefix length.
    [System.ComponentModel.TypeConverter(typeof(IpSubnetTypeConverter))]
    public partial interface IIpSubnet {

    }
}