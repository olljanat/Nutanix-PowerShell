namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IImageMetadata))]
    public class NewImageMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageMetadata" /></summary>
        private Sample.API.Models.IImageMetadata _imageMetadata = new Sample.API.Models.ImageMetadata();
        /// <summary>Categories for the image</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the image")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _imageMetadata.Categories = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when image was created</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when image was created")]
        public System.DateTime CreationTime
        {
            set
            {
                _imageMetadata.CreationTime = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _imageMetadata.Kind = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when image was last updated</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when image was last updated")]
        public System.DateTime LastUpdateTime
        {
            set
            {
                _imageMetadata.LastUpdateTime = value;
            }
        }
        /// <summary>image name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "image name")]
        public string Name
        {
            set
            {
                _imageMetadata.Name = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ProjectReferenceKind
        {
            set
            {
                _imageMetadata.ProjectReference = _imageMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _imageMetadata.ProjectReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceName
        {
            set
            {
                _imageMetadata.ProjectReference = _imageMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _imageMetadata.ProjectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _imageMetadata.ProjectReference = _imageMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
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
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string UserReferenceKind
        {
            set
            {
                _imageMetadata.OwnerReference = _imageMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _imageMetadata.OwnerReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceName
        {
            set
            {
                _imageMetadata.OwnerReference = _imageMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _imageMetadata.OwnerReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _imageMetadata.OwnerReference = _imageMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
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