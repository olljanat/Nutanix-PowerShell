namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Certificate info</summary>
    public partial class CertificateSpec : Sample.API.Models.ICertificateSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Certificate property</summary>
        private byte[] _certificate;

        /// <summary>Certificate content</summary>
        public byte[] Certificate
        {
            get
            {
                return this._certificate;
            }
            set
            {
                this._certificate = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Certificate file name</summary>
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
        /// <summary>Creates an new <see cref="CertificateSpec" /> instance.</summary>
        public CertificateSpec()
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
            await eventListener.AssertNotNull(nameof(Certificate),Certificate);
        }
    }
    /// Certificate info
    public partial interface ICertificateSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        byte[] Certificate { get; set; }
        string Name { get; set; }
    }
}