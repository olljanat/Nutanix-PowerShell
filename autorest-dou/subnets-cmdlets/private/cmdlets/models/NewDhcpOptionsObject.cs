namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="DhcpOptions" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"DhcpOptionsObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IDhcpOptions))]
    public class NewDhcpOptionsObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="DhcpOptions" /></summary>
        private Sample.API.Models.IDhcpOptions _dhcpOptions = new Sample.API.Models.DhcpOptions();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string BootFileName
        {
            set
            {
                _dhcpOptions.BootFileName = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string DomainName
        {
            set
            {
                _dhcpOptions.DomainName = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string[] DomainNameServerList
        {
            set
            {
                _dhcpOptions.DomainNameServerList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string[] DomainSearchList
        {
            set
            {
                _dhcpOptions.DomainSearchList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string TftpServerName
        {
            set
            {
                _dhcpOptions.TftpServerName = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_dhcpOptions);
        }
    }
}