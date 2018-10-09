namespace Sample.API.Models
{

    /// <summary>
    /// Cluster status definition. A Nutanix cluster is comprised of three or
    /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
    /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
    /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
    /// runs on each node in the cluster. The CVM enables each node to share
    /// local storage from all nodes in the cluster.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterDefStatusTypeConverter))]
    public partial class ClusterDefStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="ClusterDefStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IClusterDefStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cluster status definition. A Nutanix cluster is comprised of three or
    /// more Nutanix nodes. Each node in the cluster contains memory, CPU, RAM,
    /// and storage (SSD/HDD). Each node in the cluster runs standard hypervisor
    /// such as VMware vSphere, Microsoft Hyper-V, or AHV. A Controller VM (CVM)
    /// runs on each node in the cluster. The CVM enables each node to share
    /// local storage from all nodes in the cluster.
    [System.ComponentModel.TypeConverter(typeof(ClusterDefStatusTypeConverter))]
    public partial interface IClusterDefStatus {

    }
}