using System.Management.Automation;
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

// This is the exception that VMware's PowerCLI throws on error.
public class VimException : Exception {
  public VimException():base() { }
  public VimException (string message): base(message) { }
}

namespace Nutanix {

// VMware's struct definition.
// https://www.vmware.com/support/developer/PowerCLI/PowerCLI41U1/html/VirtualMachine.html
public class Vm {
  public const string PowerState_ON = "ON";
  public const string PowerState_OFF = "OFF";

  public string Name;
  public string Uuid;
  public string HardwareClockTimezone;
  public int? NumSockets;
  public int? MemoryMB;
  public int? NumVcpusPerSocket;
  public dynamic json;
  public Vm(dynamic json) {

    // Special property 'json' stores the original json.
    this.json = json;
    this.json.Property("status").Remove();
    this.json.api_version = "3.1";

    // Fill in field.
    Name = json.spec.name;
    NumSockets = json.spec.resources.num_sockets;
    MemoryMB = json.spec.resources.memory_size_mib;
    NumVcpusPerSocket = json.spec.resources.num_vcpus_per_socket;
    HardwareClockTimezone = json.spec.resources.hardware_clock_timezone;
    Uuid = json.metadata.uuid;
  }
}

public class Util {
  public static string server;

  // Holds username and password.
  // TODO: might need to GC pscreds.Password (SecureString) using Dispose
  // method.
  public static System.Management.Automation.PSCredential pscreds;

  // NOTE: only use this function during development.
  public static void TestOnlyIgnoreCerts() {
    ServicePointManager.ServerCertificateValidationCallback +=
      (sender, cert, chain, sslPolicyErrors) =>
      true;
  }

  // Returns the JSON response a string. Responsibility of caller to parse.
  public static dynamic RestCall(
    string urlPath,
    string requestMethod,
    string requestBody) {

    if (String.IsNullOrEmpty(server) || Util.pscreds == null) {
      // TODO: throw exception.
      return null;
    }

    var request = WebRequest.Create(
      "https://" + Util.server + ":9440/api/nutanix/v3" + urlPath);
    request.Method = requestMethod;
    request.PreAuthenticate = true;
    var creds = Util.pscreds.GetNetworkCredential();
    string username = creds.UserName;
    string password = creds.Password;
    var encoding = System.Text.Encoding.GetEncoding("UTF-8");
    var encodedAuth = encoding.GetBytes(username + ":" + password);
    String authHeader = System.Convert.ToBase64String(encodedAuth);
    request.Headers.Add("Authorization", "Basic " + authHeader);
    request.Headers.Add("Content-Type","application/json");
    request.Headers.Add("Accept", "application/json");

    if (!string.IsNullOrEmpty(requestBody)) {
      var bytes = Encoding.GetEncoding("UTF-8").GetBytes(requestBody);
      request.ContentLength = bytes.Length;
      using (var writeStream = request.GetRequestStream()) {
        writeStream.Write(bytes, 0, bytes.Length);
      }
    }

    using (var response = (HttpWebResponse) request.GetResponse()) {
      if (response.StatusCode != HttpStatusCode.OK &&
          response.StatusCode != HttpStatusCode.Accepted) {
        var message = String.Format(
          "Request failed. StatusCode {0}", response.StatusCode);
        throw new ApplicationException(message);
      }

      // grab the response
      using (var responseStream = response.GetResponseStream()) {
        if (responseStream != null) {
          using (var reader = new StreamReader(responseStream)) {
            return JsonConvert.DeserializeObject(reader.ReadToEnd());
          }
        }
      }
    }
    return null;
  }

  // TODO:
  public static bool IsValidUuid(string uuid) {
    // Validate 'uuid' string.
    return true;
  }
}

[CmdletAttribute(VerbsCommon.New, "NTNX")]
public class ConnectNTNX : Cmdlet {
  [Parameter()]
  public string Server { get; set; } = "";

  [Parameter()]
  public string UserName { get; set; } = "";

  // TODO: note that 'Password' should be the result of
  // 'ConvertTo-SecureString'
  [Parameter()]
  public System.Security.SecureString Password { get; set; } =
    new System.Security.SecureString();

  [Parameter()]
  public SwitchParameter AcceptInvalidSslCerts
  {
    get { return acceptInvalidSslCerts; }
    set { acceptInvalidSslCerts = value; }
  }
  private bool acceptInvalidSslCerts;

  protected override void ProcessRecord() {
    Connect(Server, UserName, Password, acceptInvalidSslCerts);
  }

