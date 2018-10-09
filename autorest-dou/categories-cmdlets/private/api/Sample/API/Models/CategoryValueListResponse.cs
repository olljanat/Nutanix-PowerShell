namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category Value list response.</summary>
    public partial class CategoryValueListResponse : Sample.API.Models.ICategoryValueListResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

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
        /// <summary>Backing field for Entities property</summary>
        private Sample.API.Models.ICategoryValueStatus[] _entities;

        public Sample.API.Models.ICategoryValueStatus[] Entities
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
        /// <summary>Backing field for Metadata property</summary>
        private Sample.API.Models.ICategoryListMetadata _metadata;

        /// <summary>
        /// All api calls that return a list will have this metadata block as input
        /// </summary>
        public Sample.API.Models.ICategoryListMetadata Metadata
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
        /// <summary>Creates an new <see cref="CategoryValueListResponse" /> instance.</summary>
        public CategoryValueListResponse()
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
    /// Category Value list response.
    public partial interface ICategoryValueListResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.ICategoryValueStatus[] Entities { get; set; }
        Sample.API.Models.ICategoryListMetadata Metadata { get; set; }
    }
}