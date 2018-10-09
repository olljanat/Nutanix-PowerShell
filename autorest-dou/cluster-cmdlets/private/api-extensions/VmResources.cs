namespace Sample.API.Models
{

    /// <summary>VM Resources Definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmResourcesTypeConverter))]
    public partial class VmResources
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmResources" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmResources FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// VM Resources Definition.
    [System.ComponentModel.TypeConverter(typeof(VmResourcesTypeConverter))]
    public partial interface IVmResources {

    }
}