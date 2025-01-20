using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response received when creating a number order in the Telnyx API.
    /// </summary>
    public class CreateNumberOrderResponse : TelnyxResponse<CreateNumberOrderResponseData>
    {
    }

    /// <summary>
    /// Contains detailed information about a created number order.
    /// Provides various fields such as the phone numbers count,
    /// creation date, order status, and more.
    /// </summary>
    public class CreateNumberOrderResponseData
    {
        /// <summary>
        /// Number of phone numbers in the order.
        /// </summary>
        [JsonPropertyName("phone_numbers_count")]
        public long PhoneNumbersCount { get; set; }

        /// <summary>
        /// Indicates if all requirements have been met for the order.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// The timestamp when the order was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier for the order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Optional customer reference provided during order creation.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Messaging profile ID associated with the order.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The timestamp when the order was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Connection ID linked to the order.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Current status of the number order.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Billing group ID for the order.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// List of phone numbers included in the order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberOrderResponsePhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Record type associated with the order.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    /// <summary>
    /// Represents a phone number included in a created number order.
    /// Provides fields such as country code, status,
    /// and regulatory requirements.
    /// </summary>
    public class CreateNumberOrderResponsePhoneNumber
    {
        /// <summary>
        /// Indicates if the phone number requirements are met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// Country code for the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// List of regulatory requirements for the phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<CreateNumberOrderRegulatoryRequirement> RegulatoryRequirements { get; set; }

        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Status of the phone number's requirements.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// Current status of the phone number.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Type of phone number (e.g., mobile, toll-free).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// The actual phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumberPhoneNumber { get; set; }

        /// <summary>
        /// Record type associated with the phone number.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}