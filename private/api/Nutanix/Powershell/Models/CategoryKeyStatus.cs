namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category Key Definition.</summary>
    public partial class CategoryKeyStatus : Nutanix.Powershell.Models.ICategoryKeyStatus, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for <see cref="SystemDefined" /> property.</summary>
        private bool? _systemDefined;

        /// <summary>Specifying whether its a system defined category.</summary>
        public bool? SystemDefined
        {
            get
            {
                return this._systemDefined;
            }
            set
            {
                this._systemDefined = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryKeyStatus" /> instance.</summary>
        public CategoryKeyStatus()
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
    /// Category Key Definition.
    public partial interface ICategoryKeyStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        bool? SystemDefined { get; set; }
    }
}