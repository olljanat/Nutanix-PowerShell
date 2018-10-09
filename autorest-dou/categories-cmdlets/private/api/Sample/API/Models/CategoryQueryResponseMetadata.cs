namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response metadata.</summary>
    public partial class CategoryQueryResponseMetadata : Sample.API.Models.ICategoryQueryResponseMetadata
    {
        /// <summary>Backing field for GroupMemberCount property</summary>
        private long? _groupMemberCount;

        /// <summary>The maximum number of records to return per group.</summary>
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

        /// <summary>
        /// The offset into the total records set to return per group.
        /// </summary>
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
        /// <summary>Backing field for TotalMatches property</summary>
        private long? _totalMatches;

        /// <summary>Total number of matched results.</summary>
        public long? TotalMatches
        {
            get
            {
                return this._totalMatches;
            }
            set
            {
                this._totalMatches = value;
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
        /// <summary>Creates an new <see cref="CategoryQueryResponseMetadata" /> instance.</summary>
        public CategoryQueryResponseMetadata()
        {
        }
    }
    /// Response metadata.
    public partial interface ICategoryQueryResponseMetadata : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        long? GroupMemberCount { get; set; }
        long? GroupMemberOffset { get; set; }
        long? TotalMatches { get; set; }
        string UsageType { get; set; }
    }
}