namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class CategoryQueryResponseResultsItemType : Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="EntityAnyReferenceList" /> property.</summary>
        private Nutanix.Powershell.Models.IEntityReference[] _entityAnyReferenceList;

        /// <summary>List of entity references.</summary>
        public Nutanix.Powershell.Models.IEntityReference[] EntityAnyReferenceList
        {
            get
            {
                return this._entityAnyReferenceList;
            }
            set
            {
                this._entityAnyReferenceList = value;
            }
        }
        /// <summary>Backing field for <see cref="FilteredEntityCount" /> property.</summary>
        private long? _filteredEntityCount;

        /// <summary>Total number of filtered results.</summary>
        public long? FilteredEntityCount
        {
            get
            {
                return this._filteredEntityCount;
            }
            set
            {
                this._filteredEntityCount = value;
            }
        }
        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>The entity kind.</summary>
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
        /// <summary>Backing field for <see cref="TotalEntityCount" /> property.</summary>
        private long? _totalEntityCount;

        /// <summary>Total number of the matched results.</summary>
        public long? TotalEntityCount
        {
            get
            {
                return this._totalEntityCount;
            }
            set
            {
                this._totalEntityCount = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryQueryResponseResultsItemType" /> instance.</summary>
        public CategoryQueryResponseResultsItemType()
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
            if (EntityAnyReferenceList != null ) {
                    for (int __i = 0; __i < EntityAnyReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"EntityAnyReferenceList[{__i}]", EntityAnyReferenceList[__i]);
                    }
                  }
        }
    }
    public partial interface ICategoryQueryResponseResultsItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IEntityReference[] EntityAnyReferenceList { get; set; }
        long? FilteredEntityCount { get; set; }
        string Kind { get; set; }
        long? TotalEntityCount { get; set; }
    }
}