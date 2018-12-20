namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>A category filter.</summary>
    public partial class CategoryFilter
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="CategoryFilter" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal CategoryFilter(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _type = If( json?.PropertyT<Carbon.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;
            _kindList = If( json?.PropertyT<Carbon.Json.JsonArray>("kind_list"), out var __jsonKindList) ? If( __jsonKindList, out var __v) ? new System.Func<string[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> __u is Carbon.Json.JsonString __t ? (string)__t : null ) ) )() : null : KindList;
            _params = System.Linq.Enumerable.ToDictionary( json?.Keys ?? System.Linq.Enumerable.Empty<string>(), each => each, each => json.PropertyT<Carbon.Json.JsonNode>(each) is Carbon.Json.JsonString __q ? (string)__q : null );
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ICategoryFilter.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ICategoryFilter.</returns>
        public static Nutanix.Powershell.Models.ICategoryFilter FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CategoryFilter(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="CategoryFilter" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime."/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CategoryFilter" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Type ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Type) : null, "type" ,container.Add );
            if (null != KindList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in KindList )
                {
                    AddIf(null != __x ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__x) : null ,__w.Add);
                }
                container.Add("kind_list",__w);
            }
            if (null != Params)
            {
                foreach( var __s in Params )
                {
                    AddIf( null != __s.Value ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(__s.Value) : null,(__r) => container.Add(__s.Key,__r ) );
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}