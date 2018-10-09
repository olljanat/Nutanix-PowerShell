namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Virtual Machine NIC.</summary>
    public partial class VmNic
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.IVmNic.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.IVmNic.</returns>
        public static Sample.API.Models.IVmNic FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmNic(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmNic" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmNic" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != IpEndpointList ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(IpEndpointList) : null, "ip_endpoint_list" ,container.Add );
            AddIf( null != MacAddress ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(MacAddress) : null, "mac_address" ,container.Add );
            AddIf( null != Model ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Model) : null, "model" ,container.Add );
            AddIf( null != NetworkFunctionChainReference ? (Carbon.Json.JsonNode) NetworkFunctionChainReference.ToJson(null) : null, "network_function_chain_reference" ,container.Add );
            AddIf( null != NetworkFunctionNicType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(NetworkFunctionNicType) : null, "network_function_nic_type" ,container.Add );
            AddIf( null != NicType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(NicType) : null, "nic_type" ,container.Add );
            AddIf( null != SubnetReference ? (Carbon.Json.JsonNode) SubnetReference.ToJson(null) : null, "subnet_reference" ,container.Add );
            AddIf( null != Uuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Uuid) : null, "uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmNic" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmNic(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _ipEndpointList = If( json?.PropertyT<Carbon.Json.JsonString>("ip_endpoint_list"), out var __jsonIpEndpointList) ? (string)__jsonIpEndpointList : (string)IpEndpointList;
            _macAddress = If( json?.PropertyT<Carbon.Json.JsonString>("mac_address"), out var __jsonMacAddress) ? (string)__jsonMacAddress : (string)MacAddress;
            _model = If( json?.PropertyT<Carbon.Json.JsonString>("model"), out var __jsonModel) ? (string)__jsonModel : (string)Model;
            _networkFunctionChainReference = If( json?.PropertyT<Carbon.Json.JsonObject>("network_function_chain_reference"), out var __jsonNetworkFunctionChainReference) ? Sample.API.Models.NetworkFunctionChainReference.FromJson(__jsonNetworkFunctionChainReference) : NetworkFunctionChainReference;
            _networkFunctionNicType = If( json?.PropertyT<Carbon.Json.JsonString>("network_function_nic_type"), out var __jsonNetworkFunctionNicType) ? (string)__jsonNetworkFunctionNicType : (string)NetworkFunctionNicType;
            _nicType = If( json?.PropertyT<Carbon.Json.JsonString>("nic_type"), out var __jsonNicType) ? (string)__jsonNicType : (string)NicType;
            _subnetReference = If( json?.PropertyT<Carbon.Json.JsonObject>("subnet_reference"), out var __jsonSubnetReference) ? Sample.API.Models.SubnetReference.FromJson(__jsonSubnetReference) : SubnetReference;
            _uuid = If( json?.PropertyT<Carbon.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;
            AfterFromJson(json);
        }
    }
}