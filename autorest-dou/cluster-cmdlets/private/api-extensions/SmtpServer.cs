namespace Sample.API.Models
{

    /// <summary>SMTP Server.</summary>
    [System.ComponentModel.TypeConverter(typeof(SmtpServerTypeConverter))]
    public partial class SmtpServer
    {

        /// <summary>
        /// Creates a new instance of <see cref="SmtpServer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ISmtpServer FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// SMTP Server.
    [System.ComponentModel.TypeConverter(typeof(SmtpServerTypeConverter))]
    public partial interface ISmtpServer {

    }
}