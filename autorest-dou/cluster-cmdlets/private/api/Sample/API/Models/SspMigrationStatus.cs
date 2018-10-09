namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>SSP configuration migration state.</summary>
    public partial class SspMigrationStatus : Sample.API.Models.ISspMigrationStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for TaskUuid property</summary>
        private string _taskUuid;

        /// <summary>Resultant task uuid for the submitted request.</summary>
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
        /// <summary>Creates an new <see cref="SspMigrationStatus" /> instance.</summary>
        public SspMigrationStatus()
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
            await eventListener.AssertRegEx(nameof(TaskUuid),TaskUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// SSP configuration migration state.
    public partial interface ISspMigrationStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string TaskUuid { get; set; }
    }
}