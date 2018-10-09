namespace Sample.API.Models
{

    /// <summary>FIXME: Class EntitySpecCategoryListItemType is MISSING DESCRIPTION</summary>
    [System.ComponentModel.TypeConverter(typeof(EntitySpecCategoryListItemTypeTypeConverter))]
    public partial class EntitySpecCategoryListItemType
    {

        /// <summary>
        /// Creates a new instance of <see cref="EntitySpecCategoryListItemType" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.IEntitySpecCategoryListItemType FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// FIXME: Interface IEntitySpecCategoryListItemType is MISSING DESCRIPTION
    [System.ComponentModel.TypeConverter(typeof(EntitySpecCategoryListItemTypeTypeConverter))]
    public partial interface IEntitySpecCategoryListItemType {

    }
}