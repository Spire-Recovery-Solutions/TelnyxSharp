using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents a request to create a phone number block order.
    /// This request specifies the starting number, range of numbers, and optional details such as connection ID, messaging profile, and customer reference.
    /// </summary>
    public class CreateNumberBlockOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the starting phone number for the block order.
        /// This is the first number in the range to be ordered.
        /// </summary>
        [JsonPropertyName("starting_number")]
        public required string StartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the range of phone numbers to be ordered.
        /// Specifies the total count of consecutive numbers starting from the `StartingNumber`.
        /// </summary>
        [JsonPropertyName("range")]
        public required int Range { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the connection to associate with the phone numbers in the block.
        /// Optional: If not provided, no specific connection will be associated.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the messaging profile to associate with the phone numbers in the block.
        /// Optional: Useful for configuring messaging capabilities for the ordered numbers.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the block order.
        /// Optional: This can be used for tracking or reference purposes in customer systems.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }
}