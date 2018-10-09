namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="SubnetMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"SubnetMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.ISubnetMetadata))]
    public class NewSubnetMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="SubnetMetadata" /></summary>
        private Sample.API.Models.ISubnetMetadata _subnetMetadata = new Sample.API.Models.SubnetMetadata();
        /// <summary>Categories for the subnet</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the subnet")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _subnetMetadata.Categories = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when subnet was created</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when subnet was created")]
        public System.DateTime CreationTime
        {
            set
            {
                _subnetMetadata.CreationTime = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _subnetMetadata.Kind = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when subnet was last updated</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when subnet was last updated")]
        public System.DateTime LastUpdateTime
        {
            set
            {
                _subnetMetadata.LastUpdateTime = value;
            }
        }
        /// <summary>subnet name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "subnet name")]
        public string Name
        {
            set
            {
                _subnetMetadata.Name = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ProjectReferenceKind
        {
            set
            {
                _subnetMetadata.ProjectReference = _subnetMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _subnetMetadata.ProjectReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceName
        {
            set
            {
                _subnetMetadata.ProjectReference = _subnetMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _subnetMetadata.ProjectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _subnetMetadata.ProjectReference = _subnetMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _subnetMetadata.ProjectReference.Uuid = value;
            }
        }
        /// <summary>Hash of the spec. This will be returned from server.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hash of the spec. This will be returned from server.")]
        public string SpecHash
        {
            set
            {
                _subnetMetadata.SpecHash = value;
            }
        }
        /// <summary>Version number of the latest spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Version number of the latest spec.")]
        public int SpecVersion
        {
            set
            {
                _subnetMetadata.SpecVersion = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string UserReferenceKind
        {
            set
            {
                _subnetMetadata.OwnerReference = _subnetMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _subnetMetadata.OwnerReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceName
        {
            set
            {
                _subnetMetadata.OwnerReference = _subnetMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _subnetMetadata.OwnerReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _subnetMetadata.OwnerReference = _subnetMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _subnetMetadata.OwnerReference.Uuid = value;
            }
        }
        /// <summary>subnet uuid</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "subnet uuid")]
        public string Uuid
        {
            set
            {
                _subnetMetadata.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_subnetMetadata);
        }
    }
}