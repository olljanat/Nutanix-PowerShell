namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response from a task poll request</summary>
    public partial class TaskPollResponse : Nutanix.Powershell.Models.ITaskPollResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Entities" /> property.</summary>
        private Nutanix.Powershell.Models.ITask[] _entities;

        public Nutanix.Powershell.Models.ITask[] Entities
        {
            get
            {
                return this._entities;
            }
            set
            {
                this._entities = value;
            }
        }
        /// <summary>Backing field for <see cref="HasPollTimedOut" /> property.</summary>
        private bool? _hasPollTimedOut;

        /// <summary>Did the poll timeout before all polled tasks completed</summary>
        public bool? HasPollTimedOut
        {
            get
            {
                return this._hasPollTimedOut;
            }
            set
            {
                this._hasPollTimedOut = value;
            }
        }
        /// <summary>Creates an new <see cref="TaskPollResponse" /> instance.</summary>
        public TaskPollResponse()
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
            if (Entities != null ) {
                    for (int __i = 0; __i < Entities.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Entities[{__i}]", Entities[__i]);
                    }
                  }
        }
    }
    /// Response from a task poll request
    public partial interface ITaskPollResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.ITask[] Entities { get; set; }
        bool? HasPollTimedOut { get; set; }
    }
}