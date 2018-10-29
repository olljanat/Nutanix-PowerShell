namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Input for a task poll</summary>
    public partial class TaskPollInput : Nutanix.Powershell.Models.ITaskPollInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="PollTimeoutSeconds" /> property.</summary>
        private int _pollTimeoutSeconds;

        /// <summary>Poll timeout in seconds</summary>
        public int PollTimeoutSeconds
        {
            get
            {
                return this._pollTimeoutSeconds;
            }
            set
            {
                this._pollTimeoutSeconds = value;
            }
        }
        /// <summary>Backing field for <see cref="TaskUuidList" /> property.</summary>
        private string[] _taskUuidList;

        /// <summary>List of task UUIDs to poll on</summary>
        public string[] TaskUuidList
        {
            get
            {
                return this._taskUuidList;
            }
            set
            {
                this._taskUuidList = value;
            }
        }
        /// <summary>Creates an new <see cref="TaskPollInput" /> instance.</summary>
        public TaskPollInput()
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
            await eventListener.AssertIsLessThanOrEqual(nameof(PollTimeoutSeconds),PollTimeoutSeconds,30);
            await eventListener.AssertNotNull(nameof(TaskUuidList), TaskUuidList);
            if (TaskUuidList != null ) {
                    for (int __i = 0; __i < TaskUuidList.Length; __i++) {
                      await eventListener.AssertRegEx($"TaskUuidList[{__i}]",TaskUuidList[__i],@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                    }
                  }
        }
    }
    /// Input for a task poll
    public partial interface ITaskPollInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int PollTimeoutSeconds { get; set; }
        string[] TaskUuidList { get; set; }
    }
}