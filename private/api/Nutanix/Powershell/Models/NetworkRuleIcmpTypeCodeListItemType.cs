namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class NetworkRuleIcmpTypeCodeListItemType : Nutanix.Powershell.Models.INetworkRuleIcmpTypeCodeListItemType
    {
        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private int? _code;

        public int? Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private int? _type;

        public int? Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkRuleIcmpTypeCodeListItemType" /> instance.</summary>
        public NetworkRuleIcmpTypeCodeListItemType()
        {
        }
    }
    public partial interface INetworkRuleIcmpTypeCodeListItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? Code { get; set; }
        int? Type { get; set; }
    }
}