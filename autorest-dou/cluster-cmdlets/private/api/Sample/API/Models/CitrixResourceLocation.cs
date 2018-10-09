namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Resource Location on Citrix Cloud.</summary>
    public partial class CitrixResourceLocation : Sample.API.Models.ICitrixResourceLocation
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
        /// <summary>Creates an new <see cref="CitrixResourceLocation" /> instance.</summary>
        public CitrixResourceLocation()
        {
        }
    }
    /// Resource Location on Citrix Cloud.
    public partial interface ICitrixResourceLocation : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Id { get; set; }
        string Name { get; set; }
    }
}