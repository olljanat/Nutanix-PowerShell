namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ClusterReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ClusterReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IClusterReference))]
    public class NewClusterReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ClusterReference" /></summary>
        private Nutanix.Powershell.Models.IClusterReference _clusterReference = new Nutanix.Powershell.Models.ClusterReference();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _clusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _clusterReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _clusterReference.Kind = "cluster";
            WriteObject(_clusterReference);
        }
    }
}