using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements
{
    /// <summary>
    /// Represents a request for retrieving the regulatory requirements of a phone number.
    /// This request includes filters such as the phone number, requirement group ID, 
    /// country code, phone number type, and the action type.
    /// </summary>
    public class GetRegulatoryRequirementsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the phone number to check regulatory requirements for.
        /// The phone number is used to filter the regulatory requirements associated with it.
        /// </summary>
        [JsonPropertyName("filter[phone_number]")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the requirement group ID to check regulatory requirements for.
        /// This filter is used to narrow down the requirements to a specific group.
        /// </summary>
        [JsonPropertyName("filter[requirement_group_id]")]
        public string? RequirementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the country code (ISO2 format) to check regulatory requirements for.
        /// This allows filtering by the geographical region or country associated with the phone number.
        /// </summary>
        [JsonPropertyName("filter[country_code]")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number to check regulatory requirements for.
        /// Possible types include local, toll-free, mobile, national, and shared-cost.
        /// </summary>
        [JsonPropertyName("filter[phone_number_type]")]
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action type to check regulatory requirements for.
        /// Possible actions include "ordering", "porting", or "action" to define the type of action for which requirements are being checked.
        /// </summary>
        [JsonPropertyName("filter[action]")]
        public RequirementActionType? Action { get; set; }
    }
}