namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Extra information for ssp configuration migration.</summary>
    public partial class SspConfigInput : Nutanix.Powershell.Models.ISspConfigInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="DirectoryServiceServiceAccount" /> property.</summary>
        private Nutanix.Powershell.Models.ICredentials _directoryServiceServiceAccount;

        /// <summary>Credentials to login server</summary>
        public Nutanix.Powershell.Models.ICredentials DirectoryServiceServiceAccount
        {
            get
            {
                return this._directoryServiceServiceAccount;
            }
            set
            {
                this._directoryServiceServiceAccount = value;
            }
        }
        /// <summary>Backing field for <see cref="ShouldSkipMigration" /> property.</summary>
        private bool? _shouldSkipMigration;

        /// <summary>
        /// Migration can be skipped or not. If this flag is set to True, migration will be skipped and the Prism Element will be
        /// directly marked as migration completed. Default is False.
        /// </summary>
        public bool? ShouldSkipMigration
        {
            get
            {
                return this._shouldSkipMigration;
            }
            set
            {
                this._shouldSkipMigration = value;
            }
        }
        /// <summary>Creates an new <see cref="SspConfigInput" /> instance.</summary>
        public SspConfigInput()
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
            await eventListener.AssertObjectIsValid(nameof(DirectoryServiceServiceAccount), DirectoryServiceServiceAccount);
        }
    }
    /// Extra information for ssp configuration migration.
    public partial interface ISspConfigInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.ICredentials DirectoryServiceServiceAccount { get; set; }
        bool? ShouldSkipMigration { get; set; }
    }
}