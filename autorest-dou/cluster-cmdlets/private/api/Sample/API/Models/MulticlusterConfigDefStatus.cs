namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Status for multicluster configuration request.</summary>
    public partial class MulticlusterConfigDefStatus : Sample.API.Models.IMulticlusterConfigDefStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
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
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>The state of the multicluster configuration request.</summary>
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
        /// <summary>Creates an new <see cref="MulticlusterConfigDefStatus" /> instance.</summary>
        public MulticlusterConfigDefStatus()
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
            if (MessageList != null ) {
                    for (int __i = 0; __i < MessageList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"MessageList[{__i}]", MessageList[__i]);
                    }
                  }
        }
    }
    /// Status for multicluster configuration request.
    public partial interface IMulticlusterConfigDefStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
        string State { get; set; }
    }
}