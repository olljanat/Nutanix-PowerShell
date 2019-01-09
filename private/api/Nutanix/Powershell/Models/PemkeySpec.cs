namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>SSL key</summary>
    public partial class PemkeySpec : Nutanix.Powershell.Models.IPemkeySpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CaChain" /> property.</summary>
        private byte[] _caChain;

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
        /// <summary>Backing field for <see cref="Cert" /> property.</summary>
        private byte[] _cert;

        public byte[] Cert
        {
            get
            {
                return this._cert;
            }
            set
            {
                this._cert = value;
            }
        }
        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private byte[] _key;

        public byte[] Key
        {
            get
            {
                return this._key;
            }
            set
            {
                this._key = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

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
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// SSL key type. Key types with RSA_2048, ECDSA_256 and ECDSA_384 are
        /// supported for key generation and importing.
        /// </summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="PemkeySpec" /> instance.</summary>
        public PemkeySpec()
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
            await eventListener.AssertNotNull(nameof(Type),Type);
            await eventListener.AssertNotNull(nameof(Cert),Cert);
            await eventListener.AssertNotNull(nameof(Key),Key);
        }
    }
    /// SSL key
    public partial interface IPemkeySpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        byte[] CaChain { get; set; }
        byte[] Cert { get; set; }
        byte[] Key { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}