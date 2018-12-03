namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Subnet" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"SubnetObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ISubnet))]
    public class NewSubnetObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Subnet" /></summary>
        private Nutanix.Powershell.Models.ISubnet _subnet = new Nutanix.Powershell.Models.Subnet();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string AvailabilityZoneReferenceKind
        {
            set
            {
                _subnet.AvailabilityZoneReference = _subnet.AvailabilityZoneReference ?? new Nutanix.Powershell.Models.AvailabilityZoneReference();
                _subnet.AvailabilityZoneReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceName
        {
            set
            {
                _subnet.AvailabilityZoneReference = _subnet.AvailabilityZoneReference ?? new Nutanix.Powershell.Models.AvailabilityZoneReference();
                _subnet.AvailabilityZoneReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceUuid
        {
            set
            {
                _subnet.AvailabilityZoneReference = _subnet.AvailabilityZoneReference ?? new Nutanix.Powershell.Models.AvailabilityZoneReference();
                _subnet.AvailabilityZoneReference.Uuid = value;
            }
        }
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string ClusterReferenceKind
        {
            set
            {
                _subnet.ClusterReference = _subnet.ClusterReference ?? new Nutanix.Powershell.Models.ClusterReference();
                _subnet.ClusterReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName
        {
            set
            {
                _subnet.ClusterReference = _subnet.ClusterReference ?? new Nutanix.Powershell.Models.ClusterReference();
                _subnet.ClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _subnet.ClusterReference = _subnet.ClusterReference ?? new Nutanix.Powershell.Models.ClusterReference();
                _subnet.ClusterReference.Uuid = value;
            }
        }
        /// <summary>A description for subnet.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A description for subnet.")]
        public string Description
        {
            set
            {
                _subnet.Description = value;
            }
        }
        /// <summary>subnet Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "subnet Name.")]
        public string Name
        {
            set
            {
                _subnet.Name = value;
            }
        }
        /// <summary>Subnet creation/modification spec.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Subnet creation/modification spec.")]
        public Nutanix.Powershell.Models.ISubnetResources Resources
        {
            set
            {
                _subnet.Resources = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_subnet);
        }
    }
}