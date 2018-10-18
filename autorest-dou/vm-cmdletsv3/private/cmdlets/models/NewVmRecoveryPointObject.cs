namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmRecoveryPoint" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmRecoveryPointObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmRecoveryPoint))]
    public class NewVmRecoveryPointObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmRecoveryPoint" /></summary>
        private Sample.API.Models.IVmRecoveryPoint _vmRecoveryPoint = new Sample.API.Models.VmRecoveryPoint();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string AvailabilityZoneReferenceKind
        {
            set
            {
                _vmRecoveryPoint.AvailabilityZoneReference = _vmRecoveryPoint.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.AvailabilityZoneReference.Kind = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string AvailabilityZoneReferenceKind1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference = _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceName
        {
            set
            {
                _vmRecoveryPoint.AvailabilityZoneReference = _vmRecoveryPoint.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.AvailabilityZoneReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceName1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference = _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceUuid
        {
            set
            {
                _vmRecoveryPoint.AvailabilityZoneReference = _vmRecoveryPoint.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.AvailabilityZoneReference.Uuid = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceUuid1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference = _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vmRecoveryPoint.Resources.SourceAvailabilityZoneReference.Uuid = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ClusterReferenceKind
        {
            set
            {
                _vmRecoveryPoint.ClusterReference = _vmRecoveryPoint.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.ClusterReference.Kind = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ClusterReferenceKind1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceClusterReference = _vmRecoveryPoint.Resources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.Resources.SourceClusterReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName
        {
            set
            {
                _vmRecoveryPoint.ClusterReference = _vmRecoveryPoint.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.ClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceClusterReference = _vmRecoveryPoint.Resources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.Resources.SourceClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _vmRecoveryPoint.ClusterReference = _vmRecoveryPoint.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.ClusterReference.Uuid = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid1
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.SourceClusterReference = _vmRecoveryPoint.Resources.SourceClusterReference ?? new Sample.API.Models.ClusterReference();
                _vmRecoveryPoint.Resources.SourceClusterReference.Uuid = value;
            }
        }
        /// <summary>
        /// The time when the the recovery point is created. This is in internetdate/time format (RFC 3339). For example, 1985-04-12T23:20:50.52Z,this
        /// represents 20 minutes and 50.52 seconds after the 23rd hour ofApril 12th, 1985 in UTC.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The time when the the recovery point is created. This is in internetdate/time format (RFC 3339). For example, 1985-04-12T23:20:50.52Z,this represents 20 minutes and 50.52 seconds after the 23rd hour ofApril 12th, 1985 in UTC.")]
        public System.DateTime CreationTime
        {
            set
            {
                _vmRecoveryPoint.CreationTime = value;
            }
        }
        /// <summary>
        /// The time when this recovery point expires and will be garbagecollected. This is in internet date/time format (RFC 3339).
        /// Forexample, 1985-04-12T23:20:50.52Z, this represents 20 minutes and50.52 seconds after the 23rd hour of April 12th, 1985
        /// in UTC. If notset, then the recovery point never expires.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The time when this recovery point expires and will be garbagecollected. This is in internet date/time format (RFC 3339). Forexample, 1985-04-12T23:20:50.52Z, this represents 20 minutes and50.52 seconds after the 23rd hour of April 12th, 1985 in UTC. If notset, then the recovery point never expires.")]
        public System.DateTime ExpirationTime
        {
            set
            {
                _vmRecoveryPoint.ExpirationTime = value;
            }
        }
        /// <summary>Name of the recovery point.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the recovery point.")]
        public string Name
        {
            set
            {
                _vmRecoveryPoint.Name = value;
            }
        }
        /// <summary>Crash consistent or Application Consistent recovery point</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Crash consistent or Application Consistent recovery point")]
        public string RecoveryPointType
        {
            set
            {
                _vmRecoveryPoint.RecoveryPointType = value;
            }
        }
        /// <summary>
        /// Location agnostic UUID of the recovery point. If a recoverypoint is replicated to a different clusters, then all theinstances
        /// of same recovery point will share this UUID.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Location agnostic UUID of the recovery point. If a recoverypoint is replicated to a different clusters, then all theinstances of same recovery point will share this UUID.")]
        public string VmRecoveryPointResourcesVmRecoveryPointLocationAgnosticUuid
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.VmRecoveryPointLocationAgnosticUuid = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string VmReferenceKind
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.ParentVmReference = _vmRecoveryPoint.Resources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPoint.Resources.ParentVmReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string VmReferenceName
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.ParentVmReference = _vmRecoveryPoint.Resources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPoint.Resources.ParentVmReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string VmReferenceUuid
        {
            set
            {
                _vmRecoveryPoint.Resources = _vmRecoveryPoint.Resources ?? new Sample.API.Models.VmRecoveryPointResources();
                _vmRecoveryPoint.Resources.ParentVmReference = _vmRecoveryPoint.Resources.ParentVmReference ?? new Sample.API.Models.VmReference();
                _vmRecoveryPoint.Resources.ParentVmReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmRecoveryPoint);
        }
    }
}