namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmSnapshotMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmSnapshotMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmSnapshotMetadata))]
    public class NewVmSnapshotMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmSnapshotMetadata" /></summary>
        private Sample.API.Models.IVmSnapshotMetadata _vmSnapshotMetadata = new Sample.API.Models.VmSnapshotMetadata();
        /// <summary>Categories for the vm_snapshot</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the vm_snapshot")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _vmSnapshotMetadata.Categories = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when vm_snapshot was created</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when vm_snapshot was created")]
        public System.DateTime CreationTime
        {
            set
            {
                _vmSnapshotMetadata.CreationTime = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _vmSnapshotMetadata.Kind = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when vm_snapshot was last updated</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when vm_snapshot was last updated")]
        public System.DateTime LastUpdateTime
        {
            set
            {
                _vmSnapshotMetadata.LastUpdateTime = value;
            }
        }
        /// <summary>vm_snapshot name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "vm_snapshot name")]
        public string Name
        {
            set
            {
                _vmSnapshotMetadata.Name = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ProjectReferenceKind
        {
            set
            {
                _vmSnapshotMetadata.ProjectReference = _vmSnapshotMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _vmSnapshotMetadata.ProjectReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceName
        {
            set
            {
                _vmSnapshotMetadata.ProjectReference = _vmSnapshotMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _vmSnapshotMetadata.ProjectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _vmSnapshotMetadata.ProjectReference = _vmSnapshotMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _vmSnapshotMetadata.ProjectReference.Uuid = value;
            }
        }
        /// <summary>Hash of the spec. This will be returned from server.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hash of the spec. This will be returned from server.")]
        public string SpecHash
        {
            set
            {
                _vmSnapshotMetadata.SpecHash = value;
            }
        }
        /// <summary>Version number of the latest spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Version number of the latest spec.")]
        public int SpecVersion
        {
            set
            {
                _vmSnapshotMetadata.SpecVersion = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string UserReferenceKind
        {
            set
            {
                _vmSnapshotMetadata.OwnerReference = _vmSnapshotMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _vmSnapshotMetadata.OwnerReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceName
        {
            set
            {
                _vmSnapshotMetadata.OwnerReference = _vmSnapshotMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _vmSnapshotMetadata.OwnerReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _vmSnapshotMetadata.OwnerReference = _vmSnapshotMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _vmSnapshotMetadata.OwnerReference.Uuid = value;
            }
        }
        /// <summary>vm_snapshot uuid</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "vm_snapshot uuid")]
        public string Uuid
        {
            set
            {
                _vmSnapshotMetadata.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmSnapshotMetadata);
        }
    }
}