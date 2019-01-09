namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Citrix Connector details.</summary>
    public partial class CitrixConnectorConfigDetailsSpec : Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CitrixVmReferenceList" /> property.</summary>
        private Nutanix.Powershell.Models.IVmReference[] _citrixVmReferenceList;

        /// <summary>Reference to the list of vm ids registered with citrix cloud.</summary>
        public Nutanix.Powershell.Models.IVmReference[] CitrixVmReferenceList
        {
            get
            {
                return this._citrixVmReferenceList;
            }
            set
            {
                this._citrixVmReferenceList = value;
            }
        }
        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client id for the Citrix Cloud.</summary>
        public string ClientId
        {
            get
            {
                return this._clientId;
            }
            set
            {
                this._clientId = value;
            }
        }
        /// <summary>Backing field for <see cref="ClientSecret" /> property.</summary>
        private string _clientSecret;

        /// <summary>The client secret for the Citrix Cloud.</summary>
        public string ClientSecret
        {
            get
            {
                return this._clientSecret;
            }
            set
            {
                this._clientSecret = value;
            }
        }
        /// <summary>Backing field for <see cref="CustomerId" /> property.</summary>
        private string _customerId;

        /// <summary>The customer id registered with Citrix Cloud.</summary>
        public string CustomerId
        {
            get
            {
                return this._customerId;
            }
            set
            {
                this._customerId = value;
            }
        }
        /// <summary>Backing field for <see cref="ResourceLocation" /> property.</summary>
        private Nutanix.Powershell.Models.ICitrixResourceLocationSpec _resourceLocation;

        /// <summary>Resource Location on Citrix Cloud.</summary>
        public Nutanix.Powershell.Models.ICitrixResourceLocationSpec ResourceLocation
        {
            get
            {
                return this._resourceLocation;
            }
            set
            {
                this._resourceLocation = value;
            }
        }
        /// <summary>Creates an new <see cref="CitrixConnectorConfigDetailsSpec" /> instance.</summary>
        public CitrixConnectorConfigDetailsSpec()
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
            if (CitrixVmReferenceList != null ) {
                    for (int __i = 0; __i < CitrixVmReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"CitrixVmReferenceList[{__i}]", CitrixVmReferenceList[__i]);
                    }
                  }
            await eventListener.AssertMaximumLength(nameof(ClientId),ClientId,200);
            await eventListener.AssertMaximumLength(nameof(CustomerId),CustomerId,200);
            await eventListener.AssertObjectIsValid(nameof(ResourceLocation), ResourceLocation);
        }
    }
    /// Citrix Connector details.
    public partial interface ICitrixConnectorConfigDetailsSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IVmReference[] CitrixVmReferenceList { get; set; }
        string ClientId { get; set; }
        string ClientSecret { get; set; }
        string CustomerId { get; set; }
        Nutanix.Powershell.Models.ICitrixResourceLocationSpec ResourceLocation { get; set; }
    }
}