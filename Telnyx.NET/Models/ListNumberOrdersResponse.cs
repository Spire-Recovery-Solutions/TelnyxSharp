using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    public class ListNumberOrdersResponse : TelnyxResponse<List<NumberOrder>>
    {
    }

    public partial class NumberOrdersPhoneNumber
    {
        [JsonPropertyName("requirements_met")]
        public bool? RequirementsMet { get; set; }

        [JsonPropertyName("requirements_status")]
        public string? RequirementsStatus { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("regulatory_requirements")]
        public List<object> RegulatoryRequirements { get; set; }

        [JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }
    }


}