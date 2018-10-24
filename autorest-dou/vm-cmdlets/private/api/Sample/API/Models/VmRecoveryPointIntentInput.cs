namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a vm_recovery_point</summary>
    public partial class VmRecoveryPointIntentInput : Nutanix.Powershell.Models.IVmRecoveryPointIntentInput, Microsoft.Rest.ClientRuntime.IValidates
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
        private Nutanix.Powershell.Models.IVmRecoveryPointMetadata _metadata;

        /// <summary>The vm_recovery_point kind metadata</summary>
        public Nutanix.Powershell.Models.IVmRecoveryPointMetadata Metadata
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
        private Nutanix.Powershell.Models.IVmRecoveryPoint _spec;

        /// <summary>The input object that defines a vm recovery point.</summary>
        public Nutanix.Powershell.Models.IVmRecoveryPoint Spec
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
            await eventListener.AssertNotNull(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
        }
        /// <summary>Creates an new <see cref="VmRecoveryPointIntentInput" /> instance.</summary>
        public VmRecoveryPointIntentInput()
        {
        }
    }
    /// An intentful representation of a vm_recovery_point
    public partial interface IVmRecoveryPointIntentInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.IVmRecoveryPointMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.IVmRecoveryPoint Spec { get; set; }
    }
}