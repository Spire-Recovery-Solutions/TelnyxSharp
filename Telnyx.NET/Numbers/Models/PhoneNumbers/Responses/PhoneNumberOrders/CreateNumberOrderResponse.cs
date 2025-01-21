using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response received when creating a number order in the Telnyx API.
    /// </summary>
    public class CreateNumberOrderResponse : TelnyxResponse<NumberOrdersPhoneNumber>
    {
    }

    /// <summary>
    /// 
    public class CreateNumberOrderData : BaseNumberOrdersData
    {
        /// <summary>
        /// Gets or sets the list of phone numbers in the number order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumberOrderData>? PhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a phone number associated with an order, including regulatory requirements,
    /// status, and metadata.
    /// </summary>
    public class PhoneNumberOrderData
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The record type of the phone number entity.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The E.164 formatted phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// List of regulatory requirements associated with the phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<NumberOrderRegulatoryRequirement>? RegulatoryRequirements { get; set; }

        /// <summary>
        /// Indicates whether all requirements for the phone number are met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool RequirementsMet { get; set; }

        /// <summary>
        /// The status of the document requirements, if applicable.
        /// Possible values: [pending, approved, cancelled, deleted, 
        /// requirement-info-exception, requirement-info-pending, requirement-info-under-review].
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// The current status of the phone number in the order.
        /// Possible values: [pending, success, failure].
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The unique identifier for the bundle associated with the phone number.
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string? BundleId { get; set; }

        /// <summary>
        /// The type of the phone number.
        /// Possible values: [local, mobile, national, shared_cost, toll_free].
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// The country code of the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }
    }
}