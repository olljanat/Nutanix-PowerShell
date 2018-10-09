namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// All api calls that return a list will have this metadata block
    /// </summary>
    public partial class ClusterListMetadataOutput : Sample.API.Models.IClusterListMetadataOutput
    {
        /// <summary>Backing field for Filter property</summary>
        private string _filter;

        /// <summary>The filter used for the results</summary>
        public string Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
            }
        }
        /// <summary>Backing field for Kind property</summary>
        private string _kind;

        /// <summary>The kind name</summary>
        public string Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }
        /// <summary>Backing field for Length property</summary>
        private int? _length;

        /// <summary>The number of records retrieved relative to the offset</summary>
        public int? Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        /// <summary>Backing field for Offset property</summary>
        private int? _offset;

        /// <summary>Offset from the start of the entity list</summary>
        public int? Offset
        {
            get
            {
                return this._offset;
            }
            set
            {
                this._offset = value;
            }
        }
        /// <summary>Backing field for SortAttribute property</summary>
        private string _sortAttribute;

        /// <summary>The attribute to perform sort on</summary>
        public string SortAttribute
        {
            get
            {
                return this._sortAttribute;
            }
            set
            {
                this._sortAttribute = value;
            }
        }
        /// <summary>Backing field for SortOrder property</summary>
        private string _sortOrder;

        /// <summary>The sort order in which results are returned</summary>
        public string SortOrder
        {
            get
            {
                return this._sortOrder;
            }
            set
            {
                this._sortOrder = value;
            }
        }
        /// <summary>Backing field for TotalMatches property</summary>
        private int? _totalMatches;

        /// <summary>Total matches found</summary>
        public int? TotalMatches
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
        /// <summary>Creates an new <see cref="ClusterListMetadataOutput" /> instance.</summary>
        public ClusterListMetadataOutput()
        {
        }
    }
    /// All api calls that return a list will have this metadata block
    public partial interface IClusterListMetadataOutput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Filter { get; set; }
        string Kind { get; set; }
        int? Length { get; set; }
        int? Offset { get; set; }
        string SortAttribute { get; set; }
        string SortOrder { get; set; }
        int? TotalMatches { get; set; }
    }
}