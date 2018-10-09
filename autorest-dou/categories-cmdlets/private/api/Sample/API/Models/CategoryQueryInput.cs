namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Categories query input object.</summary>
    public partial class CategoryQueryInput : Sample.API.Models.ICategoryQueryInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
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
        /// <summary>Backing field for CategoryFilter property</summary>
        private Sample.API.Models.ICategoryFilter _categoryFilter;

        /// <summary>A category filter.</summary>
        public Sample.API.Models.ICategoryFilter CategoryFilter
        {
            get
            {
                return this._categoryFilter;
            }
            set
            {
                this._categoryFilter = value;
            }
        }
        /// <summary>Backing field for GroupMemberCount property</summary>
        private long? _groupMemberCount;

        /// <summary>The maximum number of members to return per group.</summary>
        public long? GroupMemberCount
        {
            get
            {
                return this._groupMemberCount;
            }
            set
            {
                this._groupMemberCount = value;
            }
        }
        /// <summary>Backing field for GroupMemberOffset property</summary>
        private long? _groupMemberOffset;

        /// <summary>The offset into the total member set to return per group.</summary>
        public long? GroupMemberOffset
        {
            get
            {
                return this._groupMemberOffset;
            }
            set
            {
                this._groupMemberOffset = value;
            }
        }
        /// <summary>Backing field for UsageType property</summary>
        private string _usageType;

        /// <summary>
        /// USED_IN - to get policies in which specified categories are used.
        /// APPLIED_TO - to get entities attached to specified categories.
        /// </summary>
        public string UsageType
        {
            get
            {
                return this._usageType;
            }
            set
            {
                this._usageType = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryQueryInput" /> instance.</summary>
        public CategoryQueryInput()
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
            await eventListener.AssertObjectIsValid(nameof(CategoryFilter), CategoryFilter);
        }
    }
    /// Categories query input object.
    public partial interface ICategoryQueryInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Sample.API.Models.ICategoryFilter CategoryFilter { get; set; }
        long? GroupMemberCount { get; set; }
        long? GroupMemberOffset { get; set; }
        string UsageType { get; set; }
    }
}