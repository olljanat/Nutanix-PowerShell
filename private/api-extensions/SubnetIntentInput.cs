namespace Nutanix.Powershell.Models
{

    /// <summary>An intentful representation of a subnet</summary>
    [System.ComponentModel.TypeConverter(typeof(SubnetIntentInputTypeConverter))]
    public partial class SubnetIntentInput
    {

        /// <summary>
        /// Creates a new instance of <see cref="SubnetIntentInput" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ISubnetIntentInput FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An intentful representation of a subnet
    [System.ComponentModel.TypeConverter(typeof(SubnetIntentInputTypeConverter))]
    public partial interface ISubnetIntentInput {

    }
}