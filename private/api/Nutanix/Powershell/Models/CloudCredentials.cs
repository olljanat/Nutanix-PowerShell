namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cloud credentials spec</summary>
    public partial class CloudCredentials : Nutanix.Powershell.Models.ICloudCredentials, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>User friendly name for the credentials.</summary>
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
        /// <summary>Backing field for <see cref="Resources" /> property.</summary>
        private Nutanix.Powershell.Models.ICloudCredentialsResources _resources;

        /// <summary>Cloud credentials resources</summary>
        public Nutanix.Powershell.Models.ICloudCredentialsResources Resources
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
        /// <summary>Creates an new <see cref="CloudCredentials" /> instance.</summary>
        public CloudCredentials()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertNotNull(nameof(Resources), Resources);
            await eventListener.AssertObjectIsValid(nameof(Resources), Resources);
        }
    }
    /// Cloud credentials spec
    public partial interface ICloudCredentials : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Name { get; set; }
        Nutanix.Powershell.Models.ICloudCredentialsResources Resources { get; set; }
    }
}