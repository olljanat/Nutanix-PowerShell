namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cloud credentials configuration</summary>
    public partial class CloudCredentialsDefStatus : Sample.API.Models.ICloudCredentialsDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Id property</summary>
        private long _id;

        /// <summary>ID to uniquely identify cloud credentials</summary>
        public long Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Backing field for MessageList property</summary>
        private Sample.API.Models.IMessageResource[] _messageList;

        public Sample.API.Models.IMessageResource[] MessageList
        {
            get
            {
                return this._messageList;
            }
            set
            {
                this._messageList = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Credentials name.</summary>
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
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.ICloudCredentialsResources _resources;

        /// <summary>Cloud credentials resources</summary>
        public Sample.API.Models.ICloudCredentialsResources Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the entity.</summary>
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }
        /// <summary>Creates an new <see cref="CloudCredentialsDefStatus" /> instance.</summary>
        public CloudCredentialsDefStatus()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Cloud credentials configuration
    public partial interface ICloudCredentialsDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        long Id { get; set; }
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string Name { get; set; }
        Sample.API.Models.ICloudCredentialsResources Resources { get; set; }
        string State { get; set; }
    }
}