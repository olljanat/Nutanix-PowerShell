namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="NetworkFunctionChainReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"NetworkFunctionChainReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.INetworkFunctionChainReference))]
    public class NewNetworkFunctionChainReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="NetworkFunctionChainReference" /></summary>
        private Nutanix.Powershell.Models.INetworkFunctionChainReference _networkFunctionChainReference = new Nutanix.Powershell.Models.NetworkFunctionChainReference();
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
            _networkFunctionChainReference.Kind = "network_function_chain_reference";
            WriteObject(_networkFunctionChainReference);
        }
    }
}