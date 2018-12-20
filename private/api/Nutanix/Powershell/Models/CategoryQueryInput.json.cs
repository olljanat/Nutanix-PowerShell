namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Categories query input object.</summary>
    public partial class CategoryQueryInput
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="CategoryQueryInput" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal CategoryQueryInput(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _apiVersion = If( json?.PropertyT<Carbon.Json.JsonString>("api_version"), out var __jsonApiVersion) ? (string)__jsonApiVersion : (string)ApiVersion;
            _categoryFilter = If( json?.PropertyT<Carbon.Json.JsonObject>("category_filter"), out var __jsonCategoryFilter) ? Nutanix.Powershell.Models.CategoryFilter.FromJson(__jsonCategoryFilter) : CategoryFilter;
            _groupMemberCount = If( json?.PropertyT<Carbon.Json.JsonNumber>("group_member_count"), out var __jsonGroupMemberCount) ? (long?)__jsonGroupMemberCount : GroupMemberCount;
            _groupMemberOffset = If( json?.PropertyT<Carbon.Json.JsonNumber>("group_member_offset"), out var __jsonGroupMemberOffset) ? (long?)__jsonGroupMemberOffset : GroupMemberOffset;
            _usageType = If( json?.PropertyT<Carbon.Json.JsonString>("usage_type"), out var __jsonUsageType) ? (string)__jsonUsageType : (string)UsageType;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ICategoryQueryInput.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ICategoryQueryInput.</returns>
        public static Nutanix.Powershell.Models.ICategoryQueryInput FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CategoryQueryInput(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="CategoryQueryInput" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CategoryQueryInput" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != ApiVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ApiVersion) : null, "api_version" ,container.Add );
            AddIf( null != CategoryFilter ? (Carbon.Json.JsonNode) CategoryFilter.ToJson(null) : null, "category_filter" ,container.Add );
            AddIf( null != GroupMemberCount ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)GroupMemberCount) : null, "group_member_count" ,container.Add );
            AddIf( null != GroupMemberOffset ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)GroupMemberOffset) : null, "group_member_offset" ,container.Add );
            AddIf( null != UsageType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(UsageType) : null, "usage_type" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}