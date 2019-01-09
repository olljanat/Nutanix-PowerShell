namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterIntentInput))]
    public class NewClusterIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterIntentInput" /></summary>
        private Nutanix.Powershell.Models.IClusterIntentInput _clusterIntentInput = new Nutanix.Powershell.Models.ClusterIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ApiVersion
        {
            set
            {
                _clusterIntentInput.ApiVersion = value;
            }
        }
        /// <summary>Cluster Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster Name.")]
        public string ClusterName
        {
            set
            {
                _clusterIntentInput.Spec = _clusterIntentInput.Spec ?? new Nutanix.Powershell.Models.Cluster();
                _clusterIntentInput.Spec.Name = value;
            }
        }
        /// <summary>Cluster Configuration.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster Configuration.")]
        public Nutanix.Powershell.Models.IClusterConfigSpec ClusterResourcesConfig
        {
            set
            {
                _clusterIntentInput.Spec = _clusterIntentInput.Spec ?? new Nutanix.Powershell.Models.Cluster();
                _clusterIntentInput.Spec.Resources = _clusterIntentInput.Spec.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _clusterIntentInput.Spec.Resources.Config = value;
            }
        }
        /// <summary>Cluster network.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster network.")]
        public Nutanix.Powershell.Models.IClusterNetwork ClusterResourcesNetwork
        {
            set
            {
                _clusterIntentInput.Spec = _clusterIntentInput.Spec ?? new Nutanix.Powershell.Models.Cluster();
                _clusterIntentInput.Spec.Resources = _clusterIntentInput.Spec.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _clusterIntentInput.Spec.Resources.Network = value;
            }
        }
        /// <summary>Cluster onging operations.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster onging operations.")]
        public string[] ClusterResourcesRuntimeStatusList
        {
            set
            {
                _clusterIntentInput.Spec = _clusterIntentInput.Spec ?? new Nutanix.Powershell.Models.Cluster();
                _clusterIntentInput.Spec.Resources = _clusterIntentInput.Spec.Resources ?? new Nutanix.Powershell.Models.ClusterResources();
                _clusterIntentInput.Spec.Resources.RuntimeStatusList = value;
            }
        }
        /// <summary>The cluster kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The cluster kind metadata")]
        public Nutanix.Powershell.Models.IClusterMetadata Metadata
        {
            set
            {
                _clusterIntentInput.Metadata = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterIntentInput);
        }
    }
}