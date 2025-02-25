using System.Text.Json.Serialization;
using Telnyx.NET.Converters;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Represents the sorting criteria for requirements in the Telnyx API.
    /// This enumeration is used to specify how requirement data should be sorted, 
    /// with each option corresponding to a specific attribute of the requirements.
    /// </summary>
    [JsonConverter(typeof(RequirementSortConverter))]
    public enum RequirementSort
    {
        /// <summary>
        /// Sorts requirements based on the action to be performed.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("action")]
        Action,

        /// <summary>
        /// Sorts requirements based on the country code associated with the requirement.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("country_code")]
        CountryCode,

        /// <summary>
        /// Sorts requirements based on the locality or geographical region.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("locality")]
        Locality,

        /// <summary>
        /// Sorts requirements based on the type of phone number, such as mobile or toll-free.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("phone_number_type")]
        PhoneNumberType
    }
}