namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class NetworkRuleIcmpTypeCodeListItemType : Sample.API.Models.INetworkRuleIcmpTypeCodeListItemType
    {
        /// <summary>Backing field for Code property</summary>
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
        /// <summary>Backing field for Type property</summary>
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