using System.Management.Automation;
using System;

namespace Nutanix {

public class Image {
  public string Name;
  public string Id;

  // 'Uid' is VMware's equivalent field for Nutanix's Uuid.
  public string Uid;
  public string Uuid;
  public dynamic json;

  // TODO Mtu, NumPorts, ExtensionData, NumPortsAvailable, Key, Nic, VMHostId,
  // VMHost, VMHostUid, Nic

  public Image(dynamic json) {
    // Special property 'json' stores the original json.
    this.json = json;
    this.json.Property("status").Remove();
    this.json.api_version = "3.1";

    Name = json.spec.name;
    Uuid = json.metadata.uuid;
    Uid = Uuid;
  }
}

[CmdletAttribute(VerbsCommon.New, "Image")]
public class NewImageCmdlet : Cmdlet {
  [Parameter()]
  public string Name { get; set; } = "";

  [Parameter()]
  public string URL { get; set; } = "";

  [Parameter()]
  public string Description { get; set; } = "";

  // Prints out REST URL and then exits. Does not make REST call.
  [Parameter()]
  public SwitchParameter Trace
  {
    get { return trace; }
    set { trace = value; }
  }
  private bool trace;

  [Parameter()]
  public SwitchParameter RunAsync
  {
    get { return runAsync; }
    set { runAsync = value; }
  }
  private bool runAsync;

  protected override void ProcessRecord() {
    var url = "/images";
    var method = "POST";
    var str = @"{
      ""api_version"": ""3.0"",
      ""metadata"": {
        ""kind"": ""image"",
        ""name"": """ + Name + @"""
      },
      ""spec"": {
        ""description"": """ + Description + @""",
        ""name"": """ + Name + @""",
        ""resources"": {
          ""image_type"": ""DISK_IMAGE"",
          ""source_uri"": """ + URL + @"""
        }
      }
    }";

    if (trace) {
      Console.WriteLine(method + " " + url);
      Console.WriteLine(str);
      return;
    }
    var task = Task.FromUuidInJson(Util.RestCall(url, method, str));
    if (runAsync) {
      WriteObject(task);
    } else {
      WriteObject(task.Wait());
    }
  }
}

[CmdletAttribute(VerbsCommon.Get, "Image")]
public class GetImageCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  [Parameter()]
  public string Name { get; set; } = "";

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetImageByUuid(Uuid));
      return;
    }

    if (!String.IsNullOrEmpty(Name)) {
      WriteObject(GetImageByName(Name));
      return;
    }

    WriteObject(GetAllImages());
  }

  public static Image GetImageByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/images/" + uuid, "GET", "" /* requestBody */);
    return new Image(json);
  }

  // If no params specified, then get image with 'name'.
  // REST: /images/list
  public static Image GetImageByName(string name) {
    var reqBody = "{\"filter\": \"name==" + name + "\"}";
    var json = Util.RestCall("/images/list", "POST", reqBody);
    if (json.entities.Count == 0) {
      return null;
    }
    return new Image(json.entities[0]);
  }


  public static Image[] GetAllImages() {
    var json = Util.RestCall("/images/list", "POST", "{}");
    if (json.entities.Count == 0) {
      return new Image[0];
    }
    Image[] images = new Image[json.entities.Count];
    for (int i = 0; i < json.entities.Count; ++i) {
      images[i] = new Image(json.entities[i]);
    }
    return images;
  }
}

[CmdletAttribute(VerbsCommon.Remove, "Image")]
public class DeleteImageCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      // TODO: WriteObject Task
      DeleteImageByUuid(Uuid);
      return;
    }
  }

  public static void DeleteImageByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    Util.RestCall("/images/" + uuid, "DELETE", "" /* requestBody */);
  }
}

[CmdletAttribute(VerbsCommon.Set, "Image")]
public class SetImageCmdlet : Cmdlet {
  [Parameter(Mandatory=true)]
  public Image Image { get; set; } = null;

  [Parameter()]
  public string Name { get; set; } = null;

  [Parameter()]
  public SwitchParameter RunAsync
  {
    get { return runAsync; }
    set { runAsync = value; }
  }
  private bool runAsync;

  protected override void ProcessRecord() {
    if (Name != null) {
      Image.json.spec.name = Name;
    }
    Image.json.api_version = "3.1";
    var task = Task.FromUuidInJson(
      Util.RestCall("/images/" + Image.Uuid, "PUT", Image.json.ToString())));
    if (runAsync) {
      WriteObject(task);
    } else {
      WriteObject(task.Wait());
    }
  }
}

}
