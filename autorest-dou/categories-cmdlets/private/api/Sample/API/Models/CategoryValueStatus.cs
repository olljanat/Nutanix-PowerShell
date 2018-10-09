namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category value definition.</summary>
    public partial class CategoryValueStatus : Sample.API.Models.ICategoryValueStatus, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Description property</summary>
        private string _description;

        /// <summary>Description of the category value.</summary>
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
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>The name of the category.</summary>
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
        /// <summary>Backing field for SystemDefined property</summary>
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
        /// <summary>Backing field for Value property</summary>
        private string _value;

        /// <summary>The value of the category.</summary>
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="CategoryValueStatus" /> instance.</summary>
        public CategoryValueStatus()
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
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertMaximumLength(nameof(Description),Description,1000);
            await eventListener.AssertMaximumLength(nameof(Value),Value,64);
        }
    }
    /// Category value definition.
    public partial interface ICategoryValueStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Description { get; set; }
        string Name { get; set; }
        bool? SystemDefined { get; set; }
        string Value { get; set; }
    }
}