namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>CA chain spec</summary>
    public partial class CaChainSpec : Nutanix.Powershell.Models.ICaChainSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="CaChain" /> property.</summary>
        private byte[] _caChain;

        /// <summary>Content of CA chain</summary>
        public byte[] CaChain
        {
            get
            {
                return this._caChain;
            }
            set
            {
                this._caChain = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the CA Chain file</summary>
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
        /// <summary>Creates an new <see cref="CaChainSpec" /> instance.</summary>
        public CaChainSpec()
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
            await eventListener.AssertNotNull(nameof(CaChain),CaChain);
        }
    }
    /// CA chain spec
    public partial interface ICaChainSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        byte[] CaChain { get; set; }
        string Name { get; set; }
    }
}