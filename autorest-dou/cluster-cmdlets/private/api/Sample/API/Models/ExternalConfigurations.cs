namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>External configurations for the connectors.</summary>
    public partial class ExternalConfigurations : Sample.API.Models.IExternalConfigurations, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CitrixConnectorConfig property</summary>
        private Sample.API.Models.ICitrixConnectorConfigDetails _citrixConnectorConfig;

        /// <summary>Citrix Connector details.</summary>
        public Sample.API.Models.ICitrixConnectorConfigDetails CitrixConnectorConfig
        {
            get
            {
                return this._citrixConnectorConfig;
            }
            set
            {
                this._citrixConnectorConfig = value;
            }
        }
        /// <summary>Creates an new <see cref="ExternalConfigurations" /> instance.</summary>
        public ExternalConfigurations()
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
            await eventListener.AssertObjectIsValid(nameof(CitrixConnectorConfig), CitrixConnectorConfig);
        }
    }
    /// External configurations for the connectors.
    public partial interface IExternalConfigurations : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.ICitrixConnectorConfigDetails CitrixConnectorConfig { get; set; }
    }
}