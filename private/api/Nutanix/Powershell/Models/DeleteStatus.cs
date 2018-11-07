namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    /// </summary>
    public partial class DeleteStatus : Nutanix.Powershell.Models.IDeleteStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        public string State
        {
            get
            {
                return this._state;
            }
            internal set
            {
                this._state = value;
            }
        }
        /// <summary>Backing field for <see cref="ExecutionContext" /> property.</summary>
        private Nutanix.Powershell.Models.IExecutionContext _executionContext;

        /// <summary>The delete task metadata</summary>
        public Nutanix.Powershell.Models.IExecutionContext ExecutionContext
        {
            get
            {
                return this._executionContext;
            }
            internal set
            {
                this._executionContext = value;
            }
        }
        
        /// <summary>Creates an new <see cref="DeleteStatus" /> instance.</summary>
        public DeleteStatus()
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
        }
    }
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    public partial interface IDeleteStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string State { get;  }
        Nutanix.Powershell.Models.IExecutionContext ExecutionContext { get;  }

  
    }
}