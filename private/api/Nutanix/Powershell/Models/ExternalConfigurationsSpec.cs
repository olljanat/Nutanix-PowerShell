namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>External configurations for the connectors.</summary>
    public partial class ExternalConfigurationsSpec : Nutanix.Powershell.Models.IExternalConfigurationsSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CitrixConnectorConfig" /> property.</summary>
        private Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec _citrixConnectorConfig;

        /// <summary>Citrix Connector details.</summary>
        public Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec CitrixConnectorConfig
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
        /// <summary>Creates an new <see cref="ExternalConfigurationsSpec" /> instance.</summary>
        public ExternalConfigurationsSpec()
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
    public partial interface IExternalConfigurationsSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.ICitrixConnectorConfigDetailsSpec CitrixConnectorConfig { get; set; }
    }
}