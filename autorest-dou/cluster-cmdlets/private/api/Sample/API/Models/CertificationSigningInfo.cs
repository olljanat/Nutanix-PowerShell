namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Customer information used in Certificate Signing Request for
    /// creating digital certificates.
    /// </summary>
    public partial class CertificationSigningInfo : Sample.API.Models.ICertificationSigningInfo
    {
        /// <summary>Backing field for City property</summary>
        private string _city;

        /// <summary>The Town or City where customer's business is located.</summary>
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        /// <summary>Backing field for CommonName property</summary>
        private string _commonName;

        /// <summary>Common name of the organization or host server</summary>
        public string CommonName
        {
            get
            {
                return this._commonName;
            }
            set
            {
                this._commonName = value;
            }
        }
        /// <summary>Backing field for CommonNameSuffix property</summary>
        private string _commonNameSuffix;

        /// <summary>
        /// Common name is by default <node_uuid>.nutanix.com, but if a customer
        /// wants something instead of nutanix.com they can specify it here.
        /// </summary>
        public string CommonNameSuffix
        {
            get
            {
                return this._commonNameSuffix;
            }
            set
            {
                this._commonNameSuffix = value;
            }
        }
        /// <summary>Backing field for CountryCode property</summary>
        private string _countryCode;

        /// <summary>
        /// Two-letter ISO code for Country where customer's organization is
        /// located.
        /// </summary>
        public string CountryCode
        {
            get
            {
                return this._countryCode;
            }
            set
            {
                this._countryCode = value;
            }
        }
        /// <summary>Backing field for EmailAddress property</summary>
        private string _emailAddress;

        /// <summary>Email address of the certificate administrator.</summary>
        public string EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        /// <summary>Backing field for Organization property</summary>
        private string _organization;

        /// <summary>Name of the customer business.</summary>
        public string Organization
        {
            get
            {
                return this._organization;
            }
            set
            {
                this._organization = value;
            }
        }
        /// <summary>Backing field for State property</summary>
        private string _state;

        /// <summary>
        /// The Province, Region, County or State where customer business is
        /// is located.
        /// </summary>
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
        /// <summary>Creates an new <see cref="CertificationSigningInfo" /> instance.</summary>
        public CertificationSigningInfo()
        {
        }
    }
    /// Customer information used in Certificate Signing Request for
    /// creating digital certificates.
    public partial interface ICertificationSigningInfo : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string City { get; set; }
        string CommonName { get; set; }
        string CommonNameSuffix { get; set; }
        string CountryCode { get; set; }
        string EmailAddress { get; set; }
        string Organization { get; set; }
        string State { get; set; }
    }
}