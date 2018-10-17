namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmSnapshotResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmSnapshotResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmSnapshotResources))]
    public class NewVmSnapshotResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmSnapshotResources" /></summary>
        private Sample.API.Models.IVmSnapshotResources _vmSnapshotResources = new Sample.API.Models.VmSnapshotResources();
        /// <summary>UUID of the base entity for which snapshot need to be taken</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UUID of the base entity for which snapshot need to be taken")]
        public string EntityUuid
        {
            set
            {
                _vmSnapshotResources.EntityUuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmSnapshotResources);
        }
    }
}