using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for retrieving a list of sub-number orders.
    /// Inherits from TelnyxResponse and encapsulates a list of SubNumberOrderData objects.
    /// </summary>
    public class ListSubNumberOrdersResponse : TelnyxResponse<List<SubNumberOrderData>>
    {
    }

    /// <summary>
    /// Represents detailed information about a sub-number order.
    /// </summary>
    public class SubNumberOrderData
    {
        /// <summary>
        /// Unique identifier for the sub-number order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier for the order request that this sub-number order is associated with.
        /// </summary>
        [JsonPropertyName("order_request_id")]
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// The country code associated with the sub-number order.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// The type of phone numbers included in this sub-number order (e.g., mobile, toll-free).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// The identifier for the user who created or is associated with this sub-number order.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// A list of regulatory requirements applicable to this sub-number order.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<NumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }

        /// <summary>
        /// The record type of the sub-number order.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The count of phone numbers associated with this sub-number order.
        /// </summary>
        [JsonPropertyName("phone_numbers_count")]
        public int PhoneNumbersCount { get; set; }

        /// <summary>
        /// The timestamp when the sub-number order was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the sub-number order was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Indicates whether the regulatory requirements for the sub-number order are met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool RequirementsMet { get; set; }

        /// <summary>
        /// The current status of the sub-number order (e.g., pending, completed).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A custom reference provided by the customer for tracking or identification purposes.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Indicates if this sub-number order is part of a block allocation.
        /// </summary>
        [JsonPropertyName("is_block_sub_number_order")]
        public bool IsBlockSubNumberOrder { get; set; }
    }
}