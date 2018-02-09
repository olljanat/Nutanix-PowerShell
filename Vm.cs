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
      String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));
      // String encoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("UTF-8").GetBytes(username + ":" + password));
      request.Headers.Add("Authorization", "Basic " + encoded);
      request.Headers.Add("Content-Type","application/json");
      request.Headers.Add("Accept", "application/json");

      if (!string.IsNullOrEmpty(requestBody) && requestMethod.Equals("POST")) {
        var encoding = new UTF8Encoding();
        // var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(requestBody);
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

    protected override void ProcessRecord() {
      if (String.IsNullOrEmpty(name)) {
        // If no params specified, then get all VMs.
        Util.RestCall("/vms/list", "POST", "{}");
      } else {
        // If no params specified, then get VM with 'name'.
        var requestBody = "{\"filter\": \"vm_name==" + name + "\"}";
        Util.RestCall("/vms/list", "POST", requestBody);
        // TODO: parse JSON response and then create Vm object.
        // WriteObject(new Vm("Trevor", "Sullivan"));
      }
    }
  }
}
