namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Checksum" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ChecksumObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IChecksum))]
    public class NewChecksumObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Checksum" /></summary>
        private Nutanix.Powershell.Models.IChecksum _checksum = new Nutanix.Powershell.Models.Checksum();
        /// <summary>The type of checksum calculated for the image</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The type of checksum calculated for the image")]
        public string ChecksumAlgorithm
        {
            set
            {
                _checksum.ChecksumAlgorithm = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ChecksumValue
        {
            set
            {
                _checksum.ChecksumValue = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_checksum);
        }
    }
}