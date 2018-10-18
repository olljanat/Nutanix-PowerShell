namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cmdlet to create an in-memory instance of the <see cref="Vm" /> object.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IVm))]
    public class NewVmObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="Vm" /></summary>
        private Sample.API.Models.IVm _vm = new Sample.API.Models.Vm();
        /// <summary>The kind name</summary>
        public string AvailabilityZoneReferenceKind
        {
            set
            {
                _vm.AvailabilityZoneReference = _vm.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vm.AvailabilityZoneReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceName
        {
            set
            {
                _vm.AvailabilityZoneReference = _vm.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vm.AvailabilityZoneReference.Name = value;
                _vm.AvailabilityZoneReference.Kind = "availability_zone";
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string AvailabilityZoneReferenceUuid
        {
            set
            {
                _vm.AvailabilityZoneReference = _vm.AvailabilityZoneReference ?? new Sample.API.Models.AvailabilityZoneReference();
                _vm.AvailabilityZoneReference.Uuid = value;
                _vm.AvailabilityZoneReference.Kind = "availability_zone";
            }
        }
        /// <summary>The kind name</summary>
        public string ClusterReferenceKind
        {
            set
            {
                _vm.ClusterReference = _vm.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vm.ClusterReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceName
        {
            set
            {
                _vm.ClusterReference = _vm.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vm.ClusterReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string ClusterReferenceUuid
        {
            set
            {
                _vm.ClusterReference = _vm.ClusterReference ?? new Sample.API.Models.ClusterReference();
                _vm.ClusterReference.Uuid = value;
            }
        }
        /// <summary>A description for vm.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "A description for vm.")]
        public string Description
        {
            set
            {
                _vm.Description = value;
            }
        }
        /// <summary>vm Name.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "vm Name.")]
        public string Name
        {
            set
            {
                _vm.Name = value;
            }
        }
        /// <summary>VM Resources Definition.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "VM Resources Definition.")]
        public Sample.API.Models.IVmResources Resources
        {
            set
            {
                _vm.Resources = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _vm.ClusterReference.Kind = "cluster";
            WriteObject(_vm);
        }
    }
}