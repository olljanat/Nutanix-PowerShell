namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Indicates how VM vNUMA should be configured
    /// </summary>
    public partial class VmVnumaConfig : Nutanix.Powershell.Models.IVmVnumaConfig
    {
        /// <summary>Backing field for NumVnumaNodes property</summary>
        private long? _numVnumaNodes;

        /// <summary>Number of vNUMA nodes. 0 means vNUMA is disabled.</summary>
        public long? NumVnumaNodes
        {
            get
            {
                return this._numVnumaNodes;
            }
            set
            {
                this._numVnumaNodes = value;
            }
        }
        /// <summary>Creates an new <see cref="VmVnumaConfig" /> instance.</summary>
        public VmVnumaConfig()
        {
        }
    }
    /// Indicates how VM vNUMA should be configured
    public partial interface IVmVnumaConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        long? NumVnumaNodes { get; set; }
    }
}