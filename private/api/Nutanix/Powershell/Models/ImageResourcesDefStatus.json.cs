namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Describes the image status resources object.</summary>
    public partial class ImageResourcesDefStatus
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IImageResourcesDefStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IImageResourcesDefStatus.</returns>
        public static Nutanix.Powershell.Models.IImageResourcesDefStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ImageResourcesDefStatus(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="ImageResourcesDefStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal ImageResourcesDefStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _architecture = If( json?.PropertyT<Carbon.Json.JsonString>("architecture"), out var __jsonArchitecture) ? (string)__jsonArchitecture : (string)Architecture;
            _checksum = If( json?.PropertyT<Carbon.Json.JsonObject>("checksum"), out var __jsonChecksum) ? Nutanix.Powershell.Models.Checksum.FromJson(__jsonChecksum) : Checksum;
            _imageType = If( json?.PropertyT<Carbon.Json.JsonString>("image_type"), out var __jsonImageType) ? (string)__jsonImageType : (string)ImageType;
            _retrievalUriList = If( json?.PropertyT<Carbon.Json.JsonArray>("retrieval_uri_list"), out var __jsonRetrievalUriList) ? If( __jsonRetrievalUriList, out var __v) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> __u is Carbon.Json.JsonString __t ? (string)__t : null ) ) )() : null : RetrievalUriList;
            _sizeBytes = If( json?.PropertyT<Carbon.Json.JsonNumber>("size_bytes"), out var __jsonSizeBytes) ? (int?)__jsonSizeBytes : SizeBytes;
            _sourceUri = If( json?.PropertyT<Carbon.Json.JsonString>("source_uri"), out var __jsonSourceUri) ? (string)__jsonSourceUri : (string)SourceUri;
            _version = If( json?.PropertyT<Carbon.Json.JsonObject>("version"), out var __jsonVersion) ? Nutanix.Powershell.Models.ImageVersionStatus.FromJson(__jsonVersion) : Version;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="ImageResourcesDefStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ImageResourcesDefStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Architecture ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Architecture) : null, "architecture" ,container.Add );
            AddIf( null != Checksum ? (Carbon.Json.JsonNode) Checksum.ToJson(null) : null, "checksum" ,container.Add );
            AddIf( null != ImageType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ImageType) : null, "image_type" ,container.Add );
            if (null != RetrievalUriList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in RetrievalUriList )
                {
                    AddIf(null != __x ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__x) : null ,__w.Add);
                }
                container.Add("retrieval_uri_list",__w);
            }
            AddIf( null != SizeBytes ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)SizeBytes) : null, "size_bytes" ,container.Add );
            AddIf( null != SourceUri ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SourceUri) : null, "source_uri" ,container.Add );
            AddIf( null != Version ? (Carbon.Json.JsonNode) Version.ToJson(null) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}