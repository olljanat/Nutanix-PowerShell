namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterConfigSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterConfigSpecObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterConfigSpec))]
    public class NewClusterConfigSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterConfigSpec" /></summary>
        private Nutanix.Powershell.Models.IClusterConfigSpec _clusterConfigSpec = new Nutanix.Powershell.Models.ClusterConfigSpec();
        /// <summary>List of valid ssh keys for the cluster.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of valid ssh keys for the cluster.")]
        public Nutanix.Powershell.Models.IPublicKey[] AuthorizedPublicKeyList
        {
            set
            {
                _clusterConfigSpec.AuthorizedPublicKeyList = value;
            }
        }
        /// <summary>
        /// Customer information used in Certificate Signing Request forcreating digital certificates.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Customer information used in Certificate Signing Request forcreating digital certificates.")]
        public Nutanix.Powershell.Models.ICertificationSigningInfo CertificationSigningInfo
        {
            set
            {
                _clusterConfigSpec.CertificationSigningInfo = value;
            }
        }
        /// <summary>Content of CA chain certificate.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Content of CA chain certificate.")]
        public byte[] ClientAuthCaChain
        {
            set
            {
                _clusterConfigSpec.ClientAuth = _clusterConfigSpec.ClientAuth ?? new Nutanix.Powershell.Models.ClientAuth();
                _clusterConfigSpec.ClientAuth.CaChain = value;
            }
        }
        /// <summary>Name of CA chain file.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of CA chain file.")]
        public string ClientAuthName
        {
            set
            {
                _clusterConfigSpec.ClientAuth = _clusterConfigSpec.ClientAuth ?? new Nutanix.Powershell.Models.ClientAuth();
                _clusterConfigSpec.ClientAuth.Name = value;
            }
        }
        /// <summary>Status of client authentication.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Status of client authentication.")]
        public string ClientAuthStatus
        {
            set
            {
                _clusterConfigSpec.ClientAuth = _clusterConfigSpec.ClientAuth ?? new Nutanix.Powershell.Models.ClientAuth();
                _clusterConfigSpec.ClientAuth.Status = value;
            }
        }
        /// <summary>Array of enabled features.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Array of enabled features.")]
        public string[] EnabledFeatureList
        {
            set
            {
                _clusterConfigSpec.EnabledFeatureList = value;
            }
        }
        /// <summary>Cluster encryption status.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster encryption status.")]
        public string EncryptionStatus
        {
            set
            {
                _clusterConfigSpec.EncryptionStatus = value;
            }
        }
        /// <summary>Citrix Connector details.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Citrix Connector details.")]
        public Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec ExternalConfigurationsSpecCitrixConnectorConfig
        {
            set
            {
                _clusterConfigSpec.ExternalConfigurations = _clusterConfigSpec.ExternalConfigurations ?? new Nutanix.Powershell.Models.ExternalConfigurationsSpec();
                _clusterConfigSpec.ExternalConfigurations.CitrixConnectorConfig = value;
            }
        }
        /// <summary>GPU driver version.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "GPU driver version.")]
        public string GpuDriverVersion
        {
            set
            {
                _clusterConfigSpec.GpuDriverVersion = value;
            }
        }
        /// <summary>
        /// Cluster operation mode. - 'NORMAL': Cluster is operating normally. - 'READ_ONLY': Cluster is operating in read only mode.
        /// - 'STAND_ALONE': Only one node is operational in the cluster. This is valid only for single node or two node clusters.-
        /// 'SWITCH_TO_TWO_NODE': Cluster is moving from single node to two node cluster.- 'OVERRIDE': Valid only for single node
        /// cluster. If the user wants to run vms on a single node cluster in read only mode, he can set the cluster peration mode
        /// to override. Writes will be allowed in override mode.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster operation mode. - 'NORMAL': Cluster is operating normally. - 'READ_ONLY': Cluster is operating in read only mode. - 'STAND_ALONE': Only one node is operational in the cluster. This is valid only for single node or two node clusters.- 'SWITCH_TO_TWO_NODE': Cluster is moving from single node to two node cluster.- 'OVERRIDE': Valid only for single node cluster. If the user wants to run vms on a single node cluster in read only mode, he can set the cluster peration mode to override. Writes will be allowed in override mode.")]
        public string OperationMode
        {
            set
            {
                _clusterConfigSpec.OperationMode = value;
            }
        }
        /// <summary>Cluster supported redundancy factor. Default is 2.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Cluster supported redundancy factor. Default is 2.")]
        public int RedundancyFactor
        {
            set
            {
                _clusterConfigSpec.RedundancyFactor = value;
            }
        }
        /// <summary>Map of software on the cluster with software type as thekey.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Map of software on the cluster with software type as thekey.")]
        public System.Collections.Generic.IDictionary<string,Nutanix.Powershell.Models.IClusterSoftware> SoftwareMap
        {
            set
            {
                _clusterConfigSpec.SoftwareMap = value;
            }
        }
        /// <summary>
        /// Verbosity level settings for populating support information.- 'Nothing': Send nothing- 'Basic': Send basic information
        /// - skip core dump and hypervisor stats information- 'BasicPlusCoreDump': Send basic and core dump information- 'All': Send
        /// all information
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Verbosity level settings for populating support information.- 'Nothing': Send nothing- 'Basic': Send basic information - skip core dump and hypervisor stats information- 'BasicPlusCoreDump': Send basic and core dump information- 'All': Send all information")]
        public string SupportedInformationVerbosity
        {
            set
            {
                _clusterConfigSpec.SupportedInformationVerbosity = value;
            }
        }
        /// <summary>Zone name used in value of TZ environment variable.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Zone name used in value of TZ environment variable.")]
        public string Timezone
        {
            set
            {
                _clusterConfigSpec.Timezone = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_clusterConfigSpec);
        }
    }
}