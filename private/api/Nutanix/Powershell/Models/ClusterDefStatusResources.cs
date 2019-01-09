namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster resources.</summary>
    public partial class ClusterDefStatusResources : Nutanix.Powershell.Models.IClusterDefStatusResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Analysis" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterAnalysis _analysis;

        /// <summary>Cluster analysis related values.</summary>
        public Nutanix.Powershell.Models.IClusterAnalysis Analysis
        {
            get
            {
                return this._analysis;
            }
            set
            {
                this._analysis = value;
            }
        }
        /// <summary>Backing field for <see cref="Config" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterConfig _config;

        /// <summary>Cluster Configuration.</summary>
        public Nutanix.Powershell.Models.IClusterConfig Config
        {
            get
            {
                return this._config;
            }
            set
            {
                this._config = value;
            }
        }
        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterNetwork _network;

        /// <summary>Cluster network.</summary>
        public Nutanix.Powershell.Models.IClusterNetwork Network
        {
            get
            {
                return this._network;
            }
            set
            {
                this._network = value;
            }
        }
        /// <summary>Backing field for <see cref="Nodes" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterNodes _nodes;

        /// <summary>Node info for this cluster.</summary>
        public Nutanix.Powershell.Models.IClusterNodes Nodes
        {
            get
            {
                return this._nodes;
            }
            set
            {
                this._nodes = value;
            }
        }
        /// <summary>Backing field for <see cref="RuntimeStatusList" /> property.</summary>
        private string[] _runtimeStatusList;

        /// <summary>Cluster current attributes and onging operations.</summary>
        public string[] RuntimeStatusList
        {
            get
            {
                return this._runtimeStatusList;
            }
            set
            {
                this._runtimeStatusList = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterDefStatusResources" /> instance.</summary>
        public ClusterDefStatusResources()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(Analysis), Analysis);
            await eventListener.AssertNotNull(nameof(Config), Config);
            await eventListener.AssertObjectIsValid(nameof(Config), Config);
            await eventListener.AssertNotNull(nameof(Network), Network);
            await eventListener.AssertObjectIsValid(nameof(Network), Network);
            await eventListener.AssertObjectIsValid(nameof(Nodes), Nodes);
        }
    }
    /// Cluster resources.
    public partial interface IClusterDefStatusResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IClusterAnalysis Analysis { get; set; }
        Nutanix.Powershell.Models.IClusterConfig Config { get; set; }
        Nutanix.Powershell.Models.IClusterNetwork Network { get; set; }
        Nutanix.Powershell.Models.IClusterNodes Nodes { get; set; }
        string[] RuntimeStatusList { get; set; }
    }
}