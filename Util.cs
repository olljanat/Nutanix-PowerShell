using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

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
