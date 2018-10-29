namespace Nutanix.Powershell.Models
{

    /// <summary>Task details</summary>
    [System.ComponentModel.TypeConverter(typeof(TaskTypeConverter))]
    public partial class Task
    {

        /// <summary>
        /// Creates a new instance of <see cref="Task" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ITask FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Task details
    [System.ComponentModel.TypeConverter(typeof(TaskTypeConverter))]
    public partial interface ITask {

    }
}