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
  public class Vm {
    public string Name;
    public string Uuid;
    public Vm(dynamic json) {
      Name = json.spec.name;
      Uuid = json.metadata.uuid;
    }
  }

  public class Util {
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

      // TODO: we should be checking certificates...
      TestOnlyIgnoreCerts();

      // TODO: arg ClusterIp
      var request = WebRequest.Create(
        "https://feature-c1:9440/api/nutanix/v3" + urlPath);

      request.Method = requestMethod;
      request.PreAuthenticate = true;
      string username = "admin"; // XXX
      string password = "Nutanix.123"; // XXX
      var encoding = System.Text.Encoding.GetEncoding("UTF-8");
      var encodedAuth = encoding.GetBytes(username + ":" + password);
      String authHeader = System.Convert.ToBase64String(encodedAuth);
      request.Headers.Add("Authorization", "Basic " + authHeader);
      request.Headers.Add("Content-Type","application/json");
      request.Headers.Add("Accept", "application/json");

      if (!string.IsNullOrEmpty(requestBody) && requestMethod.Equals("POST")) {
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
    public static void GetAllVms() {
      Util.RestCall("/vms/list", "POST", "{}");
    }

    // If no params specified, then get VM with 'name'.
    // REST: /vms/list
    public static Vm GetVmByName(string name) {
      var reqBody = "{\"filter\": \"vm_name==" + name + "\"}";
      var json = Util.RestCall("/vms/list", "POST", reqBody);
      // TODO: check len of 'entities'.
      return new Vm(json.entities[0]);
    }

    // Get Vm using 'uuid'.
    // REST: /vms/{uuid}
    public static Vm GetVmByUuid(string uuid) {
      // TODO: validate using UUID regexes that 'uuid' is in correct format.
      var json = Util.RestCall("/vms/" + uuid, "GET", "" /* requestBody */);
      return new Vm(json.entities[0]);
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
      Util.RestCall("/vms/" + vm.Uuid, "DELETE", "" /* requestBody */);
    }
  }
}
