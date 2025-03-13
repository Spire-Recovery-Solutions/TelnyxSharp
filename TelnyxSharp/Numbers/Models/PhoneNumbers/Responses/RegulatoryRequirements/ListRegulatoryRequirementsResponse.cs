using System.Text.Json.Serialization;
using TelnyxSharp.Models;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RegulatoryRequirements
{
    /// <summary>
    /// Represents the response containing a list of regulatory requirements data for phone numbers.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> where T is a list of <see cref="ListRegulatoryRequirementsData"/>.
    /// </summary>
    public class ListRegulatoryRequirementsResponse : TelnyxResponse<ListRegulatoryRequirementsData>
    {
    }

    /// <summary>
    /// Represents the data for regulatory requirements associated with a phone number, including region information, phone number type, and associated regulatory requirements.
    /// </summary>
    public class ListRegulatoryRequirementsData
    {
        /// <summary>
        /// Gets or sets the phone number associated with the regulatory requirements.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the phone number type (e.g., local, toll-free, mobile).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the region information related to the phone number, including geographic and regulatory details.
        /// </summary>
        [JsonPropertyName("region_information")]
        public List<RegionInformation>? RegionInformation { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the phone number (e.g., individual, business).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirements associated with the phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<RequirementDetail>? RegulatoryRequirements { get; set; }
    }
}