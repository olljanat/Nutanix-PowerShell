namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>SSL certificate.</summary>
    public partial class SslKey : Nutanix.Powershell.Models.ISslKey, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ExpireDatetime" /> property.</summary>
        private System.DateTime? _expireDatetime;

        /// <summary>UTC date and time in RFC-3339 format when the key expires</summary>
        public System.DateTime? ExpireDatetime
        {
            get
            {
                return this._expireDatetime;
            }
            set
            {
                this._expireDatetime = value;
            }
        }
        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        public string KeyName
        {
            get
            {
                return this._keyName;
            }
            set
            {
                this._keyName = value;
            }
        }
        /// <summary>Backing field for <see cref="KeyType" /> property.</summary>
        private string _keyType;

        /// <summary>
        /// SSL key type. Key types with RSA_2048, ECDSA_256 and ECDSA_384 are
        /// supported for key generation and importing.
        /// </summary>
        public string KeyType
        {
            get
            {
                return this._keyType;
            }
            set
            {
                this._keyType = value;
            }
        }
        /// <summary>Backing field for <see cref="SigningInfo" /> property.</summary>
        private Nutanix.Powershell.Models.ICertificationSigningInfo _signingInfo;

        /// <summary>
        /// Customer information used in Certificate Signing Request for
        /// creating digital certificates.
        /// </summary>
        public Nutanix.Powershell.Models.ICertificationSigningInfo SigningInfo
        {
            get
            {
                return this._signingInfo;
            }
            set
            {
                this._signingInfo = value;
            }
        }
        /// <summary>Creates an new <see cref="SslKey" /> instance.</summary>
        public SslKey()
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
            await eventListener.AssertNotNull(nameof(KeyType),KeyType);
            await eventListener.AssertObjectIsValid(nameof(SigningInfo), SigningInfo);
        }
    }
    /// SSL certificate.
    public partial interface ISslKey : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.DateTime? ExpireDatetime { get; set; }
        string KeyName { get; set; }
        string KeyType { get; set; }
        Nutanix.Powershell.Models.ICertificationSigningInfo SigningInfo { get; set; }
    }
}