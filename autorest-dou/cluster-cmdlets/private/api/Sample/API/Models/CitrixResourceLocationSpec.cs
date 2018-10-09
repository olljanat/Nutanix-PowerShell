namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Resource Location on Citrix Cloud.</summary>
    public partial class CitrixResourceLocationSpec : Sample.API.Models.ICitrixResourceLocationSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>The resource location id.</summary>
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>The resource location name.</summary>
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
        /// <summary>Creates an new <see cref="CitrixResourceLocationSpec" /> instance.</summary>
        public CitrixResourceLocationSpec()
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
            await eventListener.AssertMaximumLength(nameof(Name),Name,200);
            await eventListener.AssertMaximumLength(nameof(Id),Id,200);
        }
    }
    /// Resource Location on Citrix Cloud.
    public partial interface ICitrixResourceLocationSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Id { get; set; }
        string Name { get; set; }
    }
}