namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="GuestToolsSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"GuestToolsSpecObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IGuestToolsSpec))]
    public class NewGuestToolsSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="GuestToolsSpec" /></summary>
        private Sample.API.Models.IGuestToolsSpec _guestToolsSpec = new Sample.API.Models.GuestToolsSpec();
        /// <summary>Application names that are enabled.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Application names that are enabled.")]
        public string[] NutanixGuestToolsSpecEnabledCapabilityList
        {
            set
            {
                _guestToolsSpec.NutanixGuestTools = _guestToolsSpec.NutanixGuestTools ?? new Sample.API.Models.NutanixGuestToolsSpec();
                _guestToolsSpec.NutanixGuestTools.EnabledCapabilityList = value;
            }
        }
        /// <summary>Desired mount state of Nutanix Guest Tools ISO.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Desired mount state of Nutanix Guest Tools ISO.")]
        public string NutanixGuestToolsSpecIsoMountState
        {
            set
            {
                _guestToolsSpec.NutanixGuestTools = _guestToolsSpec.NutanixGuestTools ?? new Sample.API.Models.NutanixGuestToolsSpec();
                _guestToolsSpec.NutanixGuestTools.IsoMountState = value;
            }
        }
        /// <summary>Nutanix Guest Tools is enabled or not.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Nutanix Guest Tools is enabled or not.")]
        public string NutanixGuestToolsSpecState
        {
            set
            {
                _guestToolsSpec.NutanixGuestTools = _guestToolsSpec.NutanixGuestTools ?? new Sample.API.Models.NutanixGuestToolsSpec();
                _guestToolsSpec.NutanixGuestTools.State = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_guestToolsSpec);
        }
    }
}