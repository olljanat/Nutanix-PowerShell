using System.Management.Automation;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Nutanix {
  public class Vm {
    public Vm() {
    }
  }

  public class Util {
    // NOTE: only use this function during development.
    public static void TestOnlyIgnoreCerts() {
      ServicePointManager.ServerCertificateValidationCallback +=
        (sender, cert, chain, sslPolicyErrors) =>
        true;
    }

    public static void RestCall(
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
        var responseValue = string.Empty;

        if (response.StatusCode != HttpStatusCode.OK) {
          var message = String.Format("Request failed. StatusCode {0}", response.StatusCode);
          throw new ApplicationException(message);
        }

        // grab the response
        using (var responseStream = response.GetResponseStream()) {
          if (responseStream != null) {
            using (var reader = new StreamReader(responseStream)) {
              responseValue = reader.ReadToEnd();
            }
          }
        }

        // TODO: parse JSON
        Console.WriteLine(responseValue);
      }
    }
  }

  [CmdletAttribute(VerbsCommon.Get, "Vm")]
  public class GetVmCmdlet : Cmdlet {
    [Parameter()]
    public string Name {
      get { return name; }
      set { name = value; }
    }
    private string name;

    [Parameter()]
    public string Uuid {
      get { return uuid; }
      set { uuid = value; }
    }
    private string uuid;

    protected override void ProcessRecord() {
      if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(uuid)) {
        // If no params specified, then get all VMs.
        GetAllVms();
        return;
      }

      if (!String.IsNullOrEmpty(uuid)) {
        GetVmByUuid(uuid);
        return;
      }

      if (!String.IsNullOrEmpty(name)) {
        GetVmByName(name);
        return;
      }
    }

    public static void GetAllVms() {
      Util.RestCall("/vms/list", "POST", "{}");
    }

    // If no params specified, then get VM with 'name'.
    public static void GetVmByName(string name) {
      var requestBody = "{\"filter\": \"vm_name==" + name + "\"}";
      Util.RestCall("/vms/list", "POST", requestBody);
      // TODO: parse JSON response and then create Vm object.
      // WriteObject(new Vm("Trevor", "Sullivan"));
    }

    public static void GetVmByUuid(string uuid) {
      // TODO: validate using UUID regexes that 'uuid' is in correct format.
      Util.RestCall("/vms/" + uuid, "GET", "");
      // TODO: parse JSON response and then create Vm object.
      // WriteObject(new Vm("Trevor", "Sullivan"));
    }
  }
}
