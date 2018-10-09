namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>VirtualMachine Disk (VM Disk).</summary>
    public partial class VmDisk
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IVmDisk.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IVmDisk.</returns>
        public static Sample.API.Models.IVmDisk FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmDisk(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmDisk" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmDisk" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != DataSourceReference ? (Carbon.Json.JsonNode) DataSourceReference.ToJson(null) : null, "data_source_reference" ,container.Add );
            AddIf( null != DeviceProperties ? (Carbon.Json.JsonNode) DeviceProperties.ToJson(null) : null, "device_properties" ,container.Add );
            AddIf( null != DiskSizeBytes ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)DiskSizeBytes) : null, "disk_size_bytes" ,container.Add );
            AddIf( null != DiskSizeMib ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)DiskSizeMib) : null, "disk_size_mib" ,container.Add );
            AddIf( null != Uuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Uuid) : null, "uuid" ,container.Add );
            AddIf( null != VolumeGroupReference ? (Carbon.Json.JsonNode) VolumeGroupReference.ToJson(null) : null, "volume_group_reference" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmDisk" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmDisk(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _dataSourceReference = If( json?.PropertyT<Carbon.Json.JsonObject>("data_source_reference"), out var __jsonDataSourceReference) ? Sample.API.Models.Reference.FromJson(__jsonDataSourceReference) : DataSourceReference;
            _deviceProperties = If( json?.PropertyT<Carbon.Json.JsonObject>("device_properties"), out var __jsonDeviceProperties) ? Sample.API.Models.VmDiskDeviceProperties.FromJson(__jsonDeviceProperties) : DeviceProperties;
            _diskSizeBytes = If( json?.PropertyT<Carbon.Json.JsonNumber>("disk_size_bytes"), out var __jsonDiskSizeBytes) ? (long?)__jsonDiskSizeBytes : DiskSizeBytes;
            _diskSizeMib = If( json?.PropertyT<Carbon.Json.JsonNumber>("disk_size_mib"), out var __jsonDiskSizeMib) ? (int?)__jsonDiskSizeMib : DiskSizeMib;
            _uuid = If( json?.PropertyT<Carbon.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;
            _volumeGroupReference = If( json?.PropertyT<Carbon.Json.JsonObject>("volume_group_reference"), out var __jsonVolumeGroupReference) ? Sample.API.Models.Reference.FromJson(__jsonVolumeGroupReference) : VolumeGroupReference;
            AfterFromJson(json);
        }
    }
}