namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CitrixConnectorConfigDetailsSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CitrixConnectorConfigDetailsSpecObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec))]
    public class NewCitrixConnectorConfigDetailsSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CitrixConnectorConfigDetailsSpec" /></summary>
        private Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec _citrixConnectorConfigDetailsSpec = new Nutanix.Powershell.Models.CitrixConnectorConfigDetailsSpec();
        /// <summary>The resource location id.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource location id.")]
        public string CitrixResourceLocationSpecId
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.ResourceLocation = _citrixConnectorConfigDetailsSpec.ResourceLocation ?? new Nutanix.Powershell.Models.CitrixResourceLocationSpec();
                _citrixConnectorConfigDetailsSpec.ResourceLocation.Id = value;
            }
        }
        /// <summary>The resource location name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The resource location name.")]
        public string CitrixResourceLocationSpecName
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.ResourceLocation = _citrixConnectorConfigDetailsSpec.ResourceLocation ?? new Nutanix.Powershell.Models.CitrixResourceLocationSpec();
                _citrixConnectorConfigDetailsSpec.ResourceLocation.Name = value;
            }
        }
        /// <summary>Reference to the list of vm ids registered with citrix cloud.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Reference to the list of vm ids registered with citrix cloud.")]
        public Nutanix.Powershell.Models.IVmReference[] CitrixVmReferenceList
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.CitrixVmReferenceList = value;
            }
        }
        /// <summary>The client id for the Citrix Cloud.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The client id for the Citrix Cloud.")]
        public string ClientId
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.ClientId = value;
            }
        }
        /// <summary>The client secret for the Citrix Cloud.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The client secret for the Citrix Cloud.")]
        public string ClientSecret
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.ClientSecret = value;
            }
        }
        /// <summary>The customer id registered with Citrix Cloud.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The customer id registered with Citrix Cloud.")]
        public string CustomerId
        {
            set
            {
                _citrixConnectorConfigDetailsSpec.CustomerId = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_citrixConnectorConfigDetailsSpec);
        }
    }
}