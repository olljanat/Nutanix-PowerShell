namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="Disk" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"DiskObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmDisk))]
    public class NewDiskObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmDisk" /></summary>
        private Sample.API.Models.IVmDisk _disk = new Sample.API.Models.VmDisk();

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string DataSourceReferenceKind
        {
            set
            {
                _disk.DataSourceReference = _disk.DataSourceReference ?? new Sample.API.Models.Reference();
                _disk.DataSourceReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string DataSourceReferenceName
        {
            set
            {
                _disk.DataSourceReference = _disk.DataSourceReference ?? new Sample.API.Models.Reference();                
                _disk.DataSourceReference.Name = value;
            }
        }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string DataSourceReferenceUuid
        {
            set
            {
                _disk.DataSourceReference = _disk.DataSourceReference ?? new Sample.API.Models.Reference();                
                _disk.DataSourceReference.Uuid = value;
            }
        }
        
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string DeviceType
        {
            set
            {
                _disk.DeviceProperties = _disk.DeviceProperties ?? new Sample.API.Models.VmDiskDeviceProperties();
                _disk.DeviceProperties.DeviceType = value;
            }
        }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AdapterType
        {
            set
            {
                _disk.DeviceProperties = _disk.DeviceProperties ?? new Sample.API.Models.VmDiskDeviceProperties();
                _disk.DeviceProperties.DiskAddress.AdapterType = value;
            }
        }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public int DeviceIndex
        {
            set
            {
                _disk.DeviceProperties = _disk.DeviceProperties ?? new Sample.API.Models.VmDiskDeviceProperties();
                _disk.DeviceProperties.DiskAddress.DeviceIndex = value;
            }
        }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public long DiskSizeBytes
        {
            set
            {
                _disk.DiskSizeBytes = value;
            }
        }

        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public int DiskSizeMib
        {
            set
            {
                _disk.DiskSizeMib = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_disk);
        }
    }
}