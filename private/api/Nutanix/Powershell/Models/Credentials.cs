namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Credentials to login server</summary>
    public partial class Credentials : Nutanix.Powershell.Models.ICredentials, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
            }
        }
        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
            }
        }
        /// <summary>Creates an new <see cref="Credentials" /> instance.</summary>
        public Credentials()
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
            await eventListener.AssertNotNull(nameof(Username),Username);
        }
    }
    /// Credentials to login server
    public partial interface ICredentials : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Password { get; set; }
        string Username { get; set; }
    }
}