namespace Sample.API.Models
{

    /// <summary>Extra configs related to power state transition.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmGuestPowerStateTransitionConfigTypeConverter))]
    public partial class VmGuestPowerStateTransitionConfig
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmGuestPowerStateTransitionConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IVmGuestPowerStateTransitionConfig FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Extra configs related to power state transition.
    [System.ComponentModel.TypeConverter(typeof(VmGuestPowerStateTransitionConfigTypeConverter))]
    public partial interface IVmGuestPowerStateTransitionConfig {

    }
}