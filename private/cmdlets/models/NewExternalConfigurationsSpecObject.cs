namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ExternalConfigurationsSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ExternalConfigurationsSpecObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IExternalConfigurationsSpec))]
    public class NewExternalConfigurationsSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ExternalConfigurationsSpec" /></summary>
        private Nutanix.Powershell.Models.IExternalConfigurationsSpec _externalConfigurationsSpec = new Nutanix.Powershell.Models.ExternalConfigurationsSpec();
        /// <summary>Citrix Connector details.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Citrix Connector details.")]
        public Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec CitrixConnectorConfig
        {
            set
            {
                _externalConfigurationsSpec.CitrixConnectorConfig = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_externalConfigurationsSpec);
        }
    }
}