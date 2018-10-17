namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmRecoveryPointResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmRecoveryPointResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmRecoveryPointResources))]
    public class NewVmRecoveryPointResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmRecoveryPointResources" /></summary>
        private Sample.API.Models.IVmRecoveryPointResources _vmRecoveryPointResources = new Sample.API.Models.VmRecoveryPointResources();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string AvailabilityZoneReferenceKind
        {
            set
            {
                _vmRecoveryPointResources.SourceAvailabilityZoneReference = _vmRecoveryPointResources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPointResources.SourceAvailabilityZoneReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceName
        {
            set
            {
                _vmRecoveryPointResources.SourceAvailabilityZoneReference = _vmRecoveryPointResources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPointResources.SourceAvailabilityZoneReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceUuid
        {
            set
            {
                _vmRecoveryPointResources.SourceAvailabilityZoneReference = _vmRecoveryPointResources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPointResources.SourceAvailabilityZoneReference.Uuid = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ClusterReferenceKind
        {
            set
            {
                _vmRecoveryPointResources.SourceClusterReference = _vmRecoveryPointResources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPointResources.SourceClusterReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName
        {
            set
            {
                _vmRecoveryPointResources.SourceClusterReference = _vmRecoveryPointResources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPointResources.SourceClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _vmRecoveryPointResources.SourceClusterReference = _vmRecoveryPointResources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPointResources.SourceClusterReference.Uuid = value;
            }
        }
        /// <summary>
        /// Location agnostic UUID of the recovery point. If a recoverypoint is replicated to a different clusters, then all theinstances
        /// of same recovery point will share this UUID.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Location agnostic UUID of the recovery point. If a recoverypoint is replicated to a different clusters, then all theinstances of same recovery point will share this UUID.")]
        public string VmRecoveryPointLocationAgnosticUuid
        {
            set
            {
                _vmRecoveryPointResources.VmRecoveryPointLocationAgnosticUuid = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string VmReferenceKind
        {
            set
            {
                _vmRecoveryPointResources.ParentVmReference = _vmRecoveryPointResources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPointResources.ParentVmReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string VmReferenceName
        {
            set
            {
                _vmRecoveryPointResources.ParentVmReference = _vmRecoveryPointResources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPointResources.ParentVmReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string VmReferenceUuid
        {
            set
            {
                _vmRecoveryPointResources.ParentVmReference = _vmRecoveryPointResources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPointResources.ParentVmReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmRecoveryPointResources);
        }
    }
}