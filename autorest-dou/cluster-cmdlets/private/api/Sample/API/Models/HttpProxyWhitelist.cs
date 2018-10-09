namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>HTTP Proxy Whitelist.</summary>
    public partial class HttpProxyWhitelist : Sample.API.Models.IHttpProxyWhitelist, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Target property</summary>
        private string _target;

        public string Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        /// <summary>Backing field for TargetType property</summary>
        private string _targetType;

        public string TargetType
        {
            get
            {
                return this._targetType;
            }
            set
            {
                this._targetType = value;
            }
        }
        /// <summary>Creates an new <see cref="HttpProxyWhitelist" /> instance.</summary>
        public HttpProxyWhitelist()
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
            await eventListener.AssertNotNull(nameof(Target),Target);
            await eventListener.AssertNotNull(nameof(TargetType),TargetType);
        }
    }
    /// HTTP Proxy Whitelist.
    public partial interface IHttpProxyWhitelist : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Target { get; set; }
        string TargetType { get; set; }
    }
}