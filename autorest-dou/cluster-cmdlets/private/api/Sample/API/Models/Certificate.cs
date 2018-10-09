namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Certificate content</summary>
    public partial class Certificate : Sample.API.Models.ICertificate, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Content property</summary>
        private byte[] _content;

        /// <summary>Certificate content</summary>
        public byte[] Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }
        /// <summary>Creates an new <see cref="Certificate" /> instance.</summary>
        public Certificate()
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
            await eventListener.AssertNotNull(nameof(Content),Content);
        }
    }
    /// Certificate content
    public partial interface ICertificate : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        byte[] Content { get; set; }
    }
}