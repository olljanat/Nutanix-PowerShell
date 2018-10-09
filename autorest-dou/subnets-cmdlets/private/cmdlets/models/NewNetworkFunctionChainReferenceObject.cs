namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkFunctionChainReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkFunctionChainReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.INetworkFunctionChainReference))]
    public class NewNetworkFunctionChainReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkFunctionChainReference" /></summary>
        private Sample.API.Models.INetworkFunctionChainReference _networkFunctionChainReference = new Sample.API.Models.NetworkFunctionChainReference();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _networkFunctionChainReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _networkFunctionChainReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _networkFunctionChainReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_networkFunctionChainReference);
        }
    }
}