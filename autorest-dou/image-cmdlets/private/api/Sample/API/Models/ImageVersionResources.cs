namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The image version, which is composed of a product name and product version.
    /// </summary>
    public partial class ImageVersionResources : Sample.API.Models.IImageVersionResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ProductName property</summary>
        private string _productName;

        /// <summary>
        /// Name of the producer/distribution of the image. For example windows or red hat.
        /// </summary>
        public string ProductName
        {
            get
            {
                return this._productName;
            }
            set
            {
                this._productName = value;
            }
        }
        /// <summary>Backing field for ProductVersion property</summary>
        private string _productVersion;

        /// <summary>Version string for the disk image.</summary>
        public string ProductVersion
        {
            get
            {
                return this._productVersion;
            }
            set
            {
                this._productVersion = value;
            }
        }
        /// <summary>Creates an new <see cref="ImageVersionResources" /> instance.</summary>
        public ImageVersionResources()
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
            await eventListener.AssertNotNull(nameof(ProductName),ProductName);
            await eventListener.AssertMaximumLength(nameof(ProductName),ProductName,64);
            await eventListener.AssertNotNull(nameof(ProductVersion),ProductVersion);
            await eventListener.AssertMaximumLength(nameof(ProductVersion),ProductVersion,64);
        }
    }
    /// The image version, which is composed of a product name and product version.
    public partial interface IImageVersionResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ProductName { get; set; }
        string ProductVersion { get; set; }
    }
}