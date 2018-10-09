namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Extra information for ssp configuration migration.</summary>
    public partial class SspConfigInput : Sample.API.Models.ISspConfigInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DirectoryServiceServiceAccount property</summary>
        private Sample.API.Models.ICredentials _directoryServiceServiceAccount;

        /// <summary>Credentials to login server</summary>
        public Sample.API.Models.ICredentials DirectoryServiceServiceAccount
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
        /// <summary>Backing field for ShouldSkipMigration property</summary>
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
        Sample.API.Models.ICredentials DirectoryServiceServiceAccount { get; set; }
        bool? ShouldSkipMigration { get; set; }
    }
}