namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cluster domain server. Only applied to the cluster with all Hyper-V hosts.
    /// </summary>
    public partial class ClusterDomainServer : Sample.API.Models.IClusterDomainServer, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for DomainCredentials property</summary>
        private Sample.API.Models.ICredentials _domainCredentials;

        /// <summary>Credentials to login server</summary>
        public Sample.API.Models.ICredentials DomainCredentials
        {
            get
            {
                return this._domainCredentials;
            }
            set
            {
                this._domainCredentials = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>
        /// Joined domain name. In 'put' request, empty name will unjoin the
        /// cluster from current domain.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Nameserver property</summary>
        private string _nameserver;

        /// <summary>
        /// The IP of the nameserver that can resolve the domain name. Must set
        /// when joining the domain.
        /// </summary>
        public string Nameserver
        {
            get
            {
                return this._nameserver;
            }
            set
            {
                this._nameserver = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterDomainServer" /> instance.</summary>
        public ClusterDomainServer()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertObjectIsValid(nameof(DomainCredentials), DomainCredentials);
        }
    }
    /// Cluster domain server. Only applied to the cluster with all Hyper-V hosts.
    public partial interface IClusterDomainServer : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.ICredentials DomainCredentials { get; set; }
        string Name { get; set; }
        string Nameserver { get; set; }
    }
}