namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Address" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AddressObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IAddress))]
    public class NewAddressObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Address" /></summary>
        private Sample.API.Models.IAddress _address = new Sample.API.Models.Address();
        /// <summary>Fully qualified domain name.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Fully qualified domain name.")]
        public string Fqdn
        {
            set
            {
                _address.Fqdn = value;
            }
        }
        /// <summary>IPV4 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV4 address.")]
        public string Ip
        {
            set
            {
                _address.Ip = value;
            }
        }
        /// <summary>IPV6 address.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "IPV6 address.")]
        public string Ipv6
        {
            set
            {
                _address.Ipv6 = value;
            }
        }
        /// <summary>Port Number</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Port Number")]
        public int Port
        {
            set
            {
                _address.Port = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_address);
        }
    }
}