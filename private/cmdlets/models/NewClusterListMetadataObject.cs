namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterListMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterListMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterListMetadata))]
    public class NewClusterListMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterListMetadata" /></summary>
        private Nutanix.Powershell.Models.IClusterListMetadata _clusterListMetadata = new Nutanix.Powershell.Models.ClusterListMetadata();
        /// <summary>The filter in FIQL syntax used for the results.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The filter in FIQL syntax used for the results.")]
        public string Filter
        {
            set
            {
                _clusterListMetadata.Filter = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _clusterListMetadata.Kind = value;
            }
        }
        /// <summary>The number of records to retrieve relative to the offset</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to retrieve relative to the offset")]
        public int Length
        {
            set
            {
                _clusterListMetadata.Length = value;
            }
        }
        /// <summary>Offset from the start of the entity list</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offset from the start of the entity list")]
        public int Offset
        {
            set
            {
                _clusterListMetadata.Offset = value;
            }
        }
        /// <summary>The attribute to perform sort on</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The attribute to perform sort on")]
        public string SortAttribute
        {
            set
            {
                _clusterListMetadata.SortAttribute = value;
            }
        }
        /// <summary>The sort order in which results are returned</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sort order in which results are returned")]
        public string SortOrder
        {
            set
            {
                _clusterListMetadata.SortOrder = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterListMetadata);
        }
    }
}