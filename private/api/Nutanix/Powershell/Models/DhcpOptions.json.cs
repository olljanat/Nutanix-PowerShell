namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Spec for defining DHCP options.</summary>
    public partial class DhcpOptions
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="DhcpOptions" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal DhcpOptions(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _bootFileName = If( json?.PropertyT<Carbon.Json.JsonString>("boot_file_name"), out var __jsonBootFileName) ? (string)__jsonBootFileName : (string)BootFileName;
            _domainName = If( json?.PropertyT<Carbon.Json.JsonString>("domain_name"), out var __jsonDomainName) ? (string)__jsonDomainName : (string)DomainName;
            _domainNameServerList = If( json?.PropertyT<Carbon.Json.JsonArray>("domain_name_server_list"), out var __jsonDomainNameServerList) ? If( __jsonDomainNameServerList, out var __v) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> __u is Carbon.Json.JsonString __t ? (string)__t : null ) ) )() : null : DomainNameServerList;
            _domainSearchList = If( json?.PropertyT<Carbon.Json.JsonArray>("domain_search_list"), out var __jsonDomainSearchList) ? If( __jsonDomainSearchList, out var __q) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __q, (__p)=> __p is Carbon.Json.JsonString __o ? (string)__o : null ) ) )() : null : DomainSearchList;
            _tftpServerName = If( json?.PropertyT<Carbon.Json.JsonString>("tftp_server_name"), out var __jsonTftpServerName) ? (string)__jsonTftpServerName : (string)TftpServerName;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IDhcpOptions.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IDhcpOptions.</returns>
        public static Nutanix.Powershell.Models.IDhcpOptions FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new DhcpOptions(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="DhcpOptions" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DhcpOptions" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != BootFileName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(BootFileName) : null, "boot_file_name" ,container.Add );
            AddIf( null != DomainName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(DomainName) : null, "domain_name" ,container.Add );
            if (null != DomainNameServerList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in DomainNameServerList )
                {
                    AddIf(null != __x ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__x) : null ,__w.Add);
                }
                container.Add("domain_name_server_list",__w);
            }
            if (null != DomainSearchList)
            {
                var __r = new Carbon.Json.XNodeArray();
                foreach( var __s in DomainSearchList )
                {
                    AddIf(null != __s ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__s) : null ,__r.Add);
                }
                container.Add("domain_search_list",__r);
            }
            AddIf( null != TftpServerName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(TftpServerName) : null, "tftp_server_name" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}