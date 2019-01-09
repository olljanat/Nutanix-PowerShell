namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>CA certificate info.</summary>
    public partial class CaCert : Nutanix.Powershell.Models.ICaCert, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CaName" /> property.</summary>
        private string _caName;

        /// <summary>Name of the certificate authority.</summary>
        public string CaName
        {
            get
            {
                return this._caName;
            }
            set
            {
                this._caName = value;
            }
        }
        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private byte[] _certificate;

        /// <summary>Certificate content.</summary>
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
        /// <summary>Creates an new <see cref="CaCert" /> instance.</summary>
        public CaCert()
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
            await eventListener.AssertNotNull(nameof(CaName),CaName);
            await eventListener.AssertNotNull(nameof(Certificate),Certificate);
        }
    }
    /// CA certificate info.
    public partial interface ICaCert : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string CaName { get; set; }
        byte[] Certificate { get; set; }
    }
}