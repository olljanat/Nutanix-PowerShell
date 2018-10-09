namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster Configuration.</summary>
    public partial class ClusterConfig : Sample.API.Models.IClusterConfig, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AuthorizedPublicKeyList property</summary>
        private Sample.API.Models.IPublicKey[] _authorizedPublicKeyList;

        /// <summary>List of valid ssh keys for the cluster.</summary>
        public Sample.API.Models.IPublicKey[] AuthorizedPublicKeyList
        {
            get
            {
                return this._authorizedPublicKeyList;
            }
            set
            {
                this._authorizedPublicKeyList = value;
            }
        }
        /// <summary>Backing field for Build property</summary>
        private Sample.API.Models.IBuildInfo _build;

        /// <summary>Cluster build details.</summary>
        public Sample.API.Models.IBuildInfo Build
        {
            get
            {
                return this._build;
            }
            set
            {
                this._build = value;
            }
        }
        /// <summary>Backing field for CaCertificateList property</summary>
        private Sample.API.Models.ICaCert[] _caCertificateList;

        /// <summary>List of cluster trusted CA certificates.</summary>
        public Sample.API.Models.ICaCert[] CaCertificateList
        {
            get
            {
                return this._caCertificateList;
            }
            set
            {
                this._caCertificateList = value;
            }
        }
        /// <summary>Backing field for CertificationSigningInfo property</summary>
        private Sample.API.Models.ICertificationSigningInfo _certificationSigningInfo;

        /// <summary>
        /// Customer information used in Certificate Signing Request for
        /// creating digital certificates.
        /// </summary>
        public Sample.API.Models.ICertificationSigningInfo CertificationSigningInfo
        {
            get
            {
                return this._certificationSigningInfo;
            }
            set
            {
                this._certificationSigningInfo = value;
            }
        }
        /// <summary>Backing field for ClientAuth property</summary>
        private Sample.API.Models.IClientAuth _clientAuth;

        /// <summary>Client authentication config.</summary>
        public Sample.API.Models.IClientAuth ClientAuth
        {
            get
            {
                return this._clientAuth;
            }
            set
            {
                this._clientAuth = value;
            }
        }
        /// <summary>Backing field for ClusterArch property</summary>
        private string _clusterArch;

        /// <summary>Cluster architecture.</summary>
        public string ClusterArch
        {
            get
            {
                return this._clusterArch;
            }
            set
            {
                this._clusterArch = value;
            }
        }
        /// <summary>Backing field for EnabledFeatureList property</summary>
        private string[] _enabledFeatureList;

        /// <summary>Array of enabled features.</summary>
        public string[] EnabledFeatureList
        {
            get
            {
                return this._enabledFeatureList;
            }
            set
            {
                this._enabledFeatureList = value;
            }
        }
        /// <summary>Backing field for EncryptionStatus property</summary>
        private string _encryptionStatus;

        /// <summary>Cluster encryption status.</summary>
        public string EncryptionStatus
        {
            get
            {
                return this._encryptionStatus;
            }
            set
            {
                this._encryptionStatus = value;
            }
        }
        /// <summary>Backing field for ExternalConfigurations property</summary>
        private Sample.API.Models.IExternalConfigurations _externalConfigurations;

        /// <summary>External Connector Configurations.</summary>
        public Sample.API.Models.IExternalConfigurations ExternalConfigurations
        {
            get
            {
                return this._externalConfigurations;
            }
            set
            {
                this._externalConfigurations = value;
            }
        }
        /// <summary>Backing field for GpuDriverVersion property</summary>
        private string _gpuDriverVersion;

        /// <summary>GPU driver version.</summary>
        public string GpuDriverVersion
        {
            get
            {
                return this._gpuDriverVersion;
            }
            set
            {
                this._gpuDriverVersion = value;
            }
        }
        /// <summary>Backing field for IsAvailable property</summary>
        private bool? _isAvailable;

        /// <summary>Indicates if cluster is available to contact.</summary>
        public bool? IsAvailable
        {
            get
            {
                return this._isAvailable;
            }
            set
            {
                this._isAvailable = value;
            }
        }
        /// <summary>Backing field for ManagementServerList property</summary>
        private Sample.API.Models.IClusterManagementServer[] _managementServerList;

        /// <summary>List of cluster management servers.</summary>
        public Sample.API.Models.IClusterManagementServer[] ManagementServerList
        {
            get
            {
                return this._managementServerList;
            }
            set
            {
                this._managementServerList = value;
            }
        }
        /// <summary>Backing field for OperationMode property</summary>
        private string _operationMode;

        /// <summary>
        /// Cluster operation mode. - 'NORMAL': Cluster is operating normally. - 'READ_ONLY': Cluster is operating in read only mode.
        /// - 'STAND_ALONE': Only one node is operational in the cluster. This is
        /// valid only for single node or two node clusters.
        /// - 'SWITCH_TO_TWO_NODE': Cluster is moving from single node to two node
        /// cluster.
        /// - 'OVERRIDE': Valid only for single node cluster. If the user wants to
        /// run vms on a single node cluster in read only mode, he
        /// can set the cluster peration mode to override. Writes
        /// will be allowed in override mode.
        /// </summary>
        public string OperationMode
        {
            get
            {
                return this._operationMode;
            }
            set
            {
                this._operationMode = value;
            }
        }
        /// <summary>Backing field for RedundancyFactor property</summary>
        private int? _redundancyFactor;

        /// <summary>Cluster supported redundancy factor.</summary>
        public int? RedundancyFactor
        {
            get
            {
                return this._redundancyFactor;
            }
            set
            {
                this._redundancyFactor = value;
            }
        }
        /// <summary>Backing field for ServiceList property</summary>
        private string[] _serviceList;

        /// <summary>
        /// Array of enabled cluster services. For example, a cluster can function
        /// as both AOS and cloud data gateway.
        /// - 'AOS': Regular Prism Element
        /// - 'PRISM_CENTRAL': Prism Central
        /// - 'CLOUD_DATA_GATEWAY': Cloud backup and DR gateway
        /// - 'AFS': Cluster for file server
        /// - 'WITNESS' : Witness cluster
        /// - 'XI_PORTAL': Xi cluster
        /// - 'ONE_NODE_CLUSTER': Single node backup cluster
        /// - 'TWO_NODE_CLUSTER': Two node cluster
        /// </summary>
        public string[] ServiceList
        {
            get
            {
                return this._serviceList;
            }
            set
            {
                this._serviceList = value;
            }
        }
        /// <summary>Backing field for SoftwareMap property</summary>
        private System.Collections.Generic.IDictionary<string,Sample.API.Models.IClusterSoftware> _softwareMap;

        /// <summary>
        /// Map of software on the cluster with software type as the
        /// key.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,Sample.API.Models.IClusterSoftware> SoftwareMap
        {
            get
            {
                return this._softwareMap;
            }
            set
            {
                this._softwareMap = value;
            }
        }
        /// <summary>Backing field for SslKey property</summary>
        private Sample.API.Models.ISslKey _sslKey;

        /// <summary>SSL certificate.</summary>
        public Sample.API.Models.ISslKey SslKey
        {
            get
            {
                return this._sslKey;
            }
            set
            {
                this._sslKey = value;
            }
        }
        /// <summary>Backing field for SupportedInformationVerbosity property</summary>
        private string _supportedInformationVerbosity;

        /// <summary>
        /// Verbosity level settings for populating support information.
        /// - 'Nothing': Send nothing
        /// - 'Basic': Send basic information - skip core dump and hypervisor
        /// stats information
        /// - 'BasicPlusCoreDump': Send basic and core dump information
        /// - 'All': Send all information
        /// </summary>
        public string SupportedInformationVerbosity
        {
            get
            {
                return this._supportedInformationVerbosity;
            }
            set
            {
                this._supportedInformationVerbosity = value;
            }
        }
        /// <summary>Backing field for Timezone property</summary>
        private string _timezone;

        /// <summary>Zone name used in value of TZ environment variable.</summary>
        public string Timezone
        {
            get
            {
                return this._timezone;
            }
            set
            {
                this._timezone = value;
            }
        }
        /// <summary>Creates an new <see cref="ClusterConfig" /> instance.</summary>
        public ClusterConfig()
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
            if (AuthorizedPublicKeyList != null ) {
                    for (int __i = 0; __i < AuthorizedPublicKeyList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"AuthorizedPublicKeyList[{__i}]", AuthorizedPublicKeyList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Build), Build);
            if (CaCertificateList != null ) {
                    for (int __i = 0; __i < CaCertificateList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"CaCertificateList[{__i}]", CaCertificateList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(CertificationSigningInfo), CertificationSigningInfo);
            await eventListener.AssertObjectIsValid(nameof(ClientAuth), ClientAuth);
            await eventListener.AssertObjectIsValid(nameof(ExternalConfigurations), ExternalConfigurations);
            if (ManagementServerList != null ) {
                    for (int __i = 0; __i < ManagementServerList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ManagementServerList[{__i}]", ManagementServerList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(SslKey), SslKey);
        }
    }
    /// Cluster Configuration.
    public partial interface IClusterConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IPublicKey[] AuthorizedPublicKeyList { get; set; }
        Sample.API.Models.IBuildInfo Build { get; set; }
        Sample.API.Models.ICaCert[] CaCertificateList { get; set; }
        Sample.API.Models.ICertificationSigningInfo CertificationSigningInfo { get; set; }
        Sample.API.Models.IClientAuth ClientAuth { get; set; }
        string ClusterArch { get; set; }
        string[] EnabledFeatureList { get; set; }
        string EncryptionStatus { get; set; }
        Sample.API.Models.IExternalConfigurations ExternalConfigurations { get; set; }
        string GpuDriverVersion { get; set; }
        bool? IsAvailable { get; set; }
        Sample.API.Models.IClusterManagementServer[] ManagementServerList { get; set; }
        string OperationMode { get; set; }
        int? RedundancyFactor { get; set; }
        string[] ServiceList { get; set; }
        System.Collections.Generic.IDictionary<string,Sample.API.Models.IClusterSoftware> SoftwareMap { get; set; }
        Sample.API.Models.ISslKey SslKey { get; set; }
        string SupportedInformationVerbosity { get; set; }
        string Timezone { get; set; }
    }
}