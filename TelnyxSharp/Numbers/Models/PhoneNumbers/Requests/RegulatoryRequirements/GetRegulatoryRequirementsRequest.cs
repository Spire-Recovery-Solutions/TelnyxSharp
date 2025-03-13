using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RegulatoryRequirements
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
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the requirement group ID to check regulatory requirements for.
        /// This filter is used to narrow down the requirements to a specific group.
        /// </summary>
        public string? RequirementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the country code (ISO2 format) to check regulatory requirements for.
        /// This allows filtering by the geographical region or country associated with the phone number.
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number to check regulatory requirements for.
        /// Possible types include local, toll-free, mobile, national, and shared-cost.
        /// </summary>
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action type to check regulatory requirements for.
        /// Possible actions include "ordering", "porting", or "action" to define the type of action for which requirements are being checked.
        /// </summary>
        public RequirementActionType? Action { get; set; }
    }
}