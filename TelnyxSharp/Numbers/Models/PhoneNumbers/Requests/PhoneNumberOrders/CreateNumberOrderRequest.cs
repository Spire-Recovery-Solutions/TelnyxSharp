using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
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
        public List<CreateNumberOrderPhoneNumber>? PhoneNumbers { get; set; }

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
        /// Gets or sets the ID of the requirement group to use to satisfy number requirements.
        /// </summary>
        [JsonPropertyName("requirement_group_id")]
        public string? RequirementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the bundle to associate the number with.
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string? BundleId { get; set; }
    }
}