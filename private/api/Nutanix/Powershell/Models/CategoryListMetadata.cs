namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// All api calls that return a list will have this metadata block as input
    /// </summary>
    public partial class CategoryListMetadata : Nutanix.Powershell.Models.ICategoryListMetadata, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private string _filter;

        /// <summary>The filter in FIQL syntax used for the results.</summary>
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
        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
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
        /// <summary>Backing field for <see cref="Length" /> property.</summary>
        private int? _length;

        /// <summary>The number of records to retrieve relative to the offset</summary>
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
        /// <summary>Backing field for <see cref="Offset" /> property.</summary>
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
        /// <summary>Backing field for <see cref="SortAttribute" /> property.</summary>
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
        /// <summary>Backing field for <see cref="SortOrder" /> property.</summary>
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
        /// <summary>Creates an new <see cref="CategoryListMetadata" /> instance.</summary>
        public CategoryListMetadata()
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
            await eventListener.AssertIsGreaterThanOrEqual(nameof(Length),Length,1);
        }
    }
    /// All api calls that return a list will have this metadata block as input
    public partial interface ICategoryListMetadata : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Filter { get; set; }
        string Kind { get; set; }
        int? Length { get; set; }
        int? Offset { get; set; }
        string SortAttribute { get; set; }
        string SortOrder { get; set; }
    }
}