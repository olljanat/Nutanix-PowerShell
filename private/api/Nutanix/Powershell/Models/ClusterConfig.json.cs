namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster Configuration.</summary>
    public partial class ClusterConfig
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ClusterConfig" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ClusterConfig(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _authorizedPublicKeyList = If( json?.PropertyT<Carbon.Json.JsonArray>("authorized_public_key_list"), out var __jsonAuthorizedPublicKeyList) ? If( __jsonAuthorizedPublicKeyList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IPublicKey[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.PublicKey.FromJson(__u)  ) ) )() : null : AuthorizedPublicKeyList;
            _build = If( json?.PropertyT<Carbon.Json.JsonObject>("build"), out var __jsonBuild) ? Nutanix.Powershell.Models.BuildInfo.FromJson(__jsonBuild) : Build;
            _caCertificateList = If( json?.PropertyT<Carbon.Json.JsonArray>("ca_certificate_list"), out var __jsonCaCertificateList) ? If( __jsonCaCertificateList, out var __q) ? new System.Func<Nutanix.Powershell.Models.ICaCert[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __q, (__p)=> Nutanix.Powershell.Models.CaCert.FromJson(__p)  ) ) )() : null : CaCertificateList;
            _certificationSigningInfo = If( json?.PropertyT<Carbon.Json.JsonObject>("certification_signing_info"), out var __jsonCertificationSigningInfo) ? Nutanix.Powershell.Models.CertificationSigningInfo.FromJson(__jsonCertificationSigningInfo) : CertificationSigningInfo;
            _clientAuth = If( json?.PropertyT<Carbon.Json.JsonObject>("client_auth"), out var __jsonClientAuth) ? Nutanix.Powershell.Models.ClientAuth.FromJson(__jsonClientAuth) : ClientAuth;
            _clusterArch = If( json?.PropertyT<Carbon.Json.JsonString>("cluster_arch"), out var __jsonClusterArch) ? (string)__jsonClusterArch : (string)ClusterArch;
            _enabledFeatureList = If( json?.PropertyT<Carbon.Json.JsonArray>("enabled_feature_list"), out var __jsonEnabledFeatureList) ? If( __jsonEnabledFeatureList, out var __l) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __l, (__k)=> __k is Carbon.Json.JsonString __j ? (string)__j : null ) ) )() : null : EnabledFeatureList;
            _encryptionStatus = If( json?.PropertyT<Carbon.Json.JsonString>("encryption_status"), out var __jsonEncryptionStatus) ? (string)__jsonEncryptionStatus : (string)EncryptionStatus;
            _externalConfigurations = If( json?.PropertyT<Carbon.Json.JsonObject>("external_configurations"), out var __jsonExternalConfigurations) ? Nutanix.Powershell.Models.ExternalConfigurations.FromJson(__jsonExternalConfigurations) : ExternalConfigurations;
            _gpuDriverVersion = If( json?.PropertyT<Carbon.Json.JsonString>("gpu_driver_version"), out var __jsonGpuDriverVersion) ? (string)__jsonGpuDriverVersion : (string)GpuDriverVersion;
            _isAvailable = If( json?.PropertyT<Carbon.Json.JsonBoolean>("is_available"), out var __jsonIsAvailable) ? (bool?)__jsonIsAvailable : IsAvailable;
            _managementServerList = If( json?.PropertyT<Carbon.Json.JsonArray>("management_server_list"), out var __jsonManagementServerList) ? If( __jsonManagementServerList, out var __g) ? new System.Func<Nutanix.Powershell.Models.IClusterManagementServer[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __g, (__f)=> Nutanix.Powershell.Models.ClusterManagementServer.FromJson(__f)  ) ) )() : null : ManagementServerList;
            _operationMode = If( json?.PropertyT<Carbon.Json.JsonString>("operation_mode"), out var __jsonOperationMode) ? (string)__jsonOperationMode : (string)OperationMode;
            _redundancyFactor = If( json?.PropertyT<Carbon.Json.JsonNumber>("redundancy_factor"), out var __jsonRedundancyFactor) ? (int?)__jsonRedundancyFactor : RedundancyFactor;
            _serviceList = If( json?.PropertyT<Carbon.Json.JsonArray>("service_list"), out var __jsonServiceList) ? If( __jsonServiceList, out var __b) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __b, (__a)=> __a is Carbon.Json.JsonString ___z ? (string)___z : null ) ) )() : null : ServiceList;
            _softwareMap = System.Linq.Enumerable.ToDictionary( json?.Keys ?? System.Linq.Enumerable.Empty<string>(), each => each, each => Nutanix.Powershell.Models.ClusterSoftware.FromJson(json.PropertyT<Carbon.Json.JsonNode>(each))  );
            _sslKey = If( json?.PropertyT<Carbon.Json.JsonObject>("ssl_key"), out var __jsonSslKey) ? Nutanix.Powershell.Models.SslKey.FromJson(__jsonSslKey) : SslKey;
            _supportedInformationVerbosity = If( json?.PropertyT<Carbon.Json.JsonString>("supported_information_verbosity"), out var __jsonSupportedInformationVerbosity) ? (string)__jsonSupportedInformationVerbosity : (string)SupportedInformationVerbosity;
            _timezone = If( json?.PropertyT<Carbon.Json.JsonString>("timezone"), out var __jsonTimezone) ? (string)__jsonTimezone : (string)Timezone;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IClusterConfig.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IClusterConfig.</returns>
        public static Nutanix.Powershell.Models.IClusterConfig FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ClusterConfig(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ClusterConfig" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ClusterConfig" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            if (null != AuthorizedPublicKeyList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in AuthorizedPublicKeyList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("authorized_public_key_list",__w);
            }
            AddIf( null != Build ? (Carbon.Json.JsonNode) Build.ToJson(null) : null, "build" ,container.Add );
            if (null != CaCertificateList)
            {
                var __r = new Carbon.Json.XNodeArray();
                foreach( var __s in CaCertificateList )
                {
                    AddIf(__s?.ToJson(null) ,__r.Add);
                }
                container.Add("ca_certificate_list",__r);
            }
            AddIf( null != CertificationSigningInfo ? (Carbon.Json.JsonNode) CertificationSigningInfo.ToJson(null) : null, "certification_signing_info" ,container.Add );
            AddIf( null != ClientAuth ? (Carbon.Json.JsonNode) ClientAuth.ToJson(null) : null, "client_auth" ,container.Add );
            AddIf( null != ClusterArch ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ClusterArch) : null, "cluster_arch" ,container.Add );
            if (null != EnabledFeatureList)
            {
                var __m = new Carbon.Json.XNodeArray();
                foreach( var __n in EnabledFeatureList )
                {
                    AddIf(null != __n ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__n) : null ,__m.Add);
                }
                container.Add("enabled_feature_list",__m);
            }
            AddIf( null != EncryptionStatus ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(EncryptionStatus) : null, "encryption_status" ,container.Add );
            AddIf( null != ExternalConfigurations ? (Carbon.Json.JsonNode) ExternalConfigurations.ToJson(null) : null, "external_configurations" ,container.Add );
            AddIf( null != GpuDriverVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(GpuDriverVersion) : null, "gpu_driver_version" ,container.Add );
            AddIf( null != IsAvailable ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)IsAvailable) : null, "is_available" ,container.Add );
            if (null != ManagementServerList)
            {
                var __h = new Carbon.Json.XNodeArray();
                foreach( var __i in ManagementServerList )
                {
                    AddIf(__i?.ToJson(null) ,__h.Add);
                }
                container.Add("management_server_list",__h);
            }
            AddIf( null != OperationMode ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(OperationMode) : null, "operation_mode" ,container.Add );
            AddIf( null != RedundancyFactor ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)RedundancyFactor) : null, "redundancy_factor" ,container.Add );
            if (null != ServiceList)
            {
                var __c = new Carbon.Json.XNodeArray();
                foreach( var __d in ServiceList )
                {
                    AddIf(null != __d ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__d) : null ,__c.Add);
                }
                container.Add("service_list",__c);
            }
            if (null != SoftwareMap)
            {
                foreach( var ___y in SoftwareMap )
                {
                    AddIf( ___y.Value?.ToJson(null),(___x) => container.Add(___y.Key,___x ) );
                }
            }
            AddIf( null != SslKey ? (Carbon.Json.JsonNode) SslKey.ToJson(null) : null, "ssl_key" ,container.Add );
            AddIf( null != SupportedInformationVerbosity ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SupportedInformationVerbosity) : null, "supported_information_verbosity" ,container.Add );
            AddIf( null != Timezone ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Timezone) : null, "timezone" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}