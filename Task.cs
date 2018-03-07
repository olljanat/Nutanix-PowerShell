using System.Management.Automation;
using System;

namespace Nutanix {

public class Task {
  public string Uuid;
  public string Status;
  public string StartTime;
  public string CreationTime;
  public string CompletionTime;
  public string ProgressMessage;
  public string OperationType;
  public int PercentageComplete;
  public Task(dynamic json) {
    Uuid = json.uuid;
    Status = json.status;
    StartTime = json.start_time;
    CreationTime = json.creation_time;
    CompletionTime = json.completion_time;
    ProgressMessage = json.progress_message;
    OperationType = json.operation_type;
    PercentageComplete = json.percentage_complete;
  }
}

[CmdletAttribute(VerbsCommon.Get, "Task")]
public class GetTaskCmdlet : Cmdlet {
  [Parameter()]
  public string Uuid { get; set; } = "";

  [Parameter()]
  public Task Task { get; set; } = null;

  protected override void ProcessRecord() {
    if (!String.IsNullOrEmpty(Uuid)) {
      WriteObject(GetTaskByUuid(Uuid));
      return;
    }

    if (Task != null) {
      WriteObject(GetTaskByUuid(Task.Uuid));
      return;
    }

    throw new Exception("Expected either -Uuid or -Task");
  }

  public static Task GetTaskByUuid(string uuid) {
    // TODO: validate using UUID regexes that 'uuid' is in correct format.
    var json = Util.RestCall("/tasks/" + uuid, "GET", "" /* requestBody */);
    return new Task(json);
  }
}

}
