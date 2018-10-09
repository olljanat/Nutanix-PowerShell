namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>IP pool.</summary>
    public partial class IpPool : Sample.API.Models.IIpPool, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Range property</summary>
        private string _range;

        /// <summary>
        /// Range of IPs (example: 10.0.0.9 10.0.0.19).
        /// </summary>
        public string Range
        {
            get
            {
                return this._range;
            }
            set
            {
                this._range = value;
            }
        }
        /// <summary>Creates an new <see cref="IpPool" /> instance.</summary>
        public IpPool()
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
            await eventListener.AssertRegEx(nameof(Range),Range,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)[ ](?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
    }
    /// IP pool.
    public partial interface IIpPool : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Range { get; set; }
    }
}