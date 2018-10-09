namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Execution schedule for requests.</summary>
    public partial class ExecutionSchedule : Sample.API.Models.IExecutionSchedule
    {
        /// <summary>Backing field for StartTime property</summary>
        private System.DateTime _startTime;

        /// <summary>Start time to execute a request.</summary>
        public System.DateTime StartTime
        {
            get
            {
                return this._startTime;
            }
            set
            {
                this._startTime = value;
            }
        }
        /// <summary>Backing field for TimeZone property</summary>
        private string _timeZone;

        /// <summary>Name of specified time zone.</summary>
        public string TimeZone
        {
            get
            {
                return this._timeZone;
            }
            set
            {
                this._timeZone = value;
            }
        }
        /// <summary>Backing field for TimeoutSecs property</summary>
        private long? _timeoutSecs;

        /// <summary>Time out in seconds for a request execution.</summary>
        public long? TimeoutSecs
        {
            get
            {
                return this._timeoutSecs;
            }
            set
            {
                this._timeoutSecs = value;
            }
        }
        /// <summary>Creates an new <see cref="ExecutionSchedule" /> instance.</summary>
        public ExecutionSchedule()
        {
        }
    }
    /// Execution schedule for requests.
    public partial interface IExecutionSchedule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.DateTime StartTime { get; set; }
        string TimeZone { get; set; }
        long? TimeoutSecs { get; set; }
    }
}