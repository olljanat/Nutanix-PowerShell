namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmBootDevice" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmBootDeviceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmBootDevice))]
    public class NewVmBootDeviceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmBootDevice" /></summary>
        private Sample.API.Models.IVmBootDevice _vmBootDevice = new Sample.API.Models.VmBootDevice();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string DiskAddressAdapterType
        {
            set
            {
                _vmBootDevice.DiskAddress = _vmBootDevice.DiskAddress ?? new Sample.API.Models.DiskAddress();
                _vmBootDevice.DiskAddress.AdapterType = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public int DiskAddressDeviceIndex
        {
            set
            {
                _vmBootDevice.DiskAddress = _vmBootDevice.DiskAddress ?? new Sample.API.Models.DiskAddress();
                _vmBootDevice.DiskAddress.DeviceIndex = value;
            }
        }
        /// <summary>MAC address of nic to boot from.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "MAC address of nic to boot from.")]
        public string MacAddress
        {
            set
            {
                _vmBootDevice.MacAddress = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmBootDevice);
        }
    }
}