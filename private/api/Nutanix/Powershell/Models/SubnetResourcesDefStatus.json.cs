namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Subnet creation/modification status.</summary>
    public partial class SubnetResourcesDefStatus
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ISubnetResourcesDefStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ISubnetResourcesDefStatus.</returns>
        public static Nutanix.Powershell.Models.ISubnetResourcesDefStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new SubnetResourcesDefStatus(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="SubnetResourcesDefStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal SubnetResourcesDefStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _ipConfig = If( json?.PropertyT<Carbon.Json.JsonObject>("ip_config"), out var __jsonIpConfig) ? Nutanix.Powershell.Models.IpConfig.FromJson(__jsonIpConfig) : IpConfig;
            _networkFunctionChainReference = If( json?.PropertyT<Carbon.Json.JsonObject>("network_function_chain_reference"), out var __jsonNetworkFunctionChainReference) ? Nutanix.Powershell.Models.NetworkFunctionChainReference.FromJson(__jsonNetworkFunctionChainReference) : NetworkFunctionChainReference;
            _subnetType = If( json?.PropertyT<Carbon.Json.JsonString>("subnet_type"), out var __jsonSubnetType) ? (string)__jsonSubnetType : (string)SubnetType;
            _vlanId = If( json?.PropertyT<Carbon.Json.JsonNumber>("vlan_id"), out var __jsonVlanId) ? (int?)__jsonVlanId : VlanId;
            _vswitchName = If( json?.PropertyT<Carbon.Json.JsonString>("vswitch_name"), out var __jsonVswitchName) ? (string)__jsonVswitchName : (string)VswitchName;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="SubnetResourcesDefStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SubnetResourcesDefStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != IpConfig ? (Carbon.Json.JsonNode) IpConfig.ToJson(null) : null, "ip_config" ,container.Add );
            AddIf( null != NetworkFunctionChainReference ? (Carbon.Json.JsonNode) NetworkFunctionChainReference.ToJson(null) : null, "network_function_chain_reference" ,container.Add );
            AddIf( null != SubnetType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SubnetType) : null, "subnet_type" ,container.Add );
            AddIf( null != VlanId ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)VlanId) : null, "vlan_id" ,container.Add );
            AddIf( null != VswitchName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(VswitchName) : null, "vswitch_name" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}