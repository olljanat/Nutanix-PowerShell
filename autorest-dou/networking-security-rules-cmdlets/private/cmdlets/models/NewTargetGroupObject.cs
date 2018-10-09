namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="TargetGroup" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"TargetGroupObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.ITargetGroup))]
    public class NewTargetGroupObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="TargetGroup" /></summary>
        private Sample.API.Models.ITargetGroup _targetGroup = new Sample.API.Models.TargetGroup();
        /// <summary>List of kinds associated with this filter.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "List of kinds associated with this filter.")]
        public string[] CategoryFilterKindList
        {
            set
            {
                _targetGroup.Filter = _targetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _targetGroup.Filter.KindList = value;
            }
        }
        /// <summary>A list of category key and list of values.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A list of category key and list of values.")]
        public System.Collections.Generic.IDictionary<string,string> CategoryFilterParams
        {
            set
            {
                _targetGroup.Filter = _targetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _targetGroup.Filter.Params = value;
            }
        }
        /// <summary>The type of the filter being used.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The type of the filter being used.")]
        public string CategoryFilterType
        {
            set
            {
                _targetGroup.Filter = _targetGroup.Filter ?? new Sample.API.Models.CategoryFilter();
                _targetGroup.Filter.Type = value;
            }
        }
        /// <summary>Default policy for communication within target group.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Default policy for communication within target group.")]
        public string DefaultInternalPolicy
        {
            set
            {
                _targetGroup.DefaultInternalPolicy = value;
            }
        }
        /// <summary>Way to identify the object for which rule is applied.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Way to identify the object for which rule is applied.")]
        public string PeerSpecificationType
        {
            set
            {
                _targetGroup.PeerSpecificationType = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_targetGroup);
        }
    }
}