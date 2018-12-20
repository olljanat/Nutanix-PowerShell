namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category key definition.</summary>
    public partial class CategoryKey : Nutanix.Powershell.Models.ICategoryKey, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
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
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the category.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the category.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryKey" /> instance.</summary>
        public CategoryKey()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertMaximumLength(nameof(Description),Description,1000);
        }
    }
    /// Category key definition.
    public partial interface ICategoryKey : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Description { get; set; }
        string Name { get; set; }
    }
}