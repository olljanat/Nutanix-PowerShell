namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageVersionResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageVersionResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IImageVersionResources))]
    public class NewImageVersionResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageVersionResources" /></summary>
        private Sample.API.Models.IImageVersionResources _imageVersionResources = new Sample.API.Models.ImageVersionResources();
        /// <summary>Name of the producer/distribution of the image. For example windows or red hat.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Name of the producer/distribution of the image. For example windows or red hat.")]
        public string ProductName
        {
            set
            {
                _imageVersionResources.ProductName = value;
            }
        }
        /// <summary>Version string for the disk image.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Version string for the disk image.")]
        public string ProductVersion
        {
            set
            {
                _imageVersionResources.ProductVersion = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_imageVersionResources);
        }
    }
}