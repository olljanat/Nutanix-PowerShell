namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Task details</summary>
    public partial class Task : Nutanix.Powershell.Models.ITask, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>API version</summary>
        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="ClusterReference" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterReference _clusterReference;

        /// <summary>Reference to the cluster the task is being executed on</summary>
        public Nutanix.Powershell.Models.IClusterReference ClusterReference
        {
            get
            {
                return this._clusterReference;
            }
            set
            {
                this._clusterReference = value;
            }
        }
        /// <summary>Backing field for <see cref="CompletionTime" /> property.</summary>
        private System.DateTime? _completionTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when Task execution completed
        /// </summary>
        public System.DateTime? CompletionTime
        {
            get
            {
                return this._completionTime;
            }
            set
            {
                this._completionTime = value;
            }
        }
        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private System.DateTime? _creationTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when task was created
        /// </summary>
        public System.DateTime? CreationTime
        {
            get
            {
                return this._creationTime;
            }
            set
            {
                this._creationTime = value;
            }
        }
        /// <summary>Backing field for <see cref="EntityReferenceList" /> property.</summary>
        private Nutanix.Powershell.Models.IReference[] _entityReferenceList;

        public Nutanix.Powershell.Models.IReference[] EntityReferenceList
        {
            get
            {
                return this._entityReferenceList;
            }
            set
            {
                this._entityReferenceList = value;
            }
        }
        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>
        /// In case of task failure this field will provide the error code
        /// </summary>
        public string ErrorCode
        {
            get
            {
                return this._errorCode;
            }
            set
            {
                this._errorCode = value;
            }
        }
        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private string _errorDetail;

        /// <summary>
        /// In case of task failure this field will provide the error description
        /// </summary>
        public string ErrorDetail
        {
            get
            {
                return this._errorDetail;
            }
            set
            {
                this._errorDetail = value;
            }
        }
        /// <summary>Backing field for <see cref="LastUpdateTime" /> property.</summary>
        private System.DateTime? _lastUpdateTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when task was last updated
        /// </summary>
        public System.DateTime? LastUpdateTime
        {
            get
            {
                return this._lastUpdateTime;
            }
            set
            {
                this._lastUpdateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="LogicalTimestamp" /> property.</summary>
        private long? _logicalTimestamp;

        /// <summary>The logical timestamp</summary>
        public long? LogicalTimestamp
        {
            get
            {
                return this._logicalTimestamp;
            }
            set
            {
                this._logicalTimestamp = value;
            }
        }
        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private string _operationType;

        /// <summary>Type of the operation tracked by the task</summary>
        public string OperationType
        {
            get
            {
                return this._operationType;
            }
            set
            {
                this._operationType = value;
            }
        }
        /// <summary>Backing field for <see cref="ParentTaskReference" /> property.</summary>
        private Nutanix.Powershell.Models.ITaskReference _parentTaskReference;

        /// <summary>Reference to the parent task</summary>
        public Nutanix.Powershell.Models.ITaskReference ParentTaskReference
        {
            get
            {
                return this._parentTaskReference;
            }
            set
            {
                this._parentTaskReference = value;
            }
        }
        /// <summary>Backing field for <see cref="PercentageComplete" /> property.</summary>
        private int? _percentageComplete;

        /// <summary>The completion percentage for the task</summary>
        public int? PercentageComplete
        {
            get
            {
                return this._percentageComplete;
            }
            set
            {
                this._percentageComplete = value;
            }
        }
        /// <summary>Backing field for <see cref="ProgressMessage" /> property.</summary>
        private string _progressMessage;

        /// <summary>Description of what currently the task is doing</summary>
        public string ProgressMessage
        {
            get
            {
                return this._progressMessage;
            }
            set
            {
                this._progressMessage = value;
            }
        }
        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private System.DateTime? _startTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when Task execution started
        /// </summary>
        public System.DateTime? StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                this._startTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Task status</summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Backing field for <see cref="SubtaskReferenceList" /> property.</summary>
        private Nutanix.Powershell.Models.ITaskReference[] _subtaskReferenceList;

        /// <summary>Reference to the sub-tasks</summary>
        public Nutanix.Powershell.Models.ITaskReference[] SubtaskReferenceList
        {
            get
            {
                return this._subtaskReferenceList;
            }
            set
            {
                this._subtaskReferenceList = value;
            }
        }
        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>UUID of the task.</summary>
        public string Uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }
        /// <summary>Creates an new <see cref="Task" /> instance.</summary>
        public Task()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            if (EntityReferenceList != null ) {
                    for (int __i = 0; __i < EntityReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"EntityReferenceList[{__i}]", EntityReferenceList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(ParentTaskReference), ParentTaskReference);
            if (SubtaskReferenceList != null ) {
                    for (int __i = 0; __i < SubtaskReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"SubtaskReferenceList[{__i}]", SubtaskReferenceList[__i]);
                    }
                  }
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// Task details
    public partial interface ITask : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.IClusterReference ClusterReference { get; set; }
        System.DateTime? CompletionTime { get; set; }
        System.DateTime? CreationTime { get; set; }
        Nutanix.Powershell.Models.IReference[] EntityReferenceList { get; set; }
        string ErrorCode { get; set; }
        string ErrorDetail { get; set; }
        System.DateTime? LastUpdateTime { get; set; }
        long? LogicalTimestamp { get; set; }
        string OperationType { get; set; }
        Nutanix.Powershell.Models.ITaskReference ParentTaskReference { get; set; }
        int? PercentageComplete { get; set; }
        string ProgressMessage { get; set; }
        System.DateTime? StartTime { get; set; }
        string Status { get; set; }
        Nutanix.Powershell.Models.ITaskReference[] SubtaskReferenceList { get; set; }
        string Uuid { get; set; }
    }
}