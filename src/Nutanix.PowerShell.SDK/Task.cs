using System;
using System.Management.Automation;

namespace Nutanix
{
  public class Task
  {
    public string Uuid
    {
      get;
      set;
    } = string.Empty;
    public string Status
    {
      get;
      set;
    } = string.Empty;
    public string StartTime
    {
      get;
      set;
    } = string.Empty;
    public string CreationTime
    {
      get;
      set;
    } = string.Empty;
    public string CompletionTime
    {
      get;
      set;
    } = string.Empty;
    public string ProgressMessage
    {
      get;
      set;
    } = string.Empty;
    public string OperationType
    {
      get;
      set;
    } = string.Empty;
    public int PercentageComplete
    {
      get;
      set;
    }
    public int DefaultPollTimeoutSecs
    {
      get;
      set;
    } = 2147483;
    public int DefaultPollIntervalMs = 500;
    public dynamic json
    {
      get;
      set;
    }
    public Task(dynamic json)
    {
      Uuid = json.uuid;
      Status = json.status;
      StartTime = json.start_time;
      CreationTime = json.creation_time;
      CompletionTime = json.completion_time;
      ProgressMessage = json.progress_message;
      OperationType = json.operation_type;
      PercentageComplete = json.percentage_complete;
      this.json = json;
    }

    public Task(string uuid)
    {
      Uuid = uuid;
    }

    public static Task FromUuidInJson(dynamic json)
    {
      return new Task(json.status.execution_context.task_uuid.ToString());
    }

    public Task Wait()
    {
      return Wait(DefaultPollTimeoutSecs);
    }

    public Task Wait(int timeoutSecs)
    {
      DateTime start = DateTime.Now;
      while ((DateTime.Now - start).TotalMilliseconds < timeoutSecs * 1000)
      {
        System.Threading.Thread.Sleep(DefaultPollIntervalMs);
        var task = GetTaskCmdlet.GetTaskByUuid(Uuid);
        if (task.Status != "RUNNING")
        {
          return task;
        }
      }
      return null;
    }
  }

  [CmdletAttribute(VerbsCommon.Get, "Task")]
  public class GetTaskCmdlet : Cmdlet
  {
    [Parameter]
    public string Uuid
    {
      get;
      set;
    } = string.Empty;

    [Parameter]
    public Task Task
    {
      get;
      set;
    }

    protected override void ProcessRecord()
    {
      if (!string.IsNullOrEmpty(Uuid))
      {
        WriteObject(GetTaskByUuid(Uuid));
        return;
      }

      if (Task != null)
      {
        WriteObject(GetTaskByUuid(Task.Uuid));
        return;
      }

      throw new Exception("Expected either -Uuid or -Task");
    }

    public static Task GetTaskByUuid(string uuid)
    {
      // TODO: validate using UUID regexes that 'uuid' is in correct format.
      var json = Util.RestCall("/tasks/" + uuid, "GET", string.Empty /* requestBody */ );
      return new Task(json);
    }
  }

}
