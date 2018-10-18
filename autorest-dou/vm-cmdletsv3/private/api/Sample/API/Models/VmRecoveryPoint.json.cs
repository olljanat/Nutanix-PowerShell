namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The input object that defines a vm recovery point.</summary>
    public partial class VmRecoveryPoint
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IVmRecoveryPoint.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IVmRecoveryPoint.</returns>
        public static Sample.API.Models.IVmRecoveryPoint FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmRecoveryPoint(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmRecoveryPoint" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmRecoveryPoint" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != AvailabilityZoneReference ? (Carbon.Json.JsonNode) AvailabilityZoneReference.ToJson(null) : null, "availability_zone_reference" ,container.Add );
            AddIf( null != ClusterReference ? (Carbon.Json.JsonNode) ClusterReference.ToJson(null) : null, "cluster_reference" ,container.Add );
            AddIf( null != CreationTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CreationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "creation_time" ,container.Add );
            AddIf( null != ExpirationTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ExpirationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "expiration_time" ,container.Add );
            AddIf( null != RecoveryPointType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(RecoveryPointType) : null, "recovery_point_type" ,container.Add );
            AddIf( null != Resources ? (Carbon.Json.JsonNode) Resources.ToJson(null) : null, "resources" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmRecoveryPoint" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmRecoveryPoint(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Carbon.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _availabilityZoneReference = If( json?.PropertyT<Carbon.Json.JsonObject>("availability_zone_reference"), out var __jsonAvailabilityZoneReference) ? Sample.API.Models.AvailabilityZoneReference.FromJson(__jsonAvailabilityZoneReference) : AvailabilityZoneReference;
            _clusterReference = If( json?.PropertyT<Carbon.Json.JsonObject>("cluster_reference"), out var __jsonClusterReference) ? Sample.API.Models.ClusterReference.FromJson(__jsonClusterReference) : ClusterReference;
            _creationTime = If( json?.PropertyT<Carbon.Json.JsonString>("creation_time"), out var __jsonCreationTime) ? System.DateTime.TryParse((string)__jsonCreationTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreationTimeValue) ? __jsonCreationTimeValue : CreationTime : CreationTime;
            _expirationTime = If( json?.PropertyT<Carbon.Json.JsonString>("expiration_time"), out var __jsonExpirationTime) ? System.DateTime.TryParse((string)__jsonExpirationTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonExpirationTimeValue) ? __jsonExpirationTimeValue : ExpirationTime : ExpirationTime;
            _recoveryPointType = If( json?.PropertyT<Carbon.Json.JsonString>("recovery_point_type"), out var __jsonRecoveryPointType) ? (string)__jsonRecoveryPointType : (string)RecoveryPointType;
            _resources = If( json?.PropertyT<Carbon.Json.JsonObject>("resources"), out var __jsonResources) ? Sample.API.Models.VmRecoveryPointResources.FromJson(__jsonResources) : Resources;
            AfterFromJson(json);
        }
    }
}