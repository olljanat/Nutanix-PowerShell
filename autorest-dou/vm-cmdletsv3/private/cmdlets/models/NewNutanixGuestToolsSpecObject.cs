namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NutanixGuestToolsSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NutanixGuestToolsSpecObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INutanixGuestToolsSpec))]
    public class NewNutanixGuestToolsSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NutanixGuestToolsSpec" /></summary>
        private Sample.API.Models.INutanixGuestToolsSpec _nutanixGuestToolsSpec = new Sample.API.Models.NutanixGuestToolsSpec();
        /// <summary>Application names that are enabled.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Application names that are enabled.")]
        public string[] EnabledCapabilityList
        {
            set
            {
                _nutanixGuestToolsSpec.EnabledCapabilityList = value;
            }
        }
        /// <summary>Desired mount state of Nutanix Guest Tools ISO.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Desired mount state of Nutanix Guest Tools ISO.")]
        public string IsoMountState
        {
            set
            {
                _nutanixGuestToolsSpec.IsoMountState = value;
            }
        }
        /// <summary>Nutanix Guest Tools is enabled or not.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Nutanix Guest Tools is enabled or not.")]
        public string State
        {
            set
            {
                _nutanixGuestToolsSpec.State = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_nutanixGuestToolsSpec);
        }
    }
}