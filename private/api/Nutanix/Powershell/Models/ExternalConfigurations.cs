namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>External configurations for the connectors.</summary>
    public partial class ExternalConfigurations : Nutanix.Powershell.Models.IExternalConfigurations, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CitrixConnectorConfig" /> property.</summary>
        private Nutanix.Powershell.Models.ICitrixConnectorConfigDetails _citrixConnectorConfig;

        /// <summary>Citrix Connector details.</summary>
        public Nutanix.Powershell.Models.ICitrixConnectorConfigDetails CitrixConnectorConfig
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
        Nutanix.Powershell.Models.ICitrixConnectorConfigDetails CitrixConnectorConfig { get; set; }
    }
}