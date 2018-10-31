namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Image" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IImage))]
    public class NewImageObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Image" /></summary>
        private Nutanix.Powershell.Models.IImage _image = new Nutanix.Powershell.Models.Image();
        /// <summary>A description for image.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A description for image.")]
        public string Description
        {
            set
            {
                _image.Description = value;
            }
        }
        /// <summary>image Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "image Name.")]
        public string Name
        {
            set
            {
                _image.Name = value;
            }
        }
        /// <summary>Describes the image spec resources object.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Describes the image spec resources object.")]
        public Nutanix.Powershell.Models.IImageResources Resources
        {
            set
            {
                _image.Resources = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_image);
        }
    }
}