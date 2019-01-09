namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterResources))]
    public class NewClusterResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterResources" /></summary>
        private Nutanix.Powershell.Models.IClusterResources _clusterResources = new Nutanix.Powershell.Models.ClusterResources();
        /// <summary>Cluster Configuration.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster Configuration.")]
        public Nutanix.Powershell.Models.IClusterConfigSpec Config
        {
            set
            {
                _clusterResources.Config = value;
            }
        }
        /// <summary>Cluster network.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster network.")]
        public Nutanix.Powershell.Models.IClusterNetwork Network
        {
            set
            {
                _clusterResources.Network = value;
            }
        }
        /// <summary>Cluster onging operations.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster onging operations.")]
        public string[] RuntimeStatusList
        {
            set
            {
                _clusterResources.RuntimeStatusList = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterResources);
        }
    }
}