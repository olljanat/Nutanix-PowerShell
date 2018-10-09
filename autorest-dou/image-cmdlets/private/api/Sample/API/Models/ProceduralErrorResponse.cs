namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Response for invoking a procedural call.
    /// </summary>
    public partial class ProceduralErrorResponse : Sample.API.Models.IProceduralErrorResponse, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Creates an new <see cref="ProceduralErrorResponse" /> instance.</summary>
        public ProceduralErrorResponse()
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
    /// Response for invoking a procedural call.
    public partial interface IProceduralErrorResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IMessageResource[] MessageList { get; set; }
    }
}