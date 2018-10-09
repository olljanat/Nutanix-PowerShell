namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster Definition.</summary>
    public partial class Cluster : Sample.API.Models.ICluster, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Cluster Name.</summary>
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
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IClusterResources _resources;

        /// <summary>Cluster resources.</summary>
        public Sample.API.Models.IClusterResources Resources
        {
            get
            {
                return this._resources;
            }
            set
            {
                this._resources = value;
            }
        }
        /// <summary>Creates an new <see cref="Cluster" /> instance.</summary>
        public Cluster()
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
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Cluster Definition.
    public partial interface ICluster : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Name { get; set; }
        Sample.API.Models.IClusterResources Resources { get; set; }
    }
}