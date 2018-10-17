namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Virtual Machine NIC.</summary>
    public partial class VmNic : Sample.API.Models.IVmNic, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for IpEndpointList property</summary>
        private Sample.API.Models.IIpAddress[] _ipEndpointList;

        /// <summary>
        /// IP endpoints for the adapter. Currently, IPv4 addresses are
        /// supported.
        /// </summary>
        public Sample.API.Models.IIpAddress[] IpEndpointList
        {
            get
            {
                return this._ipEndpointList;
            }
            set
            {
                this._ipEndpointList = value;
            }
        }
        /// <summary>Backing field for MacAddress property</summary>
        private string _macAddress;

        /// <summary>The MAC address for the adapter.</summary>
        public string MacAddress
        {
            get
            {
                return this._macAddress;
            }
            set
            {
                this._macAddress = value;
            }
        }
        /// <summary>Backing field for Model property</summary>
        private string _model;

        /// <summary>The model of this NIC.</summary>
        public string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
        /// <summary>Backing field for NetworkFunctionChainReference property</summary>
        private Sample.API.Models.INetworkFunctionChainReference _networkFunctionChainReference;

        /// <summary>The reference to a network_function_chain</summary>
        public Sample.API.Models.INetworkFunctionChainReference NetworkFunctionChainReference
        {
            get
            {
                return this._networkFunctionChainReference;
            }
            set
            {
                this._networkFunctionChainReference = value;
            }
        }
        /// <summary>Backing field for NetworkFunctionNicType property</summary>
        private string _networkFunctionNicType;

        /// <summary>
        /// The type of this Network function NIC. Defaults to INGRESS.
        /// </summary>
        public string NetworkFunctionNicType
        {
            get
            {
                return this._networkFunctionNicType;
            }
            set
            {
                this._networkFunctionNicType = value;
            }
        }
        /// <summary>Backing field for NicType property</summary>
        private string _nicType;

        /// <summary>The type of this NIC. Defaults to NORMAL_NIC.</summary>
        public string NicType
        {
            get
            {
                return this._nicType;
            }
            set
            {
                this._nicType = value;
            }
        }
        /// <summary>Backing field for SubnetReference property</summary>
        private Sample.API.Models.ISubnetReference _subnetReference;

        /// <summary>The reference to a subnet</summary>
        public Sample.API.Models.ISubnetReference SubnetReference
        {
            get
            {
                return this._subnetReference;
            }
            set
            {
                this._subnetReference = value;
            }
        }
        /// <summary>Backing field for Uuid property</summary>
        private string _uuid;

        /// <summary>
        /// The NIC's UUID, which is used to uniquely identify this particular NIC. This UUID may be used to refer to the NIC outside
        /// the context of the particular VM it is attached to.
        /// </summary>
        public string Uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
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
            if (IpEndpointList != null ) {
                    for (int __i = 0; __i < IpEndpointList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"IpEndpointList[{__i}]", IpEndpointList[__i]);
                    }
                  }
            await eventListener.AssertRegEx(nameof(MacAddress),MacAddress,@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$");
            await eventListener.AssertObjectIsValid(nameof(NetworkFunctionChainReference), NetworkFunctionChainReference);
            await eventListener.AssertObjectIsValid(nameof(SubnetReference), SubnetReference);
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
        /// <summary>Creates an new <see cref="VmNic" /> instance.</summary>
        public VmNic()
        {
        }
    }
    /// Virtual Machine NIC.
    public partial interface IVmNic : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IIpAddress[] IpEndpointList { get; set; }
        string MacAddress { get; set; }
        string Model { get; set; }
        Sample.API.Models.INetworkFunctionChainReference NetworkFunctionChainReference { get; set; }
        string NetworkFunctionNicType { get; set; }
        string NicType { get; set; }
        Sample.API.Models.ISubnetReference SubnetReference { get; set; }
        string Uuid { get; set; }
    }
}