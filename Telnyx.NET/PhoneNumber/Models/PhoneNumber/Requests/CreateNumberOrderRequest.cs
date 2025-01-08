using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests
{
    /// <summary>
    /// Represents a request to create a number order in the Telnyx API.
    /// </summary>
    public class CreateNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers to be included in the order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<CreateNumberOrderPhoneNumber> PhoneNumbers { get; set; } = new();

        /// <summary>
        /// Gets or sets the connection ID for the number order.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID for the number order.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID for the number order.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets a customer reference for the number order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }

    /// <summary>
    /// Represents a phone number included in a number order request.
    /// </summary>
    public class CreateNumberOrderPhoneNumber
    {
        /// <summary>
        /// Gets or sets the phone number for the order. This property is required.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirements associated with the phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<CreateNumberOrderRegulatoryRequirement> RegulatoryRequirements { get; set; }
    }
}