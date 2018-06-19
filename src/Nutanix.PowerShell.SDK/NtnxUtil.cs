// Copyright 2018 (c) Nutanix. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the repository root for full license information.
// Purpose: Utility source for 'Nutanix.PowerShell.SDK'
// Author: Nutanix
// Copyright: Nutanix, 2018
// Owner: PowerShell@nutanix.com
// Maintainer(s):
//   Jon Kohler  (Nutanix, JonKohler)
//   Alex Guo    (Nutanix, mallochine)

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Newtonsoft.Json;

namespace Nutanix.PowerShell.SDK
{
  public static class NtnxUtil
  {
    public static string Server { get; set; }

    // Holds username and password.
    // TODO: might need to GC PSCreds.Password (SecureString) using Dispose
    // method.
    public static System.Management.Automation.PSCredential PSCreds { get; set; }

    // NOTE: only use this function during development.
    public static void TestOnlyIgnoreCerts()
    {
      ServicePointManager.ServerCertificateValidationCallback +=
        (sender, cert, chain, sslPolicyErrors) =>
        true;
    }

    // Returns the JSON response a string. Responsibility of caller to parse.
    public static dynamic RestCall(
      string path,
      string requestMethod,
      string requestBody)
    {
      if (string.IsNullOrEmpty(Server) || NtnxUtil.PSCreds == null)
      {
        // TODO: throw exception.
        return null;
      }

      Uri baseUri = new Uri("https://" + NtnxUtil.Server + ":9440/api/nutanix/v3/");
      Uri callUri = new Uri(baseUri, path);
      var request = WebRequest.Create(callUri);
      request.Method = requestMethod;
      request.PreAuthenticate = true;
      var creds = NtnxUtil.PSCreds.GetNetworkCredential();
      string username = creds.UserName;
      string password = creds.Password;
      var encoding = System.Text.Encoding.GetEncoding("UTF-8");
      var encodedAuth = encoding.GetBytes(username + ":" + password);
      string authHeader = System.Convert.ToBase64String(encodedAuth);
      request.Headers.Add("Authorization", "Basic " + authHeader);
      request.Headers.Add("Content-Type", "application/json");
      request.Headers.Add("Accept", "application/json");
      request.Headers.Add("X-Nutanix-Client-Type", "Nutanix.PowerShell.SDK");

      if (NtnxUtil.PassThroughNonNull(requestBody))
      {
        var bytes = Encoding.GetEncoding("UTF-8").GetBytes(requestBody);
        request.ContentLength = bytes.Length;
        using (var writeStream = request.GetRequestStream())
        {
          writeStream.Write(bytes, 0, bytes.Length);
        }
      }

      try
      {
        using (var response = (HttpWebResponse)request.GetResponse())
        {
          if (response.StatusCode != HttpStatusCode.OK &&
            response.StatusCode != HttpStatusCode.Accepted)
          {
            var message = string.Format(CultureInfo.InvariantCulture, "Request failed. StatusCode {0}", response.StatusCode);
            throw new NtnxException(message);
          }

          // grab the response
          using (Stream responseStream = response.GetResponseStream())
          {
            if (responseStream != null)
            {
              using (StreamReader reader = new StreamReader(responseStream))
              {
                return JsonConvert.DeserializeObject(reader.ReadToEnd());
              }
            }
          }
        }
      }
      catch (WebException e)
      {
        if (e.Status == WebExceptionStatus.ProtocolError)
        {
          var message = string.Format(CultureInfo.InvariantCulture, "Status Code : {0}\nStatus Description : {1}", ((HttpWebResponse)e.Response).StatusCode, ((HttpWebResponse)e.Response).StatusDescription);
          Console.WriteLine(message);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      return null;
    }

    public static T[] FromJson<T>(dynamic json, Func<dynamic, T> creator)
    {
      return ((IEnumerable<T>)Enumerable.Select(json.entities, (Func<dynamic, T>)(entity => creator(entity)))).ToArray();
    }

    public static dynamic PassThroughNonNull(string nullcheck)
    {
      if (nullcheck == null)
      {
        throw new NtnxException();
      }

      return nullcheck;
    }
  }
}
