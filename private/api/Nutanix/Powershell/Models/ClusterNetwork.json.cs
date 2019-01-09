namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster network.</summary>
    public partial class ClusterNetwork
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ClusterNetwork" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ClusterNetwork(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _domainServer = If( json?.PropertyT<Carbon.Json.JsonObject>("domain_server"), out var __jsonDomainServer) ? Nutanix.Powershell.Models.ClusterDomainServer.FromJson(__jsonDomainServer) : DomainServer;
            _externalDataServicesIp = If( json?.PropertyT<Carbon.Json.JsonString>("external_data_services_ip"), out var __jsonExternalDataServicesIp) ? (string)__jsonExternalDataServicesIp : (string)ExternalDataServicesIp;
            _externalIp = If( json?.PropertyT<Carbon.Json.JsonString>("external_ip"), out var __jsonExternalIp) ? (string)__jsonExternalIp : (string)ExternalIp;
            _externalSubnet = If( json?.PropertyT<Carbon.Json.JsonString>("external_subnet"), out var __jsonExternalSubnet) ? (string)__jsonExternalSubnet : (string)ExternalSubnet;
            _httpProxyList = If( json?.PropertyT<Carbon.Json.JsonArray>("http_proxy_list"), out var __jsonHttpProxyList) ? If( __jsonHttpProxyList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IClusterNetworkEntity[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.ClusterNetworkEntity.FromJson(__u)  ) ) )() : null : HttpProxyList;
            _httpProxyWhitelist = If( json?.PropertyT<Carbon.Json.JsonArray>("http_proxy_whitelist"), out var __jsonHttpProxyWhitelist) ? If( __jsonHttpProxyWhitelist, out var __q) ? new System.Func<Nutanix.Powershell.Models.IHttpProxyWhitelist[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __q, (__p)=> Nutanix.Powershell.Models.HttpProxyWhitelist.FromJson(__p)  ) ) )() : null : HttpProxyWhitelist;
            _internalSubnet = If( json?.PropertyT<Carbon.Json.JsonString>("internal_subnet"), out var __jsonInternalSubnet) ? (string)__jsonInternalSubnet : (string)InternalSubnet;
            _masqueradingIp = If( json?.PropertyT<Carbon.Json.JsonString>("masquerading_ip"), out var __jsonMasqueradingIp) ? (string)__jsonMasqueradingIp : (string)MasqueradingIp;
            _masqueradingPort = If( json?.PropertyT<Carbon.Json.JsonNumber>("masquerading_port"), out var __jsonMasqueradingPort) ? (int?)__jsonMasqueradingPort : MasqueradingPort;
            _nameServerIpList = If( json?.PropertyT<Carbon.Json.JsonArray>("name_server_ip_list"), out var __jsonNameServerIpList) ? If( __jsonNameServerIpList, out var __l) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __l, (__k)=> __k is Carbon.Json.JsonString __j ? (string)__j : null ) ) )() : null : NameServerIpList;
            _nfsSubnetWhitelist = If( json?.PropertyT<Carbon.Json.JsonArray>("nfs_subnet_whitelist"), out var __jsonNfsSubnetWhitelist) ? If( __jsonNfsSubnetWhitelist, out var __g) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __g, (__f)=> __f is Carbon.Json.JsonString __e ? (string)__e : null ) ) )() : null : NfsSubnetWhitelist;
            _ntpServerIpList = If( json?.PropertyT<Carbon.Json.JsonArray>("ntp_server_ip_list"), out var __jsonNtpServerIpList) ? If( __jsonNtpServerIpList, out var __b) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __b, (__a)=> __a is Carbon.Json.JsonString ___z ? (string)___z : null ) ) )() : null : NtpServerIpList;
            _smtpServer = If( json?.PropertyT<Carbon.Json.JsonObject>("smtp_server"), out var __jsonSmtpServer) ? Nutanix.Powershell.Models.SmtpServer.FromJson(__jsonSmtpServer) : SmtpServer;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IClusterNetwork.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IClusterNetwork.</returns>
        public static Nutanix.Powershell.Models.IClusterNetwork FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ClusterNetwork(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ClusterNetwork" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterNetwork" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != DomainServer ? (Carbon.Json.JsonNode) DomainServer.ToJson(null) : null, "domain_server" ,container.Add );
            AddIf( null != ExternalDataServicesIp ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ExternalDataServicesIp) : null, "external_data_services_ip" ,container.Add );
            AddIf( null != ExternalIp ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ExternalIp) : null, "external_ip" ,container.Add );
            AddIf( null != ExternalSubnet ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ExternalSubnet) : null, "external_subnet" ,container.Add );
            if (null != HttpProxyList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in HttpProxyList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("http_proxy_list",__w);
            }
            if (null != HttpProxyWhitelist)
            {
                var __r = new Carbon.Json.XNodeArray();
                foreach( var __s in HttpProxyWhitelist )
                {
                    AddIf(__s?.ToJson(null) ,__r.Add);
                }
                container.Add("http_proxy_whitelist",__r);
            }
            AddIf( null != InternalSubnet ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(InternalSubnet) : null, "internal_subnet" ,container.Add );
            AddIf( null != MasqueradingIp ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(MasqueradingIp) : null, "masquerading_ip" ,container.Add );
            AddIf( null != MasqueradingPort ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)MasqueradingPort) : null, "masquerading_port" ,container.Add );
            if (null != NameServerIpList)
            {
                var __m = new Carbon.Json.XNodeArray();
                foreach( var __n in NameServerIpList )
                {
                    AddIf(null != __n ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__n) : null ,__m.Add);
                }
                container.Add("name_server_ip_list",__m);
            }
            if (null != NfsSubnetWhitelist)
            {
                var __h = new Carbon.Json.XNodeArray();
                foreach( var __i in NfsSubnetWhitelist )
                {
                    AddIf(null != __i ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__i) : null ,__h.Add);
                }
                container.Add("nfs_subnet_whitelist",__h);
            }
            if (null != NtpServerIpList)
            {
                var __c = new Carbon.Json.XNodeArray();
                foreach( var __d in NtpServerIpList )
                {
                    AddIf(null != __d ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__d) : null ,__c.Add);
                }
                container.Add("ntp_server_ip_list",__c);
            }
            AddIf( null != SmtpServer ? (Carbon.Json.JsonNode) SmtpServer.ToJson(null) : null, "smtp_server" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}