  // Save authentication info.
  public static void Connect(
    string server, string username, System.Security.SecureString password,
    bool acceptinvalidsslcerts) {

    if (acceptinvalidsslcerts) {
      Util.TestOnlyIgnoreCerts();
    }
    Util.server = server;
    Util.pscreds = new System.Management.Automation.PSCredential(
      username, password);
  }
}

[CmdletAttribute(VerbsCommon.New, "Vm")]
public class NewVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public int MemorySizeMib { get; set; } = 1024; // 1 GiB

  [Parameter()]
  public int NumSockets { get; set; } = 1;

  [Parameter()]
  public int NumVcpusPerSocket { get; set; } = 1;

  [Parameter()]
  public string PowerState { get; set; } = "OFF";

  // TODO: remove Mandatory. Allow a user to get image uuid via name.
  [Parameter(Mandatory=true)]
  public string ImageUuid { get; set; } = "";

  // TODO: allow creation of non-networked VMs by creating 'nic_list' iff
  // 'NetworkUuid' was passed in.
  [Parameter(Mandatory=true)]
  public string NetworkUuid { get; set; } = "";

  protected override void ProcessRecord() {
    // TODO: make cluster_reference required if talking to PC. But not needed
    // if talking to PE.
    Util.RestCall("/vms", "POST", @"{
      ""api_version"": ""3.0"",
      ""metadata"": {
        ""kind"": ""vm""
      },
      ""spec"": {
        ""resources"": {
          ""memory_size_mib"": " + MemorySizeMib.ToString() + @",
          ""num_vcpus_per_socket"": " + NumVcpusPerSocket.ToString() + @",
          ""num_sockets"": " + NumSockets.ToString() + @",
          ""power_state"": """ + PowerState + @""",
          ""disk_list"": [
            {
              ""data_source_reference"": {
                ""kind"": ""image"",
                ""uuid"": """ + ImageUuid + @"""
              },
              ""device_properties"": {
                ""device_type"": ""DISK""
              }
            }
          ],
          ""nic_list"": [
            {
              ""subnet_reference"": {
                ""kind"": ""subnet"",
                ""uuid"": """ + NetworkUuid + @"""
              }
            }
          ]
        },
        ""name"": """ + Name + @"""
      }
    }");
  }
}

[CmdletAttribute(VerbsCommon.Get, "Vm")]
public class GetVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Uuid)) {
      // If no params specified, then get all VMs.
      GetAllVms();
      return;
    }

    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetVmByUuid(Uuid));
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      WriteObject(GetVmByName(Name));
      return;
    }
  }

  // Grab all VMs.
  // REST: /vms/list
  public static Vm[] GetAllVms() {
    var json = Util.RestCall("/vms/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Vm[0];
    }
    Vm[] vms = new Vm[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      vms[i] = new Vm(json.entities[i]);
    }
    return vms;
  }

  // If no params specified, then get VM with 'name'.
  // REST: /vms/list
  public static Vm GetVmByName(string name) {
    var reqBody = "{\"filter\": \"vm_name==" + name + "\"}";
    var json = Util.RestCall("/vms/list", "POST", reqBody);
    if (json.entities.Count == 0) {
      return null;
    }
    return new Vm(json.entities[0]);
  }

  // Get Vm using 'uuid'.
  // REST: /vms/{uuid}
  public static Vm GetVmByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/vms/" + uuid, "GET", "" /* requestBody */);
    return new Vm(json);
  }
}

[CmdletAttribute("Start", "Vm")]
public class StartVmCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  [Parameter()]
  public Vm VM { get; set; } = null;

  protected override void ProcessRecord() {
    // TODO: maybe should not rely on 'json' to generate request?
    VM.json.spec.resources.power_state = Vm.PowerState_ON;
    VM.json.api_version = "3.1";
    // TODO: return Task object from the RestCall.
    Util.RestCall("/vms/" + VM.Uuid, "PUT", VM.json.ToString());
  }
}

[CmdletAttribute(VerbsCommon.Remove, "Vm")]
public class RemoveVmCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Uuid)) {
      // TODO: return error
      return;
    }

    if (!String.IsNullOrEmpty(Uuid)) {
      // TODO: WriteObject Task
      DeleteVmByUuid(Uuid);
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      // TODO: WriteObject Task
      DeleteVmByName(Name);
      return;
    }
  }

  // Delete Vm using 'uuid'.
  // REST: /vms/{uuid}
  public static void DeleteVmByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    Util.RestCall("/vms/" + uuid, "DELETE", "" /* requestBody */);
  }

  // If no params specified, then get VM with 'name'.
  // REST: /vms/list
  public static void DeleteVmByName(string name) {
    var vm = GetVmCmdlet.GetVmByName(name);
    if (vm != null) {
      // Util.RestCall("/vms/" + vm.uuid, "DELETE", "" /* requestBody */);
      Util.RestCall("/vms/" + vm.Uuid, "DELETE", "" /* requestBody */);
    }
  }
}

}
