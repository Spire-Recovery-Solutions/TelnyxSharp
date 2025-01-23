using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlockOrders
{
    /// <summary>
    /// Represents the response for listing number block orders.
    /// Inherits from <see cref="TelnyxResponse{T}"/> and contains a list of <see cref="NumberBlockOrder"/> objects.
    /// </summary>
    public class ListNumberBlockOrdersResponse : TelnyxResponse<List<NumberBlockOrder>>
    {
    }

    /// <summary>
    /// Represents a single phone number block order.
    /// Contains detailed information about the block order, including metadata, connection details, and order status.
    /// </summary>
    public class NumberBlockOrder
    {
        /// <summary>
        /// Gets or sets the unique identifier of the number block order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of record, typically used to identify the resource type in Telnyx.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the starting phone number in the block.
        /// </summary>
        [JsonPropertyName("starting_number")]
        public string? StartingNumber { get; set; }

        /// <summary>
        /// Gets or sets the range of phone numbers in the block.
        /// Represents how many consecutive numbers are included in the block.
        /// </summary>
        [JsonPropertyName("range")]
        public int? Range { get; set; }

        /// <summary>
        /// Gets or sets the total count of phone numbers included in the block.
        /// </summary>
        [JsonPropertyName("phone_numbers_count")]
        public int? PhoneNumbersCount { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the number block order.
        /// This defines the connection settings for the numbers.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the number block order.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the current status of the number block order.
        /// Possible statuses may include "pending", "completed", or "failed".
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a customer-defined reference for the block order.
        /// This can be used to correlate the order with external systems.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the number block order.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the number block order.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all requirements for the number block order have been met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }
    }
}