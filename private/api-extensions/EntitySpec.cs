namespace Nutanix.Powershell.Models
{

    /// <summary>Specification of the entities which need to be placed</summary>
    [System.ComponentModel.TypeConverter(typeof(EntitySpecTypeConverter))]
    public partial class EntitySpec
    {

        /// <summary>
        /// Creates a new instance of <see cref="EntitySpec" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IEntitySpec FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Specification of the entities which need to be placed
    [System.ComponentModel.TypeConverter(typeof(EntitySpecTypeConverter))]
    public partial interface IEntitySpec {

    }
}