namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="DiskAddress" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"DiskAddressObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IDiskAddress))]
    public class NewDiskAddressObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="DiskAddress" /></summary>
        private Sample.API.Models.IDiskAddress _diskAddress = new Sample.API.Models.DiskAddress();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string AdapterType
        {
            set
            {
                _diskAddress.AdapterType = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public int DeviceIndex
        {
            set
            {
                _diskAddress.DeviceIndex = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_diskAddress);
        }
    }
}