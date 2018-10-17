namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmVnumaConfig" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmVnumaConfigObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVmVnumaConfig))]
    public class NewVmVnumaConfigObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmVnumaConfig" /></summary>
        private Sample.API.Models.IVmVnumaConfig _vmVnumaConfig = new Sample.API.Models.VmVnumaConfig();
        /// <summary>Number of vNUMA nodes. 0 means vNUMA is disabled.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Number of vNUMA nodes. 0 means vNUMA is disabled.")]
        public long NumVnumaNodes
        {
            set
            {
                _vmVnumaConfig.NumVnumaNodes = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_vmVnumaConfig);
        }
    }
}