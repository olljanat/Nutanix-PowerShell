namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IImageResources))]
    public class NewImageResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageResources" /></summary>
        private Sample.API.Models.IImageResources _imageResources = new Sample.API.Models.ImageResources();
        /// <summary>
        /// Indicates the CPU architecture that the image is compatible with. If this is not specified for an image this will default
        /// to the CPU architecture type of the cluster.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the CPU architecture that the image is compatible with. If this is not specified for an image this will default to the CPU architecture type of the cluster.")]
        public string Architecture
        {
            set
            {
                _imageResources.Architecture = value;
            }
        }
        /// <summary>The type of checksum calculated for the image</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The type of checksum calculated for the image")]
        public string ChecksumChecksumAlgorithm
        {
            set
            {
                _imageResources.Checksum = _imageResources.Checksum ?? new Sample.API.Models.Checksum();
                _imageResources.Checksum.ChecksumAlgorithm = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ChecksumChecksumValue
        {
            set
            {
                _imageResources.Checksum = _imageResources.Checksum ?? new Sample.API.Models.Checksum();
                _imageResources.Checksum.ChecksumValue = value;
            }
        }
        /// <summary>The type of image.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of image.")]
        public string ImageType
        {
            set
            {
                _imageResources.ImageType = value;
            }
        }
        /// <summary>Name of the producer/distribution of the image. For example windows or red hat.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the producer/distribution of the image. For example windows or red hat.")]
        public string ImageVersionResourcesProductName
        {
            set
            {
                _imageResources.Version = _imageResources.Version ?? new Sample.API.Models.ImageVersionResources();
                _imageResources.Version.ProductName = value;
            }
        }
        /// <summary>Version string for the disk image.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Version string for the disk image.")]
        public string ImageVersionResourcesProductVersion
        {
            set
            {
                _imageResources.Version = _imageResources.Version ?? new Sample.API.Models.ImageVersionResources();
                _imageResources.Version.ProductVersion = value;
            }
        }
        /// <summary>
        /// The source URI points at the location of a the source image which is used to create/update image.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The source URI points at the location of a the source image which is used to create/update image.")]
        public string SourceUri
        {
            set
            {
                _imageResources.SourceUri = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_imageResources);
        }
    }
}