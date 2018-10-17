namespace Sample.API.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="AvailabilityZoneReference" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AvailabilityZoneReferenceObject")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IAvailabilityZoneReference))]
    public class NewAvailabilityZoneReferenceObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="AvailabilityZoneReference" /></summary>
        private Sample.API.Models.IAvailabilityZoneReference _availabilityZoneReference = new Sample.API.Models.AvailabilityZoneReference();
        /// <summary>The kind name</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The kind name")]
        public string Kind
        {
            set
            {
                _availabilityZoneReference.Kind = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "HELP MESSAGE MISSING")]
        public string Name
        {
            set
            {
                _availabilityZoneReference.Name = value;
            }
        }
        /// <summary>HELP MESSAGE MISSING</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "HELP MESSAGE MISSING")]
        public string Uuid
        {
            set
            {
                _availabilityZoneReference.Uuid = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_availabilityZoneReference);
        }
    }
}