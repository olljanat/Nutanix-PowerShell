namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Image checksum</summary>
    public partial class Checksum : Sample.API.Models.IChecksum, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ChecksumAlgorithm property</summary>
        private string _checksumAlgorithm;

        /// <summary>The type of checksum calculated for the image</summary>
        public string ChecksumAlgorithm
        {
            get
            {
                return this._checksumAlgorithm;
            }
            set
            {
                this._checksumAlgorithm = value;
            }
        }
        /// <summary>Backing field for ChecksumValue property</summary>
        private string _checksumValue;

        public string ChecksumValue
        {
            get
            {
                return this._checksumValue;
            }
            set
            {
                this._checksumValue = value;
            }
        }
        /// <summary>Creates an new <see cref="Checksum" /> instance.</summary>
        public Checksum()
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
            await eventListener.AssertNotNull(nameof(ChecksumAlgorithm),ChecksumAlgorithm);
            await eventListener.AssertNotNull(nameof(ChecksumValue),ChecksumValue);
        }
    }
    /// Image checksum
    public partial interface IChecksum : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ChecksumAlgorithm { get; set; }
        string ChecksumValue { get; set; }
    }
}