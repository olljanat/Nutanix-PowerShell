namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IImageMetadata))]
    public class NewImageMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageMetadata" /></summary>
        private Nutanix.Powershell.Models.IImageMetadata _imageMetadata = new Nutanix.Powershell.Models.ImageMetadata();
        /// <summary>Categories for the image</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the image")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _imageMetadata.Categories = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _imageMetadata.ProjectReference = _imageMetadata.ProjectReference ?? new Nutanix.Powershell.Models.ProjectReference();
                _imageMetadata.ProjectReference.Uuid = value;
            }
        }
        /// <summary>Hash of the spec. This will be returned from server.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hash of the spec. This will be returned from server.")]
        public string SpecHash
        {
            set
            {
                _imageMetadata.SpecHash = value;
            }
        }
        /// <summary>Version number of the latest spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Version number of the latest spec.")]
        public int SpecVersion
        {
            set
            {
                _imageMetadata.SpecVersion = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _imageMetadata.OwnerReference = _imageMetadata.OwnerReference ?? new Nutanix.Powershell.Models.UserReference();
                _imageMetadata.OwnerReference.Uuid = value;
            }
        }
        /// <summary>image uuid</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "image uuid")]
        public string Uuid
        {
            set
            {
                _imageMetadata.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_imageMetadata);
        }
    }
}