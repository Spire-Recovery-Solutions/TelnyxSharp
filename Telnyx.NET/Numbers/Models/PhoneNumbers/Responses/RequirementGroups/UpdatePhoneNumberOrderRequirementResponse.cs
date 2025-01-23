using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.RequirementGroups
{
    /// <summary>
    /// Represents the response for updating a phone number order requirement.
    /// It extends the TelnyxResponse class with generic data of type PhoneNumberOrderRequirementData.
    /// </summary>
    public class UpdatePhoneNumberOrderRequirementResponse : TelnyxResponse<PhoneNumberOrderRequirementData>
    {
    }

    /// <summary>
    /// Contains the data for a phone number order requirement.
    /// It includes details like the status, order request ID, country code, and other order details.
    /// </summary>
    public class PhoneNumberOrderRequirementData
    {
        /// <summary>
        /// The status of the phone number order.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The ID of the order request associated with the phone number.
        /// </summary>
        [JsonPropertyName("order_request_id")]
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// The country code for the phone number order.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Indicates whether the number is a block number.
        /// </summary>
        [JsonPropertyName("is_block_number")]
        public bool? IsBlockNumber { get; set; }

        /// <summary>
        /// A list of regulatory requirements for the phone number order.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<PhoneNumberRegRequirement>? RegulatoryRequirements { get; set; }

        /// <summary>
        /// The locality (region or city) related to the phone number order.
        /// </summary>
        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>
        /// The type of phone number (e.g., mobile, toll-free).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// The ID of the bundle to which the phone number belongs.
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string? BundleId { get; set; }

        /// <summary>
        /// The sub-order ID for the number order.
        /// </summary>
        [JsonPropertyName("sub_number_order_id")]
        public string? SubNumberOrderId { get; set; }

        /// <summary>
        /// The deadline by which the order requirement must be met.
        /// </summary>
        [JsonPropertyName("deadline")]
        public DateTimeOffset? Deadline { get; set; }

        /// <summary>
        /// The current status of the requirements.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// The unique identifier for the phone number order requirement.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The phone number associated with the order.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Indicates whether the order requirements have been met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// The record type of the phone number order.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }

    /// <summary>
    /// Represents a regulatory requirement for a phone number order.
    /// It contains information like requirement ID, field value, field type, and its status.
    /// </summary>
    public class PhoneNumberRegRequirement
    {
        /// <summary>
        /// The ID of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("requirement_id")]
        public string? RequirementId { get; set; }

        /// <summary>
        /// The value associated with the field of the requirement.
        /// </summary>
        [JsonPropertyName("field_value")]
        public string? FieldValue { get; set; }

        /// <summary>
        /// The type of field in the regulatory requirement.
        /// </summary>
        [JsonPropertyName("field_type")]
        public string? FieldType { get; set; }

        /// <summary>
        /// The status of the regulatory requirement.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}