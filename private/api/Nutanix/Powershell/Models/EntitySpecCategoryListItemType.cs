namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class EntitySpecCategoryListItemType : Nutanix.Powershell.Models.IEntitySpecCategoryListItemType
    {
        /// <summary>Backing field for <see cref="CategoryName" /> property.</summary>
        private string _categoryName;

        /// <summary>Name of the category.</summary>
        public string CategoryName
        {
            get
            {
                return this._categoryName;
            }
            set
            {
                this._categoryName = value;
            }
        }
        /// <summary>Backing field for <see cref="CategoryValue" /> property.</summary>
        private string _categoryValue;

        /// <summary>Category value.</summary>
        public string CategoryValue
        {
            get
            {
                return this._categoryValue;
            }
            set
            {
                this._categoryValue = value;
            }
        }
        /// <summary>Creates an new <see cref="EntitySpecCategoryListItemType" /> instance.</summary>
        public EntitySpecCategoryListItemType()
        {
        }
    }
    public partial interface IEntitySpecCategoryListItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string CategoryName { get; set; }
        string CategoryValue { get; set; }
    }
}