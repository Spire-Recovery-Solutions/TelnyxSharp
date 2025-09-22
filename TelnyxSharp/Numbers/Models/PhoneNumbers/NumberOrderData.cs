using System.Text.Json.Serialization;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers
{
    /// <summary>
    /// Base class for number order data, containing common properties shared across all number order responses.
    /// </summary>
    public abstract class BaseNumberOrderData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the number order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with this number order.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the count of phone numbers in the number order.
        /// </summary>
        [JsonPropertyName("phone_numbers_count")]
        public int PhoneNumbersCount { get; set; }

        /// <summary>
        /// Gets or sets the connection ID associated with the number order.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the messaging profile ID associated with the number order.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// Gets or sets the billing group ID associated with the number order.
        /// </summary>
        [JsonPropertyName("billing_group_id")]
        public string? BillingGroupId { get; set; }

        /// <summary>
        /// Gets or sets the list of sub-number order IDs associated with the number order.
        /// </summary>
        [JsonPropertyName("sub_number_orders_ids")]
        public List<string>? SubNumberOrdersIds { get; set; }

        /// <summary>
        /// Gets or sets the status of the number order.
        /// Possible values: pending, success, failure.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the number order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the number order.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the number order.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all requirements for the number order are met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool RequirementsMet { get; set; }
    }

    /// <summary>
    /// Represents a number order in LIST responses with minimal phone number details.
    /// </summary>
    public class NumberOrderListData : BaseNumberOrderData
    {
        /// <summary>
        /// Gets or sets the list of phone numbers in the number order (minimal info).
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<NumberOrderPhoneNumber>? PhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a number order in GET responses with full phone number details.
    /// </summary>
    public class NumberOrderDetailData : BaseNumberOrderData
    {
        /// <summary>
        /// Gets or sets the list of phone numbers in the number order (full details).
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<NumberOrderPhoneNumberDetail>? PhoneNumbers { get; set; }
    }
}