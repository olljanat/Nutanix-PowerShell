namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageMigrateInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageMigrateInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IImageMigrateInput))]
    public class NewImageMigrateInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageMigrateInput" /></summary>
        private Nutanix.Powershell.Models.IImageMigrateInput _imageMigrateInput = new Nutanix.Powershell.Models.ImageMigrateInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _imageMigrateInput.ClusterReference = _imageMigrateInput.ClusterReference ?? new Nutanix.Powershell.Models.ClusterReference();
                _imageMigrateInput.ClusterReference.Uuid = value;
            }
        }
        /// <summary>Reference to the images from PE cluster to be migrated</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Reference to the images from PE cluster to be migrated")]
        public Nutanix.Powershell.Models.IImageReference[] ImageReferenceList
        {
            set
            {
                _imageMigrateInput.ImageReferenceList = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_imageMigrateInput);
        }
    }
}