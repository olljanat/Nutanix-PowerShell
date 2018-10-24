namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>VM Resources Definition.</summary>
    public partial class VmResources : Nutanix.Powershell.Models.IVmResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for BootConfig property</summary>
        private Nutanix.Powershell.Models.IVmBootConfig _bootConfig;

        /// <summary>Indicates which device the VM should boot from.</summary>
        public Nutanix.Powershell.Models.IVmBootConfig BootConfig
        {
            get
            {
                return this._bootConfig;
            }
            set
            {
                this._bootConfig = value;
            }
        }
        /// <summary>Backing field for DiskList property</summary>
        private Nutanix.Powershell.Models.IVmDisk[] _diskList;

        /// <summary>Disks attached to the VM.</summary>
        public Nutanix.Powershell.Models.IVmDisk[] DiskList
        {
            get
            {
                return this._diskList;
            }
            set
            {
                this._diskList = value;
            }
        }
        /// <summary>Backing field for GpuList property</summary>
        private Nutanix.Powershell.Models.IVmGpu[] _gpuList;

        /// <summary>GPUs attached to the VM.</summary>
        public Nutanix.Powershell.Models.IVmGpu[] GpuList
        {
            get
            {
                return this._gpuList;
            }
            set
            {
                this._gpuList = value;
            }
        }
        /// <summary>Backing field for GuestCustomization property</summary>
        private Nutanix.Powershell.Models.IGuestCustomization _guestCustomization;

        /// <summary>
        /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
        /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
        /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
        /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
        /// is set to "True" then the deployer can upload their own custom script.
        /// </summary>
        public Nutanix.Powershell.Models.IGuestCustomization GuestCustomization
        {
            get
            {
                return this._guestCustomization;
            }
            set
            {
                this._guestCustomization = value;
            }
        }
        /// <summary>Backing field for GuestOsId property</summary>
        private string _guestOsId;

        /// <summary>
        /// Guest OS Identifier. For ESX, refer to VMware documentation link (https://www.vmware.com/support/developer/converter-sdk/conv43_apireference/vim.vm.GuestOsDescriptor.GuestOsIdentifier.html)
        /// for the list of guest OS identifiers.
        /// </summary>
        public string GuestOsId
        {
            get
            {
                return this._guestOsId;
            }
            set
            {
                this._guestOsId = value;
            }
        }
        /// <summary>Backing field for GuestTools property</summary>
        private Nutanix.Powershell.Models.IGuestToolsSpec _guestTools;

        /// <summary>Information regarding guest tools.</summary>
        public Nutanix.Powershell.Models.IGuestToolsSpec GuestTools
        {
            get
            {
                return this._guestTools;
            }
            set
            {
                this._guestTools = value;
            }
        }
        /// <summary>Backing field for HardwareClockTimezone property</summary>
        private string _hardwareClockTimezone;

        /// <summary>
        /// VM's hardware clock timezone in IANA TZDB format (America/Los_Angeles).
        /// </summary>
        public string HardwareClockTimezone
        {
            get
            {
                return this._hardwareClockTimezone;
            }
            set
            {
                this._hardwareClockTimezone = value;
            }
        }
        /// <summary>Backing field for MemorySizeMib property</summary>
        private int? _memorySizeMib;

        /// <summary>Memory size in MiB.</summary>
        public int? MemorySizeMib
        {
            get
            {
                return this._memorySizeMib;
            }
            set
            {
                this._memorySizeMib = value;
            }
        }
        /// <summary>Backing field for NicList property</summary>
        private Nutanix.Powershell.Models.IVmNic[] _nicList;

        /// <summary>NICs attached to the VM.</summary>
        public Nutanix.Powershell.Models.IVmNic[] NicList
        {
            get
            {
                return this._nicList;
            }
            set
            {
                this._nicList = value;
            }
        }
        /// <summary>Backing field for NumSockets property</summary>
        private int? _numSockets;

        /// <summary>Number of vCPU sockets.</summary>
        public int? NumSockets
        {
            get
            {
                return this._numSockets;
            }
            set
            {
                this._numSockets = value;
            }
        }
        /// <summary>Backing field for NumVcpusPerSocket property</summary>
        private int? _numVcpusPerSocket;

        /// <summary>Number of vCPUs per socket.</summary>
        public int? NumVcpusPerSocket
        {
            get
            {
                return this._numVcpusPerSocket;
            }
            set
            {
                this._numVcpusPerSocket = value;
            }
        }
        /// <summary>Backing field for ParentReference property</summary>
        private Nutanix.Powershell.Models.IReference _parentReference;

        /// <summary>
        /// Reference to an entity that the VM should be cloned from.
        /// </summary>
        public Nutanix.Powershell.Models.IReference ParentReference
        {
            get
            {
                return this._parentReference;
            }
            set
            {
                this._parentReference = value;
            }
        }
        /// <summary>Backing field for PowerState property</summary>
        private string _powerState;

        /// <summary>The current or desired power state of the VM.</summary>
        public string PowerState
        {
            get
            {
                return this._powerState;
            }
            set
            {
                this._powerState = value;
            }
        }
        /// <summary>Backing field for PowerStateMechanism property</summary>
        private Nutanix.Powershell.Models.IVmPowerStateMechanism _powerStateMechanism;

        /// <summary>
        /// Indicates the mechanism guiding the VM power state transition. Currently used for the transition to "OFF" state.
        /// </summary>
        public Nutanix.Powershell.Models.IVmPowerStateMechanism PowerStateMechanism
        {
            get
            {
                return this._powerStateMechanism;
            }
            set
            {
                this._powerStateMechanism = value;
            }
        }
        /// <summary>Backing field for VgaConsoleEnabled property</summary>
        private bool? _vgaConsoleEnabled;

        /// <summary>Indicates whether VGA console should be enabled or not.</summary>
        public bool? VgaConsoleEnabled
        {
            get
            {
                return this._vgaConsoleEnabled;
            }
            set
            {
                this._vgaConsoleEnabled = value;
            }
        }
        /// <summary>Backing field for VnumaConfig property</summary>
        private Nutanix.Powershell.Models.IVmVnumaConfig _vnumaConfig;

        /// <summary>Information regarding vNUMA configuration.</summary>
        public Nutanix.Powershell.Models.IVmVnumaConfig VnumaConfig
        {
            get
            {
                return this._vnumaConfig;
            }
            set
            {
                this._vnumaConfig = value;
            }
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(BootConfig), BootConfig);
            if (DiskList != null ) {
                    for (int __i = 0; __i < DiskList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"DiskList[{__i}]", DiskList[__i]);
                    }
                  }
            if (GpuList != null ) {
                    for (int __i = 0; __i < GpuList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"GpuList[{__i}]", GpuList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(GuestCustomization), GuestCustomization);
            await eventListener.AssertMaximumLength(nameof(GuestOsId),GuestOsId,64);
            await eventListener.AssertObjectIsValid(nameof(GuestTools), GuestTools);
            await eventListener.AssertMaximumLength(nameof(HardwareClockTimezone),HardwareClockTimezone,64);
            await eventListener.AssertIsGreaterThanOrEqual(nameof(MemorySizeMib),MemorySizeMib,1);
            if (NicList != null ) {
                    for (int __i = 0; __i < NicList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"NicList[{__i}]", NicList[__i]);
                    }
                  }
            await eventListener.AssertIsGreaterThanOrEqual(nameof(NumSockets),NumSockets,1);
            await eventListener.AssertIsGreaterThanOrEqual(nameof(NumVcpusPerSocket),NumVcpusPerSocket,1);
            await eventListener.AssertObjectIsValid(nameof(ParentReference), ParentReference);
            await eventListener.AssertObjectIsValid(nameof(PowerStateMechanism), PowerStateMechanism);
            await eventListener.AssertObjectIsValid(nameof(VnumaConfig), VnumaConfig);
        }
        /// <summary>Creates an new <see cref="VmResources" /> instance.</summary>
        public VmResources()
        {
        }
    }
    /// VM Resources Definition.
    public partial interface IVmResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IVmBootConfig BootConfig { get; set; }
        Nutanix.Powershell.Models.IVmDisk[] DiskList { get; set; }
        Nutanix.Powershell.Models.IVmGpu[] GpuList { get; set; }
        Nutanix.Powershell.Models.IGuestCustomization GuestCustomization { get; set; }
        string GuestOsId { get; set; }
        Nutanix.Powershell.Models.IGuestToolsSpec GuestTools { get; set; }
        string HardwareClockTimezone { get; set; }
        int? MemorySizeMib { get; set; }
        Nutanix.Powershell.Models.IVmNic[] NicList { get; set; }
        int? NumSockets { get; set; }
        int? NumVcpusPerSocket { get; set; }
        Nutanix.Powershell.Models.IReference ParentReference { get; set; }
        string PowerState { get; set; }
        Nutanix.Powershell.Models.IVmPowerStateMechanism PowerStateMechanism { get; set; }
        bool? VgaConsoleEnabled { get; set; }
        Nutanix.Powershell.Models.IVmVnumaConfig VnumaConfig { get; set; }
    }
}