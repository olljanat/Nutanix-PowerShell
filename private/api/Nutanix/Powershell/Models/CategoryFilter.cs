namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>A category filter.</summary>
    public partial class CategoryFilter : Nutanix.Powershell.Models.ICategoryFilter
    {
        /// <summary>Backing field for <see cref="KindList" /> property.</summary>
        private string[] _kindList;

        /// <summary>List of kinds associated with this filter.</summary>
        public string[] KindList
        {
            get
            {
                return this._kindList;
            }
            set
            {
                this._kindList = value;
            }
        }
        /// <summary>Backing field for <see cref="Params" /> property.</summary>
        private System.Collections.Generic.IDictionary<string,string> _params;

        /// <summary>A list of category key and list of values.</summary>
        public System.Collections.Generic.IDictionary<string,string> Params
        {
            get
            {
                return this._params;
            }
            set
            {
                this._params = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the filter being used.</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryFilter" /> instance.</summary>
        public CategoryFilter()
        {
        }
    }
    /// A category filter.
    public partial interface ICategoryFilter : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string[] KindList { get; set; }
        System.Collections.Generic.IDictionary<string,string> Params { get; set; }
        string Type { get; set; }
    }
}