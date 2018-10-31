namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IImageIntentInput))]
    public class NewImageIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageIntentInput" /></summary>
        private Nutanix.Powershell.Models.IImageIntentInput _imageIntentInput = new Nutanix.Powershell.Models.ImageIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _imageIntentInput.ApiVersion = value;
            }
        }
        /// <summary>A description for image.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A description for image.")]
        public string ImageDescription
        {
            set
            {
                _imageIntentInput.Spec = _imageIntentInput.Spec ?? new Nutanix.Powershell.Models.Image();
                _imageIntentInput.Spec.Description = value;
            }
        }
        /// <summary>image Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "image Name.")]
        public string ImageName
        {
            set
            {
                _imageIntentInput.Spec = _imageIntentInput.Spec ?? new Nutanix.Powershell.Models.Image();
                _imageIntentInput.Spec.Name = value;
            }
        }
        /// <summary>Describes the image spec resources object.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Describes the image spec resources object.")]
        public Nutanix.Powershell.Models.IImageResources ImageResources
        {
            set
            {
                _imageIntentInput.Spec = _imageIntentInput.Spec ?? new Nutanix.Powershell.Models.Image();
                _imageIntentInput.Spec.Resources = value;
            }
        }
        /// <summary>The image kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The image kind metadata")]
        public Nutanix.Powershell.Models.IImageMetadata Metadata
        {
            set
            {
                _imageIntentInput.Metadata = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_imageIntentInput);
        }
    }
}