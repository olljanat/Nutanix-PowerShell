namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Citrix Connector details.</summary>
    public partial class CitrixConnectorConfigDetailsSpec
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="CitrixConnectorConfigDetailsSpec" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal CitrixConnectorConfigDetailsSpec(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _citrixVmReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("citrix_vm_reference_list"), out var __jsonCitrixVmReferenceList) ? If( __jsonCitrixVmReferenceList, out var __w) ? new System.Func<Sample.API.Models.IVmReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Sample.API.Models.VmReference.FromJson(__v)  ) ) )() : null : CitrixVmReferenceList;
            _clientId = If( json?.PropertyT<Carbon.Json.JsonString>("client_id"), out var __jsonClientId) ? (string)__jsonClientId : (string)ClientId;
            _clientSecret = If( json?.PropertyT<Carbon.Json.JsonString>("client_secret"), out var __jsonClientSecret) ? (string)__jsonClientSecret : (string)ClientSecret;
            _customerId = If( json?.PropertyT<Carbon.Json.JsonString>("customer_id"), out var __jsonCustomerId) ? (string)__jsonCustomerId : (string)CustomerId;
            _resourceLocation = If( json?.PropertyT<Carbon.Json.JsonObject>("resource_location"), out var __jsonResourceLocation) ? Sample.API.Models.CitrixResourceLocationSpec.FromJson(__jsonResourceLocation) : ResourceLocation;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.ICitrixConnectorConfigDetailsSpec.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.ICitrixConnectorConfigDetailsSpec.</returns>
        public static Sample.API.Models.ICitrixConnectorConfigDetailsSpec FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CitrixConnectorConfigDetailsSpec(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="CitrixConnectorConfigDetailsSpec" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CitrixConnectorConfigDetailsSpec" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            if (null != CitrixVmReferenceList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in CitrixVmReferenceList )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("citrix_vm_reference_list",__x);
            }
            AddIf( null != ClientId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ClientId) : null, "client_id" ,container.Add );
            AddIf( null != ClientSecret ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ClientSecret) : null, "client_secret" ,container.Add );
            AddIf( null != CustomerId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CustomerId) : null, "customer_id" ,container.Add );
            AddIf( null != ResourceLocation ? (Carbon.Json.JsonNode) ResourceLocation.ToJson(null) : null, "resource_location" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}