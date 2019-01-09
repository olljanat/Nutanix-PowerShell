namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster Configuration.</summary>
    public partial class ClusterConfigSpec : Nutanix.Powershell.Models.IClusterConfigSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="AuthorizedPublicKeyList" /> property.</summary>
        private Nutanix.Powershell.Models.IPublicKey[] _authorizedPublicKeyList;

        /// <summary>List of valid ssh keys for the cluster.</summary>
        public Nutanix.Powershell.Models.IPublicKey[] AuthorizedPublicKeyList
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
        /// <summary>Backing field for <see cref="CertificationSigningInfo" /> property.</summary>
        private Nutanix.Powershell.Models.ICertificationSigningInfo _certificationSigningInfo;

        /// <summary>
        /// Customer information used in Certificate Signing Request for
        /// creating digital certificates.
        /// </summary>
        public Nutanix.Powershell.Models.ICertificationSigningInfo CertificationSigningInfo
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
        /// <summary>Backing field for <see cref="ClientAuth" /> property.</summary>
        private Nutanix.Powershell.Models.IClientAuth _clientAuth;

        /// <summary>Client authentication config.</summary>
        public Nutanix.Powershell.Models.IClientAuth ClientAuth
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
        /// <summary>Backing field for <see cref="EnabledFeatureList" /> property.</summary>
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
        /// <summary>Backing field for <see cref="EncryptionStatus" /> property.</summary>
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
        /// <summary>Backing field for <see cref="ExternalConfigurations" /> property.</summary>
        private Nutanix.Powershell.Models.IExternalConfigurationsSpec _externalConfigurations;

        /// <summary>External Connector Configurations.</summary>
        public Nutanix.Powershell.Models.IExternalConfigurationsSpec ExternalConfigurations
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
        /// <summary>Backing field for <see cref="GpuDriverVersion" /> property.</summary>
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
        /// <summary>Backing field for <see cref="OperationMode" /> property.</summary>
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
        /// <summary>Backing field for <see cref="RedundancyFactor" /> property.</summary>
        private int? _redundancyFactor;

        /// <summary>Cluster supported redundancy factor. Default is 2.</summary>
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
        /// <summary>Backing field for <see cref="SoftwareMap" /> property.</summary>
        private System.Collections.Generic.IDictionary<string,Nutanix.Powershell.Models.IClusterSoftware> _softwareMap;

        /// <summary>
        /// Map of software on the cluster with software type as the
        /// key.
        /// </summary>
        public System.Collections.Generic.IDictionary<string,Nutanix.Powershell.Models.IClusterSoftware> SoftwareMap
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
        /// <summary>Backing field for <see cref="SupportedInformationVerbosity" /> property.</summary>
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
        /// <summary>Backing field for <see cref="Timezone" /> property.</summary>
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
        /// <summary>Creates an new <see cref="ClusterConfigSpec" /> instance.</summary>
        public ClusterConfigSpec()
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
            await eventListener.AssertObjectIsValid(nameof(CertificationSigningInfo), CertificationSigningInfo);
            await eventListener.AssertObjectIsValid(nameof(ClientAuth), ClientAuth);
            await eventListener.AssertObjectIsValid(nameof(ExternalConfigurations), ExternalConfigurations);
        }
    }
    /// Cluster Configuration.
    public partial interface IClusterConfigSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IPublicKey[] AuthorizedPublicKeyList { get; set; }
        Nutanix.Powershell.Models.ICertificationSigningInfo CertificationSigningInfo { get; set; }
        Nutanix.Powershell.Models.IClientAuth ClientAuth { get; set; }
        string[] EnabledFeatureList { get; set; }
        string EncryptionStatus { get; set; }
        Nutanix.Powershell.Models.IExternalConfigurationsSpec ExternalConfigurations { get; set; }
        string GpuDriverVersion { get; set; }
        string OperationMode { get; set; }
        int? RedundancyFactor { get; set; }
        System.Collections.Generic.IDictionary<string,Nutanix.Powershell.Models.IClusterSoftware> SoftwareMap { get; set; }
        string SupportedInformationVerbosity { get; set; }
        string Timezone { get; set; }
    }
}