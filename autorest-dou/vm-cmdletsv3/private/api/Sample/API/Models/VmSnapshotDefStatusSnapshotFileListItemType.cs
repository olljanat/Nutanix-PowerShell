namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class VmSnapshotDefStatusSnapshotFileListItemType : Sample.API.Models.IVmSnapshotDefStatusSnapshotFileListItemType
    {
        /// <summary>Backing field for FilePath property</summary>
        private string _filePath;

        /// <summary>
        /// Pathname of the file that participated in the snapshot.
        /// </summary>
        public string FilePath
        {
            get
            {
                return this._filePath;
            }
            set
            {
                this._filePath = value;
            }
        }
        /// <summary>Backing field for SnapshotFilePath property</summary>
        private string _snapshotFilePath;

        /// <summary>Pathname of the snapshot of the file.</summary>
        public string SnapshotFilePath
        {
            get
            {
                return this._snapshotFilePath;
            }
            set
            {
                this._snapshotFilePath = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="VmSnapshotDefStatusSnapshotFileListItemType" /> instance.
        /// </summary>
        public VmSnapshotDefStatusSnapshotFileListItemType()
        {
        }
    }
    public partial interface IVmSnapshotDefStatusSnapshotFileListItemType : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string FilePath { get; set; }
        string SnapshotFilePath { get; set; }
    }
}