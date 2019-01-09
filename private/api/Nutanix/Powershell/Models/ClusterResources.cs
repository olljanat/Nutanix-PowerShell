namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster resources.</summary>
    public partial class ClusterResources : Nutanix.Powershell.Models.IClusterResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Config" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterConfigSpec _config;

        /// <summary>Cluster Configuration.</summary>
        public Nutanix.Powershell.Models.IClusterConfigSpec Config
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
        /// <summary>Backing field for <see cref="RuntimeStatusList" /> property.</summary>
        private string[] _runtimeStatusList;

        /// <summary>Cluster onging operations.</summary>
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
        /// <summary>Creates an new <see cref="ClusterResources" /> instance.</summary>
        public ClusterResources()
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
            await eventListener.AssertObjectIsValid(nameof(Config), Config);
            await eventListener.AssertObjectIsValid(nameof(Network), Network);
        }
    }
    /// Cluster resources.
    public partial interface IClusterResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IClusterConfigSpec Config { get; set; }
        Nutanix.Powershell.Models.IClusterNetwork Network { get; set; }
        string[] RuntimeStatusList { get; set; }
    }
}