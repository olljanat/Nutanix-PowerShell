namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="TaskPollInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"TaskPollInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.ITaskPollInput))]
    public class NewTaskPollInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="TaskPollInput" /></summary>
        private Nutanix.Powershell.Models.ITaskPollInput _taskPollInput = new Nutanix.Powershell.Models.TaskPollInput();
        /// <summary>Poll timeout in seconds</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Poll timeout in seconds")]
        public int PollTimeoutSeconds
        {
            set
            {
                _taskPollInput.PollTimeoutSeconds = value;
            }
        }
        /// <summary>List of task UUIDs to poll on</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "List of task UUIDs to poll on")]
        public string[] TaskUuidList
        {
            set
            {
                _taskPollInput.TaskUuidList = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_taskPollInput);
        }
    }
}