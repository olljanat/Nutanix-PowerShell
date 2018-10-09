namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Spec for defining DHCP options.</summary>
    public partial class DhcpOptions : Sample.API.Models.IDhcpOptions, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for BootFileName property</summary>
        private string _bootFileName;

        public string BootFileName
        {
            get
            {
                return this._bootFileName;
            }
            set
            {
                this._bootFileName = value;
            }
        }
        /// <summary>Backing field for DomainName property</summary>
        private string _domainName;

        public string DomainName
        {
            get
            {
                return this._domainName;
            }
            set
            {
                this._domainName = value;
            }
        }
        /// <summary>Backing field for DomainNameServerList property</summary>
        private string[] _domainNameServerList;

        public string[] DomainNameServerList
        {
            get
            {
                return this._domainNameServerList;
            }
            set
            {
                this._domainNameServerList = value;
            }
        }
        /// <summary>Backing field for DomainSearchList property</summary>
        private string[] _domainSearchList;

        public string[] DomainSearchList
        {
            get
            {
                return this._domainSearchList;
            }
            set
            {
                this._domainSearchList = value;
            }
        }
        /// <summary>Backing field for TftpServerName property</summary>
        private string _tftpServerName;

        public string TftpServerName
        {
            get
            {
                return this._tftpServerName;
            }
            set
            {
                this._tftpServerName = value;
            }
        }
        /// <summary>Creates an new <see cref="DhcpOptions" /> instance.</summary>
        public DhcpOptions()
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
            if (DomainNameServerList != null ) {
                    for (int __i = 0; __i < DomainNameServerList.Length; __i++) {
                      await eventListener.AssertRegEx($"DomainNameServerList[{__i}]",DomainNameServerList[__i],@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
                    }
                  }
        }
    }
    /// Spec for defining DHCP options.
    public partial interface IDhcpOptions : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string BootFileName { get; set; }
        string DomainName { get; set; }
        string[] DomainNameServerList { get; set; }
        string[] DomainSearchList { get; set; }
        string TftpServerName { get; set; }
    }
}