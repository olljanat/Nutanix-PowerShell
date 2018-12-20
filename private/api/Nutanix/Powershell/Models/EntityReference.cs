namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Reference to an entity.</summary>
    public partial class EntityReference : Nutanix.Powershell.Models.IEntityReference, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private System.Collections.Generic.IDictionary<string,string> _categories;

        /// <summary>Categories for the entity.</summary>
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            get
            {
                return this._categories;
            }
            set
            {
                this._categories = value;
            }
        }
        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Kind of the reference.</summary>
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
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the entity.</summary>
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
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of filter being used.</summary>
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
        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>UUID of the entity.</summary>
        public string Uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }
        /// <summary>Creates an new <see cref="EntityReference" /> instance.</summary>
        public EntityReference()
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
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// Reference to an entity.
    public partial interface IEntityReference : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.IDictionary<string,string> Categories { get; set; }
        string Kind { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Uuid { get; set; }
    }
}