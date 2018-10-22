namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Recovery point resources</summary>
    public partial class VmRecoveryPointResources
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IVmRecoveryPointResources.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IVmRecoveryPointResources.</returns>
        public static Sample.API.Models.IVmRecoveryPointResources FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmRecoveryPointResources(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmRecoveryPointResources" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmRecoveryPointResources" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != ParentVmReference ? (Carbon.Json.JsonNode) ParentVmReference.ToJson(null) : null, "parent_vm_reference" ,container.Add );
            AddIf( null != SourceAvailabilityZoneReference ? (Carbon.Json.JsonNode) SourceAvailabilityZoneReference.ToJson(null) : null, "source_availability_zone_reference" ,container.Add );
            AddIf( null != SourceClusterReference ? (Carbon.Json.JsonNode) SourceClusterReference.ToJson(null) : null, "source_cluster_reference" ,container.Add );
            AddIf( null != VmRecoveryPointLocationAgnosticUuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(VmRecoveryPointLocationAgnosticUuid) : null, "vm_recovery_point_location_agnostic_uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmRecoveryPointResources" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmRecoveryPointResources(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _parentVmReference = If( json?.PropertyT<Carbon.Json.JsonObject>("parent_vm_reference"), out var __jsonParentVmReference) ? Sample.API.Models.VmReference.FromJson(__jsonParentVmReference) : ParentVmReference;
            _sourceAvailabilityZoneReference = If( json?.PropertyT<Carbon.Json.JsonObject>("source_availability_zone_reference"), out var __jsonSourceAvailabilityZoneReference) ? Sample.API.Models.AvailabilityZoneReference.FromJson(__jsonSourceAvailabilityZoneReference) : SourceAvailabilityZoneReference;
            _sourceClusterReference = If( json?.PropertyT<Carbon.Json.JsonObject>("source_cluster_reference"), out var __jsonSourceClusterReference) ? Sample.API.Models.ClusterReference.FromJson(__jsonSourceClusterReference) : SourceClusterReference;
            _vmRecoveryPointLocationAgnosticUuid = If( json?.PropertyT<Carbon.Json.JsonString>("vm_recovery_point_location_agnostic_uuid"), out var __jsonVmRecoveryPointLocationAgnosticUuid) ? (string)__jsonVmRecoveryPointLocationAgnosticUuid : (string)VmRecoveryPointLocationAgnosticUuid;
            AfterFromJson(json);
        }
    }
}