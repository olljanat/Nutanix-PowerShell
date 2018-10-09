namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Specification of the entities which need to be placed</summary>
    public partial class EntitySpec : Sample.API.Models.IEntitySpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CategoryList property</summary>
        private Sample.API.Models.IEntitySpecCategoryListItemType[] _categoryList;

        /// <summary>Categories associated with the entity.</summary>
        public Sample.API.Models.IEntitySpecCategoryListItemType[] CategoryList
        {
            get
            {
                return this._categoryList;
            }
            set
            {
                this._categoryList = value;
            }
        }
        /// <summary>Backing field for VmReference property</summary>
        private Sample.API.Models.IVmReference _vmReference;

        /// <summary>Reference to a VM</summary>
        public Sample.API.Models.IVmReference VmReference
        {
            get
            {
                return this._vmReference;
            }
            set
            {
                this._vmReference = value;
            }
        }
        /// <summary>Backing field for VmSpec property</summary>
        private Sample.API.Models.IVm _vmSpec;

        /// <summary>VM config specification</summary>
        public Sample.API.Models.IVm VmSpec
        {
            get
            {
                return this._vmSpec;
            }
            set
            {
                this._vmSpec = value;
            }
        }
        /// <summary>Creates an new <see cref="EntitySpec" /> instance.</summary>
        public EntitySpec()
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
            if (CategoryList != null ) {
                    for (int __i = 0; __i < CategoryList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"CategoryList[{__i}]", CategoryList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(VmReference), VmReference);
            await eventListener.AssertObjectIsValid(nameof(VmSpec), VmSpec);
        }
    }
    /// Specification of the entities which need to be placed
    public partial interface IEntitySpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IEntitySpecCategoryListItemType[] CategoryList { get; set; }
        Sample.API.Models.IVmReference VmReference { get; set; }
        Sample.API.Models.IVm VmSpec { get; set; }
    }
}