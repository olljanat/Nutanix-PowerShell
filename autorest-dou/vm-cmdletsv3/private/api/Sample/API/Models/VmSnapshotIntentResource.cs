namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a vm_snapshot</summary>
    public partial class VmSnapshotIntentResource : Sample.API.Models.IVmSnapshotIntentResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

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
        /// <summary>Backing field for Metadata property</summary>
        private Sample.API.Models.IVmSnapshotMetadata _metadata;

        /// <summary>The vm_snapshot kind metadata</summary>
        public Sample.API.Models.IVmSnapshotMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for Spec property</summary>
        private Sample.API.Models.IVmSnapshot _spec;

        /// <summary>The input object that defines a VM snapshot</summary>
        public Sample.API.Models.IVmSnapshot Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Models.IVmSnapshotDefStatus _status;

        /// <summary>The output object that defines a VM snapshot</summary>
        public Sample.API.Models.IVmSnapshotDefStatus Status
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
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
        /// <summary>Creates an new <see cref="VmSnapshotIntentResource" /> instance.</summary>
        public VmSnapshotIntentResource()
        {
        }
    }
    /// Response object for intentful operations on a vm_snapshot
    public partial interface IVmSnapshotIntentResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.IVmSnapshotMetadata Metadata { get; set; }
        Sample.API.Models.IVmSnapshot Spec { get; set; }
        Sample.API.Models.IVmSnapshotDefStatus Status { get; set; }
    }
}