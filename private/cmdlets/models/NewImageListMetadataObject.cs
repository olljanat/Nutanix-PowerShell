namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ImageListMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"ImageListMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IImageListMetadata))]
    public class NewImageListMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ImageListMetadata" /></summary>
        private Nutanix.Powershell.Models.IImageListMetadata _imageListMetadata = new Nutanix.Powershell.Models.ImageListMetadata();
        /// <summary>The filter in FIQL syntax used for the results.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The filter in FIQL syntax used for the results.")]
        public string Filter
        {
            set
            {
                _imageListMetadata.Filter = value;
            }
        }
        /// <summary>The number of records to retrieve relative to the offset</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to retrieve relative to the offset")]
        public int Length
        {
            set
            {
                _imageListMetadata.Length = value;
            }
        }
        /// <summary>Offset from the start of the entity list</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offset from the start of the entity list")]
        public int Offset
        {
            set
            {
                _imageListMetadata.Offset = value;
            }
        }
        /// <summary>The attribute to perform sort on</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The attribute to perform sort on")]
        public string SortAttribute
        {
            set
            {
                _imageListMetadata.SortAttribute = value;
            }
        }
        /// <summary>The sort order in which results are returned</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sort order in which results are returned")]
        public string SortOrder
        {
            set
            {
                _imageListMetadata.SortOrder = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _imageListMetadata.Kind = "image";
            WriteObject(_imageListMetadata);
        }
    }
}