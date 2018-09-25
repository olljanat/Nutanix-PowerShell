namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
    /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
    /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
    /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
    /// is set to "True" then the deployer can upload their own custom script.
    /// </summary>
    public partial class GuestCustomizationStatus : Nutanix.Powershell.Models.IGuestCustomizationStatus, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CloudInit property</summary>
        private Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit _cloudInit;

        /// <summary>
        /// If this field is set, the guest will be customized using cloud-init. Either user_data or custom_key_values should be provided.
        /// If custom_key_ves are provided then the user data will be generated using these key-value pairs.
        /// </summary>
        public Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit CloudInit
        {
            get
            {
                return this._cloudInit;
            }
            set
            {
                this._cloudInit = value;
            }
        }
        /// <summary>Backing field for IsOverridable property</summary>
        private bool? _isOverridable;

        /// <summary>Flag to allow override of customization by deployer.</summary>
        public bool? IsOverridable
        {
            get
            {
                return this._isOverridable;
            }
            set
            {
                this._isOverridable = value;
            }
        }
        /// <summary>Backing field for Sysprep property</summary>
        private Nutanix.Powershell.Models.IGuestCustomizationStatusSysprep _sysprep;

        /// <summary>
        /// If this field is set, the guest will be customized using Sysprep. Either unattend_xml or custom_key_values should be provided.
        /// If custom_key_values are provided then the unattended answer file will be generated using these key-value pairs.
        /// </summary>
        public Nutanix.Powershell.Models.IGuestCustomizationStatusSysprep Sysprep
        {
            get
            {
                return this._sysprep;
            }
            set
            {
                this._sysprep = value;
            }
        }
        /// <summary>Creates an new <see cref="GuestCustomizationStatus" /> instance.</summary>
        public GuestCustomizationStatus()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(CloudInit), CloudInit);
            await eventListener.AssertObjectIsValid(nameof(Sysprep), Sysprep);
        }
    }
    /// VM guests may be customized at boot time using one of several different methods. Currently, cloud-init w/ ConfigDriveV2
    /// (for Linux VMs) and Sysprep (for Windows VMs) are supported. Only ONE OF sysprep or cloud_init should be provided. Note
    /// that guest customization can currently only be set during VM creation. Attempting to change it after creation will result
    /// in an error. Additional properties can be specified. For example - in the context of VM template creation if "override_script"
    /// is set to "True" then the deployer can upload their own custom script.
    public partial interface IGuestCustomizationStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit CloudInit { get; set; }
        bool? IsOverridable { get; set; }
        Nutanix.Powershell.Models.IGuestCustomizationStatusSysprep Sysprep { get; set; }
    }
}