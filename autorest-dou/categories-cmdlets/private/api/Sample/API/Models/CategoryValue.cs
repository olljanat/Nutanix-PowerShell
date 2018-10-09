namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Category value definition.</summary>
    public partial class CategoryValue : Sample.API.Models.ICategoryValue, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for Value property</summary>
        private string _value;

        /// <summary>Value for the category.</summary>
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
        /// <summary>Creates an new <see cref="CategoryValue" /> instance.</summary>
        public CategoryValue()
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
            await eventListener.AssertMaximumLength(nameof(Description),Description,1000);
            await eventListener.AssertMaximumLength(nameof(Value),Value,64);
        }
    }
    /// Category value definition.
    public partial interface ICategoryValue : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        string Description { get; set; }
        string Value { get; set; }
    }
}