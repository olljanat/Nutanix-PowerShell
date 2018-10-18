namespace Sample.API.Models
{

    /// <summary>
    /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
    /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
    /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
    /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
    /// is set to "True" then the deployer can upload their own custom script.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(GuestCustomizationTypeConverter))]
    public partial class GuestCustomization
    {

        /// <summary>
        /// Creates a new instance of <see cref="GuestCustomization" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IGuestCustomization FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
    /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
    /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
    /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
    /// is set to "True" then the deployer can upload their own custom script.
    [System.ComponentModel.TypeConverter(typeof(GuestCustomizationTypeConverter))]
    public partial interface IGuestCustomization {

    }
}