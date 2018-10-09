namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Specification for multicluster configuration request.</summary>
    public partial class MulticlusterConfigSpec : Sample.API.Models.IMulticlusterConfigSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Resources property</summary>
        private Sample.API.Models.IMulticlusterConfigSpecResources _resources;

        /// <summary>Multicluster config resources.</summary>
        public Sample.API.Models.IMulticlusterConfigSpecResources Resources
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
        /// <summary>Creates an new <see cref="MulticlusterConfigSpec" /> instance.</summary>
        public MulticlusterConfigSpec()
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
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Specification for multicluster configuration request.
    public partial interface IMulticlusterConfigSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IMulticlusterConfigSpecResources Resources { get; set; }
    }
}