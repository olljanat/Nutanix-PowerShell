namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkSecurityRuleMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkSecurityRuleMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INetworkSecurityRuleMetadata))]
    public class NewNetworkSecurityRuleMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkSecurityRuleMetadata" /></summary>
        private Sample.API.Models.INetworkSecurityRuleMetadata _networkSecurityRuleMetadata = new Sample.API.Models.NetworkSecurityRuleMetadata();
        /// <summary>Categories for the network_security_rule</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Categories for the network_security_rule")]
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            set
            {
                _networkSecurityRuleMetadata.Categories = value;
            }
        }
        /// <summary>UTC date and time in RFC-3339 format when network_security_rule was created</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when network_security_rule was created")]
        public System.DateTime CreationTime
        {
            set
            {
                _networkSecurityRuleMetadata.CreationTime = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _networkSecurityRuleMetadata.Kind = value;
            }
        }
        /// <summary>
        /// UTC date and time in RFC-3339 format when network_security_rule was last updated
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UTC date and time in RFC-3339 format when network_security_rule was last updated")]
        public System.DateTime LastUpdateTime
        {
            set
            {
                _networkSecurityRuleMetadata.LastUpdateTime = value;
            }
        }
        /// <summary>network_security_rule name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "network_security_rule name")]
        public string Name
        {
            set
            {
                _networkSecurityRuleMetadata.Name = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ProjectReferenceKind
        {
            set
            {
                _networkSecurityRuleMetadata.ProjectReference = _networkSecurityRuleMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _networkSecurityRuleMetadata.ProjectReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceName
        {
            set
            {
                _networkSecurityRuleMetadata.ProjectReference = _networkSecurityRuleMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _networkSecurityRuleMetadata.ProjectReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ProjectReferenceUuid
        {
            set
            {
                _networkSecurityRuleMetadata.ProjectReference = _networkSecurityRuleMetadata.ProjectReference ?? new Sample.API.Models.ProjectReference();
                _networkSecurityRuleMetadata.ProjectReference.Uuid = value;
            }
        }
        /// <summary>Hash of the spec. This will be returned from server.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Hash of the spec. This will be returned from server.")]
        public string SpecHash
        {
            set
            {
                _networkSecurityRuleMetadata.SpecHash = value;
            }
        }
        /// <summary>Version number of the latest spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Version number of the latest spec.")]
        public int SpecVersion
        {
            set
            {
                _networkSecurityRuleMetadata.SpecVersion = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string UserReferenceKind
        {
            set
            {
                _networkSecurityRuleMetadata.OwnerReference = _networkSecurityRuleMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _networkSecurityRuleMetadata.OwnerReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceName
        {
            set
            {
                _networkSecurityRuleMetadata.OwnerReference = _networkSecurityRuleMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _networkSecurityRuleMetadata.OwnerReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string UserReferenceUuid
        {
            set
            {
                _networkSecurityRuleMetadata.OwnerReference = _networkSecurityRuleMetadata.OwnerReference ?? new Sample.API.Models.UserReference();
                _networkSecurityRuleMetadata.OwnerReference.Uuid = value;
            }
        }
        /// <summary>network_security_rule uuid</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "network_security_rule uuid")]
        public string Uuid
        {
            set
            {
                _networkSecurityRuleMetadata.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkSecurityRuleMetadata);
        }
    }
}