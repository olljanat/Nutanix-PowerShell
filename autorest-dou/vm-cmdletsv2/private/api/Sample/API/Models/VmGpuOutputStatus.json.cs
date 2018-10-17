namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Graphics resource status information for the Virtual Machine.</summary>
    public partial class VmGpuOutputStatus
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IVmGpuOutputStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IVmGpuOutputStatus.</returns>
        public static Sample.API.Models.IVmGpuOutputStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmGpuOutputStatus(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmGpuOutputStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmGpuOutputStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Name ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Name) : null, "name" ,container.Add );
            AddIf( null != DeviceId ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)DeviceId) : null, "device_id" ,container.Add );
            AddIf( null != Fraction ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)Fraction) : null, "fraction" ,container.Add );
            AddIf( null != FrameBufferSizeMib ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)FrameBufferSizeMib) : null, "frame_buffer_size_mib" ,container.Add );
            AddIf( null != GuestDriverVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(GuestDriverVersion) : null, "guest_driver_version" ,container.Add );
            AddIf( null != Mode ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Mode) : null, "mode" ,container.Add );
            AddIf( null != NumVirtualDisplayHeads ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)NumVirtualDisplayHeads) : null, "num_virtual_display_heads" ,container.Add );
            AddIf( null != PciAddress ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(PciAddress) : null, "pci_address" ,container.Add );
            AddIf( null != Uuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Uuid) : null, "uuid" ,container.Add );
            AddIf( null != Vendor ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Vendor) : null, "vendor" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmGpuOutputStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmGpuOutputStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Carbon.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _deviceId = If( json?.PropertyT<Carbon.Json.JsonNumber>("device_id"), out var __jsonDeviceId) ? (int?)__jsonDeviceId : DeviceId;
            _fraction = If( json?.PropertyT<Carbon.Json.JsonNumber>("fraction"), out var __jsonFraction) ? (int?)__jsonFraction : Fraction;
            _frameBufferSizeMib = If( json?.PropertyT<Carbon.Json.JsonNumber>("frame_buffer_size_mib"), out var __jsonFrameBufferSizeMib) ? (long?)__jsonFrameBufferSizeMib : FrameBufferSizeMib;
            _guestDriverVersion = If( json?.PropertyT<Carbon.Json.JsonString>("guest_driver_version"), out var __jsonGuestDriverVersion) ? (string)__jsonGuestDriverVersion : (string)GuestDriverVersion;
            _mode = If( json?.PropertyT<Carbon.Json.JsonString>("mode"), out var __jsonMode) ? (string)__jsonMode : (string)Mode;
            _numVirtualDisplayHeads = If( json?.PropertyT<Carbon.Json.JsonNumber>("num_virtual_display_heads"), out var __jsonNumVirtualDisplayHeads) ? (int?)__jsonNumVirtualDisplayHeads : NumVirtualDisplayHeads;
            _pciAddress = If( json?.PropertyT<Carbon.Json.JsonString>("pci_address"), out var __jsonPciAddress) ? (string)__jsonPciAddress : (string)PciAddress;
            _uuid = If( json?.PropertyT<Carbon.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;
            _vendor = If( json?.PropertyT<Carbon.Json.JsonString>("vendor"), out var __jsonVendor) ? (string)__jsonVendor : (string)Vendor;
            AfterFromJson(json);
        }
    }
}