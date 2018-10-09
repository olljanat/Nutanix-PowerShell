namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster analysis related values.</summary>
    public partial class ClusterAnalysis : Sample.API.Models.IClusterAnalysis
    {
        /// <summary>Backing field for VmEfficiencyMap property</summary>
        private System.Collections.Generic.IDictionary<string,string> _vmEfficiencyMap;

        /// <summary>
        /// Map of cluster efficiency which includes numbers of inefficient
        /// vms. The value is populated by analytics on PC.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,string> VmEfficiencyMap
        {
            get
            {
                return this._vmEfficiencyMap;
            }
            set
            {
                this._vmEfficiencyMap = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterAnalysis" /> instance.</summary>
        public ClusterAnalysis()
        {
        }
    }
    /// Cluster analysis related values.
    public partial interface IClusterAnalysis : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.IDictionary<string,string> VmEfficiencyMap { get; set; }
    }
}