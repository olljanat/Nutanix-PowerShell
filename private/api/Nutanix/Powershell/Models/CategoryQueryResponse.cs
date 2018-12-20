namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Categories query response object.</summary>
    public partial class CategoryQueryResponse : Nutanix.Powershell.Models.ICategoryQueryResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>API version.</summary>
        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryQueryResponseMetadata _metadata;

        /// <summary>Response metadata.</summary>
        public Nutanix.Powershell.Models.ICategoryQueryResponseMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for <see cref="Results" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType[] _results;

        public Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType[] Results
        {
            get
            {
                return this._results;
            }
            set
            {
                this._results = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryQueryResponse" /> instance.</summary>
        public CategoryQueryResponse()
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
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            if (Results != null ) {
                    for (int __i = 0; __i < Results.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Results[{__i}]", Results[__i]);
                    }
                  }
        }
    }
    /// Categories query response object.
    public partial interface ICategoryQueryResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.ICategoryQueryResponseMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType[] Results { get; set; }
    }
}