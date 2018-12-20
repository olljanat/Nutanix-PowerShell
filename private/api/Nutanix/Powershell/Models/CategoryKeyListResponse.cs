namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category key list response.</summary>
    public partial class CategoryKeyListResponse : Nutanix.Powershell.Models.ICategoryKeyListResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>Api Version.</summary>
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
        /// <summary>Backing field for <see cref="Entities" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryKeyStatus[] _entities;

        public Nutanix.Powershell.Models.ICategoryKeyStatus[] Entities
        {
            get
            {
                return this._entities;
            }
            set
            {
                this._entities = value;
            }
        }
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryListMetadata _metadata;

        /// <summary>
        /// All api calls that return a list will have this metadata block as input
        /// </summary>
        public Nutanix.Powershell.Models.ICategoryListMetadata Metadata
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
        /// <summary>Creates an new <see cref="CategoryKeyListResponse" /> instance.</summary>
        public CategoryKeyListResponse()
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
            if (Entities != null ) {
                    for (int __i = 0; __i < Entities.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Entities[{__i}]", Entities[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
        }
    }
    /// Category key list response.
    public partial interface ICategoryKeyListResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.ICategoryKeyStatus[] Entities { get; set; }
        Nutanix.Powershell.Models.ICategoryListMetadata Metadata { get; set; }
    }
}