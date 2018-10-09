namespace Sample.API.Models
{

    /// <summary>VM Resources Status Definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmResourcesDefStatusTypeConverter))]
    public partial class VmResourcesDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmResourcesDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmResourcesDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// VM Resources Status Definition.
    [System.ComponentModel.TypeConverter(typeof(VmResourcesDefStatusTypeConverter))]
    public partial interface IVmResourcesDefStatus {

    }
}