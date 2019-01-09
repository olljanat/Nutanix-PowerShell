namespace Nutanix.Powershell.Models
{

    /// <summary>Entity placement spec</summary>
    [System.ComponentModel.TypeConverter(typeof(PlacementSpecTypeConverter))]
    public partial class PlacementSpec
    {

        /// <summary>
        /// Creates a new instance of <see cref="PlacementSpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IPlacementSpec FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Entity placement spec
    [System.ComponentModel.TypeConverter(typeof(PlacementSpecTypeConverter))]
    public partial interface IPlacementSpec {

    }
}