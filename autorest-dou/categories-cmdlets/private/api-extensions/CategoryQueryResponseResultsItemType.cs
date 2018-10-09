namespace Sample.API.Models
{

    /// <summary>FIXME: Class CategoryQueryResponseResultsItemType is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseResultsItemTypeTypeConverter))]
    public partial class CategoryQueryResponseResultsItemType
    {

        /// <summary>
        /// Creates a new instance of <see cref="CategoryQueryResponseResultsItemType" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.ICategoryQueryResponseResultsItemType FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface ICategoryQueryResponseResultsItemType is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(CategoryQueryResponseResultsItemTypeTypeConverter))]
    public partial interface ICategoryQueryResponseResultsItemType {

    }
}