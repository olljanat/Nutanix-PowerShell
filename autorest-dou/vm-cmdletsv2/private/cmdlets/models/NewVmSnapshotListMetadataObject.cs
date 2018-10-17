namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmSnapshotListMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmSnapshotListMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmSnapshotListMetadata))]
    public class NewVmSnapshotListMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmSnapshotListMetadata" /></summary>
        private Sample.API.Models.IVmSnapshotListMetadata _vmSnapshotListMetadata = new Sample.API.Models.VmSnapshotListMetadata();
        /// <summary>The filter in FIQL syntax used for the results.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The filter in FIQL syntax used for the results.")]
        public string Filter
        {
            set
            {
                _vmSnapshotListMetadata.Filter = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _vmSnapshotListMetadata.Kind = value;
            }
        }
        /// <summary>The number of records to retrieve relative to the offset</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to retrieve relative to the offset")]
        public int Length
        {
            set
            {
                _vmSnapshotListMetadata.Length = value;
            }
        }
        /// <summary>Offset from the start of the entity list</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offset from the start of the entity list")]
        public int Offset
        {
            set
            {
                _vmSnapshotListMetadata.Offset = value;
            }
        }
        /// <summary>The attribute to perform sort on</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The attribute to perform sort on")]
        public string SortAttribute
        {
            set
            {
                _vmSnapshotListMetadata.SortAttribute = value;
            }
        }
        /// <summary>The sort order in which results are returned</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sort order in which results are returned")]
        public string SortOrder
        {
            set
            {
                _vmSnapshotListMetadata.SortOrder = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmSnapshotListMetadata);
        }
    }
}