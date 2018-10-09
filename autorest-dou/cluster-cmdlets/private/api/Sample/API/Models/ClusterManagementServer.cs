namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster Management server information.</summary>
    public partial class ClusterManagementServer : Sample.API.Models.IClusterManagementServer, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DrsEnabled property</summary>
        private bool? _drsEnabled;

        /// <summary>Denotes if DRS is enabled or not.</summary>
        public bool? DrsEnabled
        {
            get
            {
                return this._drsEnabled;
            }
            set
            {
                this._drsEnabled = value;
            }
        }
        /// <summary>Backing field for Ip property</summary>
        private string _ip;

        public string Ip
        {
            get
            {
                return this._ip;
            }
            set
            {
                this._ip = value;
            }
        }
        /// <summary>Backing field for StatusList property</summary>
        private string[] _statusList;

        /// <summary>
        /// Array of management server status: - 'REGISTERED': Indicates whether the server is registered with
        /// Nutanix or not.
        /// - 'IN_USE': Indicates whether any host is managed by this server or
        /// not.
        /// </summary>
        public string[] StatusList
        {
            get
            {
                return this._statusList;
            }
            set
            {
                this._statusList = value;
            }
        }
        /// <summary>Backing field for Type property</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterManagementServer" /> instance.</summary>
        public ClusterManagementServer()
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
            await eventListener.AssertNotNull(nameof(Type),Type);
            await eventListener.AssertNotNull(nameof(Ip),Ip);
            await eventListener.AssertRegEx(nameof(Ip),Ip,@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        }
    }
    /// Cluster Management server information.
    public partial interface IClusterManagementServer : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        bool? DrsEnabled { get; set; }
        string Ip { get; set; }
        string[] StatusList { get; set; }
        string Type { get; set; }
    }
}