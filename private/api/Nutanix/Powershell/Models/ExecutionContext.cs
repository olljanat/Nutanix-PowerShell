namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The ExecutionContext of a call, used to fetch the task id to poll a resource
    /// </summary>

     public partial class ExecutionContext : Nutanix.Powershell.Models.IExecutionContext
    {
        private string _taskUuid;
        public string TaskUuid
        {
            get 
            {
                return this._taskUuid;
            }
            set 
            {
                this._taskUuid = value;
            }
        }

        public ExecutionContext()
        {
        }
    }
        /// The status of a REST API call. Only used when there is a failure to
    /// report.
    public partial interface IExecutionContext : Microsoft.Rest.ClientRuntime.IJsonSerializable {
       string TaskUuid { get;  set;}
    }
}