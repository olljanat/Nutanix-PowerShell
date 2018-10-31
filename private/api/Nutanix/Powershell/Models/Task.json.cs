namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Task details</summary>
    public partial class Task
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ITask.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ITask.</returns>
        public static Nutanix.Powershell.Models.ITask FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Task(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="Task" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal Task(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _apiVersion = If( json?.PropertyT<Carbon.Json.JsonString>("api_version"), out var __jsonApiVersion) ? (string)__jsonApiVersion : (string)ApiVersion;
            _clusterReference = If( json?.PropertyT<Carbon.Json.JsonObject>("cluster_reference"), out var __jsonClusterReference) ? Nutanix.Powershell.Models.ClusterReference.FromJson(__jsonClusterReference) : ClusterReference;
            _completionTime = If( json?.PropertyT<Carbon.Json.JsonString>("completion_time"), out var __jsonCompletionTime) ? System.DateTime.TryParse((string)__jsonCompletionTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCompletionTimeValue) ? __jsonCompletionTimeValue : CompletionTime : CompletionTime;
            _creationTime = If( json?.PropertyT<Carbon.Json.JsonString>("creation_time"), out var __jsonCreationTime) ? System.DateTime.TryParse((string)__jsonCreationTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonCreationTimeValue) ? __jsonCreationTimeValue : CreationTime : CreationTime;
            _entityReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("entity_reference_list"), out var __jsonEntityReferenceList) ? If( __jsonEntityReferenceList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.Reference.FromJson(__u)  ) ) )() : null : EntityReferenceList;
            _errorCode = If( json?.PropertyT<Carbon.Json.JsonString>("error_code"), out var __jsonErrorCode) ? (string)__jsonErrorCode : (string)ErrorCode;
            _errorDetail = If( json?.PropertyT<Carbon.Json.JsonString>("error_detail"), out var __jsonErrorDetail) ? (string)__jsonErrorDetail : (string)ErrorDetail;
            _lastUpdateTime = If( json?.PropertyT<Carbon.Json.JsonString>("last_update_time"), out var __jsonLastUpdateTime) ? System.DateTime.TryParse((string)__jsonLastUpdateTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastUpdateTimeValue) ? __jsonLastUpdateTimeValue : LastUpdateTime : LastUpdateTime;
            _logicalTimestamp = If( json?.PropertyT<Carbon.Json.JsonNumber>("logical_timestamp"), out var __jsonLogicalTimestamp) ? (long?)__jsonLogicalTimestamp : LogicalTimestamp;
            _operationType = If( json?.PropertyT<Carbon.Json.JsonString>("operation_type"), out var __jsonOperationType) ? (string)__jsonOperationType : (string)OperationType;
            _parentTaskReference = If( json?.PropertyT<Carbon.Json.JsonObject>("parent_task_reference"), out var __jsonParentTaskReference) ? Nutanix.Powershell.Models.TaskReference.FromJson(__jsonParentTaskReference) : ParentTaskReference;
            _percentageComplete = If( json?.PropertyT<Carbon.Json.JsonNumber>("percentage_complete"), out var __jsonPercentageComplete) ? (int?)__jsonPercentageComplete : PercentageComplete;
            _progressMessage = If( json?.PropertyT<Carbon.Json.JsonString>("progress_message"), out var __jsonProgressMessage) ? (string)__jsonProgressMessage : (string)ProgressMessage;
            _startTime = If( json?.PropertyT<Carbon.Json.JsonString>("start_time"), out var __jsonStartTime) ? System.DateTime.TryParse((string)__jsonStartTime, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonStartTimeValue) ? __jsonStartTimeValue : StartTime : StartTime;
            _status = If( json?.PropertyT<Carbon.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)Status;
            _subtaskReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("subtask_reference_list"), out var __jsonSubtaskReferenceList) ? If( __jsonSubtaskReferenceList, out var __q) ? new System.Func<Nutanix.Powershell.Models.ITaskReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __q, (__p)=> Nutanix.Powershell.Models.TaskReference.FromJson(__p)  ) ) )() : null : SubtaskReferenceList;
            _uuid = If( json?.PropertyT<Carbon.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)Uuid;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="Task" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Task" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != ClusterReference ? (Carbon.Json.JsonNode) ClusterReference.ToJson(null) : null, "cluster_reference" ,container.Add );
            AddIf( null != CompletionTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CompletionTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "completion_time" ,container.Add );
            AddIf( null != CreationTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CreationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "creation_time" ,container.Add );
            if (null != EntityReferenceList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in EntityReferenceList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("entity_reference_list",__w);
            }
            AddIf( null != ErrorCode ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ErrorCode) : null, "error_code" ,container.Add );
            AddIf( null != ErrorDetail ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ErrorDetail) : null, "error_detail" ,container.Add );
            AddIf( null != LastUpdateTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(LastUpdateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "last_update_time" ,container.Add );
            AddIf( null != LogicalTimestamp ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)LogicalTimestamp) : null, "logical_timestamp" ,container.Add );
            AddIf( null != OperationType ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(OperationType) : null, "operation_type" ,container.Add );
            AddIf( null != ParentTaskReference ? (Carbon.Json.JsonNode) ParentTaskReference.ToJson(null) : null, "parent_task_reference" ,container.Add );
            AddIf( null != PercentageComplete ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)PercentageComplete) : null, "percentage_complete" ,container.Add );
            AddIf( null != ProgressMessage ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(ProgressMessage) : null, "progress_message" ,container.Add );
            AddIf( null != StartTime ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(StartTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",System.Globalization.CultureInfo.InvariantCulture)) : null, "start_time" ,container.Add );
            AddIf( null != Status ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Status) : null, "status" ,container.Add );
            if (null != SubtaskReferenceList)
            {
                var __r = new Carbon.Json.XNodeArray();
                foreach( var __s in SubtaskReferenceList )
                {
                    AddIf(__s?.ToJson(null) ,__r.Add);
                }
                container.Add("subtask_reference_list",__r);
            }
            AddIf( null != Uuid ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Uuid) : null, "uuid" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}