namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Input spec for certificate upload.</summary>
    public partial class CertificateSpecUploadInput : Sample.API.Models.ICertificateSpecUploadInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for SpecList property</summary>
        private Sample.API.Models.ICertificateSpec[] _specList;

        /// <summary>List of certificate specs</summary>
        public Sample.API.Models.ICertificateSpec[] SpecList
        {
            get
            {
                return this._specList;
            }
            set
            {
                this._specList = value;
            }
        }
        /// <summary>Creates an new <see cref="CertificateSpecUploadInput" /> instance.</summary>
        public CertificateSpecUploadInput()
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
            await eventListener.AssertNotNull(nameof(SpecList), SpecList);
            if (SpecList != null ) {
                    for (int __i = 0; __i < SpecList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"SpecList[{__i}]", SpecList[__i]);
                    }
                  }
        }
    }
    /// Input spec for certificate upload.
    public partial interface ICertificateSpecUploadInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.ICertificateSpec[] SpecList { get; set; }
    }
}