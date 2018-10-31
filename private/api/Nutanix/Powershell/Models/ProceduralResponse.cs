namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Response for invoking a procedural call. Contains a task UUID.
    /// </summary>
    public partial class ProceduralResponse : Nutanix.Powershell.Models.IProceduralResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="TaskUuid" /> property.</summary>
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
        /// <summary>Creates an new <see cref="ProceduralResponse" /> instance.</summary>
        public ProceduralResponse()
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
            await eventListener.AssertNotNull(nameof(TaskUuid),TaskUuid);
            await eventListener.AssertRegEx(nameof(TaskUuid),TaskUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// Response for invoking a procedural call. Contains a task UUID.
    public partial interface IProceduralResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string TaskUuid { get; set; }
    }
}