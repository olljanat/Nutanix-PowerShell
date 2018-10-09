namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CategoryListMetadata" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"CategoryListMetadataObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.ICategoryListMetadata))]
    public class NewCategoryListMetadataObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CategoryListMetadata" /></summary>
        private Sample.API.Models.ICategoryListMetadata _categoryListMetadata = new Sample.API.Models.CategoryListMetadata();
        /// <summary>The filter in FIQL syntax used for the results.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The filter in FIQL syntax used for the results.")]
        public string Filter
        {
            set
            {
                _categoryListMetadata.Filter = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _categoryListMetadata.Kind = value;
            }
        }
        /// <summary>The number of records to retrieve relative to the offset</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The number of records to retrieve relative to the offset")]
        public int Length
        {
            set
            {
                _categoryListMetadata.Length = value;
            }
        }
        /// <summary>Offset from the start of the entity list</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Offset from the start of the entity list")]
        public int Offset
        {
            set
            {
                _categoryListMetadata.Offset = value;
            }
        }
        /// <summary>The attribute to perform sort on</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The attribute to perform sort on")]
        public string SortAttribute
        {
            set
            {
                _categoryListMetadata.SortAttribute = value;
            }
        }
        /// <summary>The sort order in which results are returned</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The sort order in which results are returned")]
        public string SortOrder
        {
            set
            {
                _categoryListMetadata.SortOrder = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_categoryListMetadata);
        }
    }
}