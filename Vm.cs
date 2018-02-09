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
        "https://10.7.255.141:9440/api/nutanix/v3" + urlPath);

      request.Method = requestMethod;
      request.PreAuthenticate = true;
      string username = "admin";
      string password = "Nutanix.123";
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
    [Parameter(Position = 0, Mandatory = false)]
    public string VmName {
      get { return vmName; }
      set { vmName = value; }
    }
    private string vmName;

    protected override void ProcessRecord() {
      // If no params specified, then get all VMs.
      // TODO: use the convenience function for "isNullOrEmpty"
      if (vmName == null || vmName.Length == 0) {
        Util.RestCall("/vms/list", "POST", "{}");
      } else {
        // WriteObject(new Vm("Trevor", "Sullivan"));
        Console.WriteLine("Hello World! " + vmName); // XXX
      }
    }
  }
}
