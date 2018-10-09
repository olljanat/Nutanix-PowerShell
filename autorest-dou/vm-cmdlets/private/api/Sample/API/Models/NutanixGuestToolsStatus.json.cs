namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Information regarding Nutanix Guest Tools.</summary>
    public partial class NutanixGuestToolsStatus
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.INutanixGuestToolsStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.INutanixGuestToolsStatus.</returns>
        public static Sample.API.Models.INutanixGuestToolsStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new NutanixGuestToolsStatus(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="NutanixGuestToolsStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal NutanixGuestToolsStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _availableVersion = If( json?.PropertyT<Carbon.Json.JsonString>("available_version"), out var __jsonAvailableVersion) ? (string)__jsonAvailableVersion : (string)AvailableVersion;
            _enabledCapabilityList = If( json?.PropertyT<Carbon.Json.JsonString>("enabled_capability_list"), out var __jsonEnabledCapabilityList) ? (string)__jsonEnabledCapabilityList : (string)EnabledCapabilityList;
            _guestOsVersion = If( json?.PropertyT<Carbon.Json.JsonString>("guest_os_version"), out var __jsonGuestOsVersion) ? (string)__jsonGuestOsVersion : (string)GuestOsVersion;
            _isReachable = If( json?.PropertyT<Carbon.Json.JsonBoolean>("is_reachable"), out var __jsonIsReachable) ? (bool?)__jsonIsReachable : IsReachable;
            _isoMountState = If( json?.PropertyT<Carbon.Json.JsonString>("iso_mount_state"), out var __jsonIsoMountState) ? (string)__jsonIsoMountState : (string)IsoMountState;
            _state = If( json?.PropertyT<Carbon.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;
            _version = If( json?.PropertyT<Carbon.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;
            _vmMobilityDriversInstalled = If( json?.PropertyT<Carbon.Json.JsonBoolean>("vm_mobility_drivers_installed"), out var __jsonVmMobilityDriversInstalled) ? (bool?)__jsonVmMobilityDriversInstalled : VmMobilityDriversInstalled;
            _vssSnapshotCapable = If( json?.PropertyT<Carbon.Json.JsonBoolean>("vss_snapshot_capable"), out var __jsonVssSnapshotCapable) ? (bool?)__jsonVssSnapshotCapable : VssSnapshotCapable;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="NutanixGuestToolsStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NutanixGuestToolsStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != AvailableVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(AvailableVersion) : null, "available_version" ,container.Add );
            AddIf( null != EnabledCapabilityList ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(EnabledCapabilityList) : null, "enabled_capability_list" ,container.Add );
            AddIf( null != GuestOsVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(GuestOsVersion) : null, "guest_os_version" ,container.Add );
            AddIf( null != IsReachable ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)IsReachable) : null, "is_reachable" ,container.Add );
            AddIf( null != IsoMountState ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(IsoMountState) : null, "iso_mount_state" ,container.Add );
            AddIf( null != State ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(State) : null, "state" ,container.Add );
            AddIf( null != Version ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Version) : null, "version" ,container.Add );
            AddIf( null != VmMobilityDriversInstalled ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)VmMobilityDriversInstalled) : null, "vm_mobility_drivers_installed" ,container.Add );
            AddIf( null != VssSnapshotCapable ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)VssSnapshotCapable) : null, "vss_snapshot_capable" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}