namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// These rules are used for quarantining suspected VMs. Target group is a required attribute. Empty inbound_allow_list will
    /// not allow anything into target group. Empty outbound_allow_list will allow everything from target group.
    /// </summary>
    public partial class NetworkSecurityRuleResourcesQuarantineRule
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule.</returns>
        public static Sample.API.Models.INetworkSecurityRuleResourcesQuarantineRule FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new NetworkSecurityRuleResourcesQuarantineRule(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="NetworkSecurityRuleResourcesQuarantineRule" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal NetworkSecurityRuleResourcesQuarantineRule(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _action = If( json?.PropertyT<Carbon.Json.JsonString>("action"), out var __jsonAction) ? (string)__jsonAction : (string)Action;
            _inboundAllowList = If( json?.PropertyT<Carbon.Json.JsonArray>("inbound_allow_list"), out var __jsonInboundAllowList) ? If( __jsonInboundAllowList, out var __w) ? new System.Func<Sample.API.Models.INetworkRule[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Sample.API.Models.NetworkRule.FromJson(__v)  ) ) )() : null : InboundAllowList;
            _outboundAllowList = If( json?.PropertyT<Carbon.Json.JsonArray>("outbound_allow_list"), out var __jsonOutboundAllowList) ? If( __jsonOutboundAllowList, out var __r) ? new System.Func<Sample.API.Models.INetworkRule[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __r, (__q)=> Sample.API.Models.NetworkRule.FromJson(__q)  ) ) )() : null : OutboundAllowList;
            _targetGroup = If( json?.PropertyT<Carbon.Json.JsonObject>("target_group"), out var __jsonTargetGroup) ? Sample.API.Models.TargetGroup.FromJson(__jsonTargetGroup) : TargetGroup;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="NetworkSecurityRuleResourcesQuarantineRule" /> into a <see cref="Carbon.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NetworkSecurityRuleResourcesQuarantineRule" /> as a <see cref="Carbon.Json.JsonNode"
        /// />.
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
            AddIf( null != Action ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Action) : null, "action" ,container.Add );
            if (null != InboundAllowList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in InboundAllowList )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("inbound_allow_list",__x);
            }
            if (null != OutboundAllowList)
            {
                var __s = new Carbon.Json.XNodeArray();
                foreach( var __t in OutboundAllowList )
                {
                    AddIf(__t?.ToJson(null) ,__s.Add);
                }
                container.Add("outbound_allow_list",__s);
            }
            AddIf( null != TargetGroup ? (Carbon.Json.JsonNode) TargetGroup.ToJson(null) : null, "target_group" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}