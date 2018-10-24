namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="VmMetadata" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IVmMetadata))]
    public class NewVmMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmMetadata" /></summary>
        private Nutanix.Powershell.Models.IVmMetadata _vmMetadata = new Nutanix.Powershell.Models.VmMetadata();
        /// <summary>Categories for the vm</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the vm")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _vmMetadata.Categories = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when vm was created</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when vm was created")]
        public System.DateTime CreationTime
        {
            set
            {
                _vmMetadata.CreationTime = value;
            }
        }
        /// <summary>The kind name</summary>
        public string Kind
        {
            set
            {
                _vmMetadata.Kind = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when vm was last updated</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when vm was last updated")]
        public System.DateTime LastUpdateTime
        {
            set
            {
                _vmMetadata.LastUpdateTime = value;
            }
        }
        /// <summary>vm name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "vm name")]
        public string Name
        {
            set
            {
                _vmMetadata.Name = value;
            }
        }
        /// <summary>The kind name</summary>
        public string ProjectReferenceKind
        {
            set
            {
                _vmMetadata.ProjectReference = _vmMetadata.ProjectReference ?? new Nutanix.Powershell.Models.ProjectReference();
                _vmMetadata.ProjectReference.Kind = "project";
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceName
        {
            set
            {
                _vmMetadata.ProjectReference = _vmMetadata.ProjectReference ?? new Nutanix.Powershell.Models.ProjectReference();
                _vmMetadata.ProjectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _vmMetadata.ProjectReference = _vmMetadata.ProjectReference ?? new Nutanix.Powershell.Models.ProjectReference();
                _vmMetadata.ProjectReference.Uuid = value;
            }
        }
        /// <summary>Hash of the spec. This will be returned from server.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hash of the spec. This will be returned from server.")]
        public string SpecHash
        {
            set
            {
                _vmMetadata.SpecHash = value;
            }
        }
        /// <summary>Version number of the latest spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Version number of the latest spec.")]
        public int SpecVersion
        {
            set
            {
                _vmMetadata.SpecVersion = value;
            }
        }
        /// <summary>The kind name</summary>
        public string UserReferenceKind
        {
            set
            {
                _vmMetadata.OwnerReference = _vmMetadata.OwnerReference ?? new Nutanix.Powershell.Models.UserReference();
                _vmMetadata.OwnerReference.Kind = "user";
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceName
        {
            set
            {
                _vmMetadata.OwnerReference = _vmMetadata.OwnerReference ?? new Nutanix.Powershell.Models.UserReference();
                _vmMetadata.OwnerReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _vmMetadata.OwnerReference = _vmMetadata.OwnerReference ?? new Nutanix.Powershell.Models.UserReference();
                _vmMetadata.OwnerReference.Uuid = value;
            }
        }
        /// <summary>vm uuid</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "vm uuid")]
        public string Uuid
        {
            set
            {
                _vmMetadata.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _vmMetadata.Kind = "vm";
            WriteObject(_vmMetadata);
        }
    }
}