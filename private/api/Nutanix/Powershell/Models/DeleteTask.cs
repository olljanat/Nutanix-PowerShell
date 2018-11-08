namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    /// </summary>
    public partial class DeleteTask : Nutanix.Powershell.Models.IDeleteTask, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            internal set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.IVmMetadata _metadata;

        /// <summary>The delete task metadata</summary>
        public Nutanix.Powershell.Models.IVmMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            internal set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for <see cref="Spec" /> property.</summary>
        private string _spec;

        /// <summary>The spec information</summary>
        public string Spec
        {
            get
            {
                return this._spec;
            }
            internal set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Nutanix.Powershell.Models.IDeleteStatus _status;

        public Nutanix.Powershell.Models.IDeleteStatus Status
        {
            get
            {
                return this._status;
            }
            internal set
            {
                this._status = value;
            }
        }
    
        /// <summary>Creates an new <see cref="DeleteTask" /> instance.</summary>
        public DeleteTask()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
        }
    }
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    public partial interface IDeleteTask : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get;  }
        Nutanix.Powershell.Models.IVmMetadata Metadata { get;  }

        string Spec { get; }

        Nutanix.Powershell.Models.IDeleteStatus Status { get;}

  
    }
}