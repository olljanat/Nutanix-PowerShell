namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmBootConfig" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmBootConfigObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmBootConfig))]
    public class NewVmBootConfigObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmBootConfig" /></summary>
        private Sample.API.Models.IVmBootConfig _vmBootConfig = new Sample.API.Models.VmBootConfig();
        /// <summary>
        /// Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system
        /// will decide appropriate boot device order.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Indicates the order of device types in which VM should try to boot from. If boot device order is not provided the system will decide appropriate boot device order.")]
        public string[] BootDeviceOrderList
        {
            set
            {
                _vmBootConfig.BootDeviceOrderList = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string DiskAddressAdapterType
        {
            set
            {
                _vmBootConfig.BootDevice = _vmBootConfig.BootDevice ?? new Sample.API.Models.VmBootDevice();
                _vmBootConfig.BootDevice.DiskAddress = _vmBootConfig.BootDevice.DiskAddress ?? new Sample.API.Models.DiskAddress();
                _vmBootConfig.BootDevice.DiskAddress.AdapterType = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public int DiskAddressDeviceIndex
        {
            set
            {
                _vmBootConfig.BootDevice = _vmBootConfig.BootDevice ?? new Sample.API.Models.VmBootDevice();
                _vmBootConfig.BootDevice.DiskAddress = _vmBootConfig.BootDevice.DiskAddress ?? new Sample.API.Models.DiskAddress();
                _vmBootConfig.BootDevice.DiskAddress.DeviceIndex = value;
            }
        }
        /// <summary>MAC address of nic to boot from.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "MAC address of nic to boot from.")]
        public string VmBootDeviceMacAddress
        {
            set
            {
                _vmBootConfig.BootDevice = _vmBootConfig.BootDevice ?? new Sample.API.Models.VmBootDevice();
                _vmBootConfig.BootDevice.MacAddress = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmBootConfig);
        }
    }
}