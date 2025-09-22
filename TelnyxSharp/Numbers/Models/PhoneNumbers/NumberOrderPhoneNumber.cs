using System.Text.Json.Serialization;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers
{
    /// <summary>
    /// Represents a phone number within a number order with minimal information.
    /// Used in LIST endpoints where only basic phone number data is returned.
    /// </summary>
    public class NumberOrderPhoneNumber
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The actual phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }

    /// <summary>
    /// Represents a phone number within a number order with full details.
    /// Used in GET endpoints where complete phone number information is returned.
    /// </summary>
    public class NumberOrderPhoneNumberDetail
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
        /// The ISO 3166-1 alpha-2 country code of the phone number.
        /// </summary>
        [JsonPropertyName("country_iso_alpha2")]
        public string? CountryIsoAlpha2 { get; set; }

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
        /// Possible values: pending, approved, cancelled, deleted,
        /// requirement-info-exception, requirement-info-pending, requirement-info-under-review.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// The current status of the phone number in the order.
        /// Possible values: pending, success, failure.
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
        /// Possible values: local, mobile, national, shared_cost, toll_free.
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