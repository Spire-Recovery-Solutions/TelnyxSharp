using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for retrieving a list of sub-number orders.
    /// Inherits from TelnyxResponse and encapsulates a list of SubNumberOrderData objects.
    /// </summary>
    public class ListSubNumberOrdersResponse : TelnyxResponse<List<SubNumberOrderData>>
    {
    }

    /// <summary>
    /// Represents the data of a sub-number order requirement, including details about the order and regulatory requirements.
    /// </summary>
    public class SubNumberOrderData
    {
        /// <summary>
        /// The unique identifier for the sub-number order.
        /// This property is serialized with the name "id".
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The unique identifier for the order request associated with the sub-number order.
        /// This property is serialized with the name "order_request_id".
        /// </summary>
        [JsonPropertyName("order_request_id")]
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// The country code associated with the sub-number order.
        /// This property is serialized with the name "country_code".
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }


        /// <summary>
        /// The type of the phone number for the sub-number order.
        /// This property is serialized with the name "phone_number_type".
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }


        /// <summary>
        /// The identifier for the user who created or is associated with this sub-number order.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The number of phone numbers associated with the sub-number order.
        /// This property is serialized with the name "phone_numbers_count".
        /// </summary>
        [JsonPropertyName("phone_numbers_count")]
        public int? PhoneNumbersCount { get; set; }

        /// <summary>
        /// A boolean indicating if the requirements for the sub-number order have been met.
        /// This property is serialized with the name "requirements_met".
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// A boolean indicating whether the sub-number order is blocked.
        /// This property is serialized with the name "is_block_sub_number_order".
        /// </summary>
        [JsonPropertyName("is_block_sub_number_order")]
        public bool? IsBlockSubNumberOrder { get; set; }

        /// <summary>
        /// The current status of the sub-number order.
        /// This property is serialized with the name "status".
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// A reference that the customer has associated with the sub-number order.
        /// This property is serialized with the name "customer_reference".
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// The timestamp when the sub-number order was created.
        /// This property is serialized with the name "created_at".
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the sub-number order was last updated.
        /// This property is serialized with the name "updated_at".
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The type of record associated with the sub-number order.
        /// This property is serialized with the name "record_type".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// A list of regulatory requirements associated with the sub-number order.
        /// This property is serialized with the name "regulatory_requirements".
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<NumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }

    }
}