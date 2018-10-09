namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Multicluster config resources.</summary>
    public partial class MulticlusterConfigSpecResources : Sample.API.Models.IMulticlusterConfigSpecResources, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ExecutionPlan property</summary>
        private string _executionPlan;

        /// <summary>Execution plan for multiple requests.</summary>
        public string ExecutionPlan
        {
            get
            {
                return this._executionPlan;
            }
            set
            {
                this._executionPlan = value;
            }
        }
        /// <summary>Backing field for SpecList property</summary>
        private Sample.API.Models.IClusterIntentInput[] _specList;

        public Sample.API.Models.IClusterIntentInput[] SpecList
        {
            get
            {
                return this._specList;
            }
            set
            {
                this._specList = value;
            }
        }
        /// <summary>Backing field for UpgradeSchedule property</summary>
        private Sample.API.Models.IExecutionSchedule _upgradeSchedule;

        /// <summary>Execution schedule for requests.</summary>
        public Sample.API.Models.IExecutionSchedule UpgradeSchedule
        {
            get
            {
                return this._upgradeSchedule;
            }
            set
            {
                this._upgradeSchedule = value;
            }
        }
        /// <summary>Creates an new <see cref="MulticlusterConfigSpecResources" /> instance.</summary>
        public MulticlusterConfigSpecResources()
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
            await eventListener.AssertNotNull(nameof(ExecutionPlan),ExecutionPlan);
            await eventListener.AssertNotNull(nameof(SpecList), SpecList);
            if (SpecList != null ) {
                    for (int __i = 0; __i < SpecList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"SpecList[{__i}]", SpecList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(UpgradeSchedule), UpgradeSchedule);
        }
    }
    /// Multicluster config resources.
    public partial interface IMulticlusterConfigSpecResources : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ExecutionPlan { get; set; }
        Sample.API.Models.IClusterIntentInput[] SpecList { get; set; }
        Sample.API.Models.IExecutionSchedule UpgradeSchedule { get; set; }
    }
}