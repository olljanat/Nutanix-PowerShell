namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// Indicates the mechanism guiding the VM power state transition. Currently used for the transition to "OFF" state.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(VmPowerStateMechanismTypeConverter))]
    public partial class VmPowerStateMechanism
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmPowerStateMechanism" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmPowerStateMechanism FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Indicates the mechanism guiding the VM power state transition. Currently used for the transition to "OFF" state.
    [System.ComponentModel.TypeConverter(typeof(VmPowerStateMechanismTypeConverter))]
    public partial interface IVmPowerStateMechanism {

    }
}