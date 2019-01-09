namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Cluster build details.</summary>
    public partial class BuildInfo : Nutanix.Powershell.Models.IBuildInfo, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="BuildType" /> property.</summary>
        private string _buildType;

        /// <summary>Build type, one of {dbg, opt, release}.</summary>
        public string BuildType
        {
            get
            {
                return this._buildType;
            }
            set
            {
                this._buildType = value;
            }
        }
        /// <summary>Backing field for <see cref="CommitDate" /> property.</summary>
        private System.DateTime? _commitDate;

        /// <summary>Date/time of the last commit.</summary>
        public System.DateTime? CommitDate
        {
            get
            {
                return this._commitDate;
            }
            set
            {
                this._commitDate = value;
            }
        }
        /// <summary>Backing field for <see cref="CommitId" /> property.</summary>
        private string _commitId;

        /// <summary>Last Git commit id which the build is based on.</summary>
        public string CommitId
        {
            get
            {
                return this._commitId;
            }
            set
            {
                this._commitId = value;
            }
        }
        /// <summary>Backing field for <see cref="FullVersion" /> property.</summary>
        private string _fullVersion;

        /// <summary>Full version name.</summary>
        public string FullVersion
        {
            get
            {
                return this._fullVersion;
            }
            set
            {
                this._fullVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="ShortCommitId" /> property.</summary>
        private string _shortCommitId;

        /// <summary>First 6 characters of the last Git commit id.</summary>
        public string ShortCommitId
        {
            get
            {
                return this._shortCommitId;
            }
            set
            {
                this._shortCommitId = value;
            }
        }
        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Numeric version. e.g. "5.5"</summary>
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        /// <summary>Creates an new <see cref="BuildInfo" /> instance.</summary>
        public BuildInfo()
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
            await eventListener.AssertNotNull(nameof(BuildType),BuildType);
            await eventListener.AssertNotNull(nameof(CommitId),CommitId);
            await eventListener.AssertNotNull(nameof(ShortCommitId),ShortCommitId);
            await eventListener.AssertNotNull(nameof(Version),Version);
        }
    }
    /// Cluster build details.
    public partial interface IBuildInfo : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string BuildType { get; set; }
        System.DateTime? CommitDate { get; set; }
        string CommitId { get; set; }
        string FullVersion { get; set; }
        string ShortCommitId { get; set; }
        string Version { get; set; }
    }
}