namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// If this field is set, the guest will be customized using cloud-init. Either user_data or custom_key_values should be provided.
    /// If custom_key_ves are provided then the user data will be generated using these key-value pairs.
    /// </summary>
    public partial class GuestCustomizationStatusCloudInit : Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit
    {
        /// <summary>Backing field for CustomKeyValues property</summary>
        private System.Collections.Generic.IDictionary<string,string> _customKeyValues;

        /// <summary>Generic key value pair used for custom attributes</summary>
        public System.Collections.Generic.IDictionary<string,string> CustomKeyValues
        {
            get
            {
                return this._customKeyValues;
            }
            set
            {
                this._customKeyValues = value;
            }
        }
        /// <summary>Backing field for MetaData property</summary>
        private string _metaData;

        /// <summary>
        /// The contents of the meta_data configuration for cloud-init. This can be formatted as YAML or JSON. The value must be base64
        /// encoded.
        /// </summary>
        public string MetaData
        {
            get
            {
                return this._metaData;
            }
            set
            {
                this._metaData = value;
            }
        }
        /// <summary>Backing field for UserData property</summary>
        private string _userData;

        /// <summary>
        /// The contents of the user_data configuration for cloud-init. This can be formatted as YAML, JSON, or could be a shell script.
        /// The value must be base64 encoded.
        /// </summary>
        public string UserData
        {
            get
            {
                return this._userData;
            }
            set
            {
                this._userData = value;
            }
        }
        /// <summary>Creates an new <see cref="GuestCustomizationStatusCloudInit" /> instance.</summary>
        public GuestCustomizationStatusCloudInit()
        {
        }
    }
    /// If this field is set, the guest will be customized using cloud-init. Either user_data or custom_key_values should be provided.
    /// If custom_key_ves are provided then the user data will be generated using these key-value pairs.
    public partial interface IGuestCustomizationStatusCloudInit : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.IDictionary<string,string> CustomKeyValues { get; set; }
        string MetaData { get; set; }
        string UserData { get; set; }
    }
}