namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster build details.</summary>
    public partial class BuildInfo
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="BuildInfo" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal BuildInfo(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _buildType = If( json?.PropertyT<Carbon.Json.JsonString>("build_type"), out var __jsonBuildType) ? (string)__jsonBuildType : (string)BuildType;
            _commitDate = If( json?.PropertyT<Carbon.Json.JsonString>("commit_date"), out var __jsonCommitDate) ? System.DateTime.TryParse((string)__jsonCommitDate, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCommitDateValue) ? __jsonCommitDateValue : CommitDate : CommitDate;
            _commitId = If( json?.PropertyT<Carbon.Json.JsonString>("commit_id"), out var __jsonCommitId) ? (string)__jsonCommitId : (string)CommitId;
            _fullVersion = If( json?.PropertyT<Carbon.Json.JsonString>("full_version"), out var __jsonFullVersion) ? (string)__jsonFullVersion : (string)FullVersion;
            _shortCommitId = If( json?.PropertyT<Carbon.Json.JsonString>("short_commit_id"), out var __jsonShortCommitId) ? (string)__jsonShortCommitId : (string)ShortCommitId;
            _version = If( json?.PropertyT<Carbon.Json.JsonString>("version"), out var __jsonVersion) ? (string)__jsonVersion : (string)Version;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IBuildInfo.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IBuildInfo.</returns>
        public static Nutanix.Powershell.Models.IBuildInfo FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new BuildInfo(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="BuildInfo" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BuildInfo" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != BuildType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(BuildType) : null, "build_type" ,container.Add );
            AddIf( null != CommitDate ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CommitDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "commit_date" ,container.Add );
            AddIf( null != CommitId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CommitId) : null, "commit_id" ,container.Add );
            AddIf( null != FullVersion ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(FullVersion) : null, "full_version" ,container.Add );
            AddIf( null != ShortCommitId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ShortCommitId) : null, "short_commit_id" ,container.Add );
            AddIf( null != Version ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Version) : null, "version" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}