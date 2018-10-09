namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Client authentication config.</summary>
    public partial class ClientAuth : Sample.API.Models.IClientAuth, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CaChain property</summary>
        private byte[] _caChain;

        /// <summary>Content of CA chain certificate.</summary>
        public byte[] CaChain
        {
            get
            {
                return this._caChain;
            }
            set
            {
                this._caChain = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Name of CA chain file.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private string _status;

        /// <summary>Status of client authentication.</summary>
        public string Status
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
        /// <summary>Creates an new <see cref="ClientAuth" /> instance.</summary>
        public ClientAuth()
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
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertNotNull(nameof(Status),Status);
        }
    }
    /// Client authentication config.
    public partial interface IClientAuth : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        byte[] CaChain { get; set; }
        string Name { get; set; }
        string Status { get; set; }
    }
}