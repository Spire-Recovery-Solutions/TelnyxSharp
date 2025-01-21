using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for listing phone numbers associated with a number order.
    /// Inherits from TelnyxResponse and encapsulates a list of NumberOrderPhonesData objects.
    /// </summary>
    public class ListNumberOrderPhonesResponse : TelnyxResponse<List<NumberOrderPhonesData>>
    {
    }

    /// <summary>
    /// Represents detailed information about a phone number in a number order.
    /// </summary>
    public class NumberOrderPhonesData
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The record type associated with the phone number.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The phone number in a standard format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// The identifier for the order request this phone number belongs to.
        /// </summary>
        [JsonPropertyName("order_request_id")]
        public string? OrderRequestId { get; set; }

        /// <summary>
        /// The identifier for the sub-number order associated with this phone number.
        /// </summary>
        [JsonPropertyName("sub_number_order_id")]
        public string? SubNumberOrderId { get; set; }

        /// <summary>
        /// The country code for the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// The type of phone number (e.g., mobile, toll-free).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// The list of regulatory requirements for this phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<NumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }

        /// <summary>
        /// Indicates whether the regulatory requirements for this phone number are met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// The current status of the phone number in the order.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The bundle identifier for grouped numbers in the order.
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string? BundleId { get; set; }

        /// <summary>
        /// The locality information for the phone number, if applicable.
        /// </summary>
        [JsonPropertyName("locality")]
        public string? Locality { get; set; }

        /// <summary>
        /// The deadline for completing any requirements for this phone number.
        /// </summary>
        [JsonPropertyName("deadline")]
        public DateTimeOffset? Deadline { get; set; }

        /// <summary>
        /// The status of regulatory requirements for this phone number.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// Indicates if this phone number is part of a block allocation.
        /// </summary>
        [JsonPropertyName("is_block_number")]
        public bool? IsBlockNumber { get; set; }
    }
}