using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;

public class Util {
  public static string server { get; set; } = string.Empty;

  // Holds username and password.
  // TODO: might need to GC pscreds.Password (SecureString) using Dispose
  // method.
  public static System.Management.Automation.PSCredential pscreds;

  // NOTE: only use this function during development.
  public static void TestOnlyIgnoreCerts () {
    ServicePointManager.ServerCertificateValidationCallback +=
      (sender, cert, chain, sslPolicyErrors) =>
      true;
  }

  // Returns the JSON response a string. Responsibility of caller to parse.
  public static dynamic RestCall (
    string urlPath,
    string requestMethod,
    string requestBody) {

    if (string.IsNullOrEmpty (server) || Util.pscreds == null) {
      // TODO: throw exception.
      return null;
    }

    var request = WebRequest.Create (
      "https://" + Util.server + ":9440/api/nutanix/v3" + urlPath);
    request.Method = requestMethod;
    request.PreAuthenticate = true;
    var creds = Util.pscreds.GetNetworkCredential ();
    string username = creds.UserName;
    string password = creds.Password;
    var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
    var encodedAuth = encoding.GetBytes (username + ":" + password);
    string authHeader = System.Convert.ToBase64String (encodedAuth);
    request.Headers.Add ("Authorization", "Basic " + authHeader);
    request.Headers.Add ("Content-Type", "application/json");
    request.Headers.Add ("Accept", "application/json");
    request.Headers.Add ("X-Nutanix-Client-Type", "Nutanix.PowerShell.SDK");

    if (!string.IsNullOrEmpty (requestBody)) {
      var bytes = Encoding.GetEncoding ("UTF-8").GetBytes (requestBody);
      request.ContentLength = bytes.Length;
      using (var writeStream = request.GetRequestStream ()) {
        writeStream.Write (bytes, 0, bytes.Length);
      }
    }

    try {
      using (var response = (HttpWebResponse) request.GetResponse ()) {
        if (response.StatusCode != HttpStatusCode.OK &&
          response.StatusCode != HttpStatusCode.Accepted) {
          var message = string.Format (
            "Request failed. StatusCode {0}", response.StatusCode);
          throw new ApplicationException (message);
        }

        // grab the response
        using (var responseStream = response.GetResponseStream ()) {
          if (responseStream != null) {
            using (var reader = new StreamReader (responseStream)) {
              return JsonConvert.DeserializeObject (reader.ReadToEnd ());
            }
          }
        }
      }
    } catch (WebException ex) {
      var response = (HttpWebResponse) ex.Response;
      using (var responseStream = response.GetResponseStream ()) {
        if (responseStream != null) {
          using (var reader = new StreamReader (responseStream)) {
            var json = JsonConvert.DeserializeObject (reader.ReadToEnd ());
            // Print request + response to help user debug.
            Console.WriteLine (requestMethod + " " + urlPath + ":\n" +
              requestBody);
            Console.WriteLine (json.ToString ());
          }
        }
      }
      throw ex;
    }

    return null;
  }

  public static void PrintTrace (
    string urlPath,
    string requestMethod,
    string requestBody) {
    Console.WriteLine (requestMethod + " " + urlPath);
    Console.WriteLine (requestBody);
  }

  public static string RestCallTrace (
    string urlPath,
    string requestMethod,
    string requestBody) {
    return requestMethod + " " + urlPath + "\n" + requestBody;
  }

  // TODO:
  public static bool IsValidUuid (string uuid) {
    // Validate 'uuid' string.
    return true;
  }

  public static T[] FromJson<T> (dynamic json, Func<dynamic, T> creator) {
    return ((IEnumerable<T>) Enumerable.Select (json.entities,
      (Func<dynamic, T>) (entity => creator (entity)))).ToArray ();
  }
}