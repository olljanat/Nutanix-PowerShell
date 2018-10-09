namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Customer information used in Certificate Signing Request for
    /// creating digital certificates.
    /// </summary>
    public partial class CertificationSigningInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="CertificationSigningInfo" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal CertificationSigningInfo(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _city = If( json?.PropertyT<Carbon.Json.JsonString>("city"), out var __jsonCity) ? (string)__jsonCity : (string)City;
            _commonName = If( json?.PropertyT<Carbon.Json.JsonString>("common_name"), out var __jsonCommonName) ? (string)__jsonCommonName : (string)CommonName;
            _commonNameSuffix = If( json?.PropertyT<Carbon.Json.JsonString>("common_name_suffix"), out var __jsonCommonNameSuffix) ? (string)__jsonCommonNameSuffix : (string)CommonNameSuffix;
            _countryCode = If( json?.PropertyT<Carbon.Json.JsonString>("country_code"), out var __jsonCountryCode) ? (string)__jsonCountryCode : (string)CountryCode;
            _emailAddress = If( json?.PropertyT<Carbon.Json.JsonString>("email_address"), out var __jsonEmailAddress) ? (string)__jsonEmailAddress : (string)EmailAddress;
            _organization = If( json?.PropertyT<Carbon.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)Organization;
            _state = If( json?.PropertyT<Carbon.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Sample.API.Models.ICertificationSigningInfo.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Sample.API.Models.ICertificationSigningInfo.</returns>
        public static Sample.API.Models.ICertificationSigningInfo FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CertificationSigningInfo(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="CertificationSigningInfo" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CertificationSigningInfo" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != City ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(City) : null, "city" ,container.Add );
            AddIf( null != CommonName ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CommonName) : null, "common_name" ,container.Add );
            AddIf( null != CommonNameSuffix ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CommonNameSuffix) : null, "common_name_suffix" ,container.Add );
            AddIf( null != CountryCode ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(CountryCode) : null, "country_code" ,container.Add );
            AddIf( null != EmailAddress ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(EmailAddress) : null, "email_address" ,container.Add );
            AddIf( null != Organization ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Organization) : null, "organization" ,container.Add );
            AddIf( null != State ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(State) : null, "state" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}