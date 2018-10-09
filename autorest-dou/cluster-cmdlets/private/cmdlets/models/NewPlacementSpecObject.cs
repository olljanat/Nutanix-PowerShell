namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="PlacementSpec" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"PlacementSpecObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IPlacementSpec))]
    public class NewPlacementSpecObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="PlacementSpec" /></summary>
        private Sample.API.Models.IPlacementSpec _placementSpec = new Sample.API.Models.PlacementSpec();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ClusterReferenceKind
        {
            set
            {
                _placementSpec.ProbableClusterReference = _placementSpec.ProbableClusterReference ?? new Sample.API.Models.ClusterReference();
                _placementSpec.ProbableClusterReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName
        {
            set
            {
                _placementSpec.ProbableClusterReference = _placementSpec.ProbableClusterReference ?? new Sample.API.Models.ClusterReference();
                _placementSpec.ProbableClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _placementSpec.ProbableClusterReference = _placementSpec.ProbableClusterReference ?? new Sample.API.Models.ClusterReference();
                _placementSpec.ProbableClusterReference.Uuid = value;
            }
        }
        /// <summary>List of entity specs</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "List of entity specs")]
        public Sample.API.Models.IEntitySpec[] EntitySpecList
        {
            set
            {
                _placementSpec.EntitySpecList = value;
            }
        }
        /// <summary>UUID of the tenant</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "UUID of the tenant")]
        public string TenantUuid
        {
            set
            {
                _placementSpec.TenantUuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_placementSpec);
        }
    }
}