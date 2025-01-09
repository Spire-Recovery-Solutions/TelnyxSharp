using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses
{
    /// <summary>
    /// Response model for listing number orders.
    /// Contains a list of number orders with associated metadata.
    /// </summary>
    public class ListNumberOrdersResponse : TelnyxResponse<List<NumberOrder>>
    {
    }

    /// <summary>
    /// Represents a phone number involved in a number order.
    /// Contains information about the phone number's requirements, status, and regulatory details.
    /// </summary>
    public partial class NumberOrdersPhoneNumber
    {
        /// <summary>
        /// Gets or sets whether the requirements for the phone number have been met.
        /// </summary>
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        /// <summary>
        /// Gets or sets the status of the requirements for the phone number.
        /// </summary>
        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the phone number in the order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the actual phone number involved in the order.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the status of the phone number (e.g., reserved, assigned, etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number (e.g., mobile, landline, etc.).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the list of regulatory requirements associated with the phone number.
        /// </summary>
        [JsonPropertyName("regulatory_requirements")]
        public List<object> RegulatoryRequirements { get; set; }

        /// <summary>
        /// Gets or sets the country code associated with the phone number.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with this phone number in the order.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }
}