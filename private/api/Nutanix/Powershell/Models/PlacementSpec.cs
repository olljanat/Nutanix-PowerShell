namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Entity placement spec</summary>
    public partial class PlacementSpec : Nutanix.Powershell.Models.IPlacementSpec, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="EntitySpecList" /> property.</summary>
        private Nutanix.Powershell.Models.IEntitySpec[] _entitySpecList;

        /// <summary>List of entity specs</summary>
        public Nutanix.Powershell.Models.IEntitySpec[] EntitySpecList
        {
            get
            {
                return this._entitySpecList;
            }
            set
            {
                this._entitySpecList = value;
            }
        }
        /// <summary>Backing field for <see cref="ProbableClusterReference" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterReference _probableClusterReference;

        /// <summary>
        /// Probable cluster reference recommendation from the client side.
        /// This will contain the probable PE cluster UUID, where we want to
        /// replicate/failback the entity. Scheduler service will use this as one
        /// of the decision making parameter.
        /// </summary>
        public Nutanix.Powershell.Models.IClusterReference ProbableClusterReference
        {
            get
            {
                return this._probableClusterReference;
            }
            set
            {
                this._probableClusterReference = value;
            }
        }
        /// <summary>Backing field for <see cref="TenantUuid" /> property.</summary>
        private string _tenantUuid;

        /// <summary>UUID of the tenant</summary>
        public string TenantUuid
        {
            get
            {
                return this._tenantUuid;
            }
            set
            {
                this._tenantUuid = value;
            }
        }
        /// <summary>Creates an new <see cref="PlacementSpec" /> instance.</summary>
        public PlacementSpec()
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
            await eventListener.AssertNotNull(nameof(EntitySpecList), EntitySpecList);
            if (EntitySpecList != null ) {
                    for (int __i = 0; __i < EntitySpecList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"EntitySpecList[{__i}]", EntitySpecList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(ProbableClusterReference), ProbableClusterReference);
            await eventListener.AssertRegEx(nameof(TenantUuid),TenantUuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// Entity placement spec
    public partial interface IPlacementSpec : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IEntitySpec[] EntitySpecList { get; set; }
        Nutanix.Powershell.Models.IClusterReference ProbableClusterReference { get; set; }
        string TenantUuid { get; set; }
    }
}