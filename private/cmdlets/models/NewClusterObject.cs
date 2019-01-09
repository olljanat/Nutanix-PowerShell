namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Cluster" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICluster))]
    public class NewClusterObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Cluster" /></summary>
        private Nutanix.Powershell.Models.ICluster _cluster = new Nutanix.Powershell.Models.Cluster();
        /// <summary>Cluster Configuration.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster Configuration.")]
        public Nutanix.Powershell.Models.IClusterConfigSpec ClusterResourcesConfig
        {
            set
            {
                _cluster.Resources = _cluster.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _cluster.Resources.Config = value;
            }
        }
        /// <summary>Cluster network.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster network.")]
        public Nutanix.Powershell.Models.IClusterNetwork ClusterResourcesNetwork
        {
            set
            {
                _cluster.Resources = _cluster.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _cluster.Resources.Network = value;
            }
        }
        /// <summary>Cluster onging operations.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster onging operations.")]
        public string[] ClusterResourcesRuntimeStatusList
        {
            set
            {
                _cluster.Resources = _cluster.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _cluster.Resources.RuntimeStatusList = value;
            }
        }
        /// <summary>Cluster Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster Name.")]
        public string Name
        {
            set
            {
                _cluster.Name = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_cluster);
        }
    }
}