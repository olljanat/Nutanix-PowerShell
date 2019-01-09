namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CertificationSigningInfo" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CertificationSigningInfoObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ICertificationSigningInfo))]
    public class NewCertificationSigningInfoObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CertificationSigningInfo" /></summary>
        private Nutanix.Powershell.Models.ICertificationSigningInfo _certificationSigningInfo = new Nutanix.Powershell.Models.CertificationSigningInfo();
        /// <summary>The Town or City where customer's business is located.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Town or City where customer's business is located.")]
        public string City
        {
            set
            {
                _certificationSigningInfo.City = value;
            }
        }
        /// <summary>Common name of the organization or host server</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Common name of the organization or host server")]
        public string CommonName
        {
            set
            {
                _certificationSigningInfo.CommonName = value;
            }
        }
        /// <summary>
        /// Common name is by default <node_uuid>.nutanix.com, but if a customerwants something instead of nutanix.com they can specify
        /// it here.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Common name is by default <node_uuid>.nutanix.com, but if a customerwants something instead of nutanix.com they can specify it here.")]
        public string CommonNameSuffix
        {
            set
            {
                _certificationSigningInfo.CommonNameSuffix = value;
            }
        }
        /// <summary>Two-letter ISO code for Country where customer's organization islocated.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Two-letter ISO code for Country where customer's organization islocated.")]
        public string CountryCode
        {
            set
            {
                _certificationSigningInfo.CountryCode = value;
            }
        }
        /// <summary>Email address of the certificate administrator.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Email address of the certificate administrator.")]
        public string EmailAddress
        {
            set
            {
                _certificationSigningInfo.EmailAddress = value;
            }
        }
        /// <summary>Name of the customer business.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Name of the customer business.")]
        public string Organization
        {
            set
            {
                _certificationSigningInfo.Organization = value;
            }
        }
        /// <summary>The Province, Region, County or State where customer business isis located.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The Province, Region, County or State where customer business isis located.")]
        public string State
        {
            set
            {
                _certificationSigningInfo.State = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_certificationSigningInfo);
        }
    }
}