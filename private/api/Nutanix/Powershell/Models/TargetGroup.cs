namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Target group</summary>
    public partial class TargetGroup : Nutanix.Powershell.Models.ITargetGroup, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="DefaultInternalPolicy" /> property.</summary>
        private string _defaultInternalPolicy;

        /// <summary>Default policy for communication within target group.</summary>
        public string DefaultInternalPolicy
        {
            get
            {
                return this._defaultInternalPolicy;
            }
            set
            {
                this._defaultInternalPolicy = value;
            }
        }
        /// <summary>Backing field for <see cref="Filter" /> property.</summary>
        private Nutanix.Powershell.Models.ICategoryFilter _filter;

        /// <summary>The set of categories that matching VMs need to have.</summary>
        public Nutanix.Powershell.Models.ICategoryFilter Filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
            }
        }
        /// <summary>Backing field for <see cref="PeerSpecificationType" /> property.</summary>
        private string _peerSpecificationType;

        /// <summary>Way to identify the object for which rule is applied.</summary>
        public string PeerSpecificationType
        {
            get
            {
                return this._peerSpecificationType;
            }
            set
            {
                this._peerSpecificationType = value;
            }
        }
        /// <summary>Creates an new <see cref="TargetGroup" /> instance.</summary>
        public TargetGroup()
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
            await eventListener.AssertObjectIsValid(nameof(Filter), Filter);
        }
    }
    /// Target group
    public partial interface ITargetGroup : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string DefaultInternalPolicy { get; set; }
        Nutanix.Powershell.Models.ICategoryFilter Filter { get; set; }
        string PeerSpecificationType { get; set; }
    }
}