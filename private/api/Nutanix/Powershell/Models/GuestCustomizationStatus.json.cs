namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
    /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
    /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
    /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
    /// is set to "True" then the deployer can upload their own custom script.
    /// </summary>
    public partial class GuestCustomizationStatus
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IGuestCustomizationStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IGuestCustomizationStatus.</returns>
        public static Nutanix.Powershell.Models.IGuestCustomizationStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new GuestCustomizationStatus(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="GuestCustomizationStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal GuestCustomizationStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _cloudInit = If( json?.PropertyT<Carbon.Json.JsonObject>("cloud_init"), out var __jsonCloudInit) ? Nutanix.Powershell.Models.GuestCustomizationStatusCloudInit.FromJson(__jsonCloudInit) : CloudInit;
            _isOverridable = If( json?.PropertyT<Carbon.Json.JsonBoolean>("is_overridable"), out var __jsonIsOverridable) ? (bool?)__jsonIsOverridable : IsOverridable;
            _sysprep = If( json?.PropertyT<Carbon.Json.JsonObject>("sysprep"), out var __jsonSysprep) ? Nutanix.Powershell.Models.GuestCustomizationStatusSysprep.FromJson(__jsonSysprep) : Sysprep;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="GuestCustomizationStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GuestCustomizationStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != CloudInit ? (Carbon.Json.JsonNode) CloudInit.ToJson(null) : null, "cloud_init" ,container.Add );
            AddIf( null != IsOverridable ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)IsOverridable) : null, "is_overridable" ,container.Add );
            AddIf( null != Sysprep ? (Carbon.Json.JsonNode) Sysprep.ToJson(null) : null, "sysprep" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}