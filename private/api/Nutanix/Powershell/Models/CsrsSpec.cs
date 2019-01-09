namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Spec for CSRs download. If node uuid list is empty, all cluster nodes will
    /// be assumed.
    /// </summary>
    public partial class CsrsSpec : Nutanix.Powershell.Models.ICsrsSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="NodeUuidList" /> property.</summary>
        private string[] _nodeUuidList;

        public string[] NodeUuidList
        {
            get
            {
                return this._nodeUuidList;
            }
            set
            {
                this._nodeUuidList = value;
            }
        }
        /// <summary>Creates an new <see cref="CsrsSpec" /> instance.</summary>
        public CsrsSpec()
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
            if (NodeUuidList != null ) {
                    for (int __i = 0; __i < NodeUuidList.Length; __i++) {
                      await eventListener.AssertRegEx($"NodeUuidList[{__i}]",NodeUuidList[__i],@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                    }
                  }
        }
    }
    /// Spec for CSRs download. If node uuid list is empty, all cluster nodes will
    /// be assumed.
    public partial interface ICsrsSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string[] NodeUuidList { get; set; }
    }
}