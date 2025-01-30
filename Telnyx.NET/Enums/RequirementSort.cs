using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the sorting criteria for requirements in the Telnyx API.
    /// This enumeration is used to specify how requirement data should be sorted, 
    /// with each option corresponding to a specific attribute of the requirements.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequirementSort
    {
        /// <summary>
        /// Sorts requirements based on the action to be performed.
        /// </summary>
        [JsonPropertyName("action")]
        Action,

        /// <summary>
        /// Sorts requirements based on the country code associated with the requirement.
        /// </summary>
        [JsonPropertyName("country_code")]
        CountryCode,

        /// <summary>
        /// Sorts requirements based on the locality or geographical region.
        /// </summary>
        [JsonPropertyName("locality")]
        Locality,

        /// <summary>
        /// Sorts requirements based on the type of phone number, such as mobile or toll-free.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        PhoneNumberType
    }
}