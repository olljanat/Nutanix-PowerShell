namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="SubnetResources" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"SubnetResourcesObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ISubnetResources))]
    public class NewSubnetResourcesObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="SubnetResources" /></summary>
        private Nutanix.Powershell.Models.ISubnetResources _subnetResources = new Nutanix.Powershell.Models.SubnetResources();
        /// <summary>IP config.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IP config.")]
        public Nutanix.Powershell.Models.IIpConfig IpConfig
        {
            set
            {
                _subnetResources.IpConfig = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string NetworkFunctionChainReferenceKind
        {
            set
            {
                _subnetResources.NetworkFunctionChainReference = _subnetResources.NetworkFunctionChainReference ?? new Nutanix.Powershell.Models.NetworkFunctionChainReference();
                _subnetResources.NetworkFunctionChainReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string NetworkFunctionChainReferenceName
        {
            set
            {
                _subnetResources.NetworkFunctionChainReference = _subnetResources.NetworkFunctionChainReference ?? new Nutanix.Powershell.Models.NetworkFunctionChainReference();
                _subnetResources.NetworkFunctionChainReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string NetworkFunctionChainReferenceUuid
        {
            set
            {
                _subnetResources.NetworkFunctionChainReference = _subnetResources.NetworkFunctionChainReference ?? new Nutanix.Powershell.Models.NetworkFunctionChainReference();
                _subnetResources.NetworkFunctionChainReference.Uuid = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string SubnetType
        {
            set
            {
                _subnetResources.SubnetType = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public int VlanId
        {
            set
            {
                _subnetResources.VlanId = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string VswitchName
        {
            set
            {
                _subnetResources.VswitchName = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_subnetResources);
        }
    }
}