namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster software.</summary>
    public partial class ClusterSoftware : Nutanix.Powershell.Models.IClusterSoftware, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="SoftwareType" /> property.</summary>
        private string _softwareType;

        /// <summary>Software type</summary>
        public string SoftwareType
        {
            get
            {
                return this._softwareType;
            }
            set
            {
                this._softwareType = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Current software status.</summary>
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterSoftware" /> instance.</summary>
        public ClusterSoftware()
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
            await eventListener.AssertNotNull(nameof(SoftwareType),SoftwareType);
            await eventListener.AssertNotNull(nameof(Version),Version);
        }
    }
    /// Cluster software.
    public partial interface IClusterSoftware : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string SoftwareType { get; set; }
        string Status { get; set; }
        string Version { get; set; }
    }
}