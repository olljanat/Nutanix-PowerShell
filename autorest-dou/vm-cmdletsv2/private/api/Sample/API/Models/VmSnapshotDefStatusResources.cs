namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Snapshot Resources</summary>
    public partial class VmSnapshotDefStatusResources : Sample.API.Models.IVmSnapshotDefStatusResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for EntityUuid property</summary>
        private string _entityUuid;

        /// <summary>
        /// UUID of the base entity for which snapshot need to be taken
        /// </summary>
        public string EntityUuid
        {
            get
            {
                return this._entityUuid;
            }
            set
            {
                this._entityUuid = value;
            }
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertRegEx(nameof(EntityUuid),EntityUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
        /// <summary>Creates an new <see cref="VmSnapshotDefStatusResources" /> instance.</summary>
        public VmSnapshotDefStatusResources()
        {
        }
    }
    /// Snapshot Resources
    public partial interface IVmSnapshotDefStatusResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string EntityUuid { get; set; }
    }
}