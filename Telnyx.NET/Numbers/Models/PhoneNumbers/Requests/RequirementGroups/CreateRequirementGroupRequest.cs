using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.RequirementGroups
{
    /// <summary>
    /// Represents a request to create a requirement group for phone numbers.
    /// This includes details about the country, phone number type, action, and regulatory requirements.
    /// </summary>
    public class CreateRequirementGroupRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code associated with the phone numbers.
        /// Example: "US" for the United States.
        /// </summary>
        [JsonPropertyName("country_code")]
        public required string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number for this requirement group.
        /// Example: Geographic, TollFree, etc.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public required PhoneNumberType PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the action type for this requirement group.
        /// Example: Provisioning or other valid actions.
        /// </summary>
        [JsonPropertyName("action")]
        public required RequirementActionType? Action { get; set; }

        /// <summary>
        /// Gets or sets an optional customer reference for tracking or identification purposes.
        /// Example: "Customer12345".
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirements associated with this request.
        /// This includes documents or information required for provisioning or compliance.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<UpdateRegulatoryRequirement>? RegulatoryRequirements { get; set; }
    }
}
