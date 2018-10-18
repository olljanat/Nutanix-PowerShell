namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="VmSnapshot" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmSnapshotObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmSnapshot))]
    public class NewVmSnapshotObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmSnapshot" /></summary>
        private Sample.API.Models.IVmSnapshot _vmSnapshot = new Sample.API.Models.VmSnapshot();
        /// <summary>
        /// The time when this snapshot expires and will be garbage collected.If not set, then the snapshot never expires.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The time when this snapshot expires and will be garbage collected.If not set, then the snapshot never expires.")]
        public int ExpirationTimeMsecs
        {
            set
            {
                _vmSnapshot.ExpirationTimeMsecs = value;
            }
        }
        /// <summary>Name of the snapshot</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the snapshot")]
        public string Name
        {
            set
            {
                _vmSnapshot.Name = value;
            }
        }
        /// <summary>
        /// This describes a list replication targets where this snapshot existsor needs to be replicated to. This is to support the
        /// replication andretrieve of the snapshot.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "This describes a list replication targets where this snapshot existsor needs to be replicated to. This is to support the replication andretrieve of the snapshot.")]
        public Sample.API.Models.IVmSnapshotReplicationTargetListItemType[] ReplicationTargetList
        {
            set
            {
                _vmSnapshot.ReplicationTargetList = value;
            }
        }
        /// <summary>Crash consistent or Application Consistent snapshot</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Crash consistent or Application Consistent snapshot")]
        public string SnapshotType
        {
            set
            {
                _vmSnapshot.SnapshotType = value;
            }
        }
        /// <summary>UUID of the base entity for which snapshot need to be taken</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UUID of the base entity for which snapshot need to be taken")]
        public string VmSnapshotResourcesEntityUuid
        {
            set
            {
                _vmSnapshot.Resources = _vmSnapshot.Resources ?? new Sample.API.Models.VmSnapshotResources();
                _vmSnapshot.Resources.EntityUuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmSnapshot);
        }
    }
}