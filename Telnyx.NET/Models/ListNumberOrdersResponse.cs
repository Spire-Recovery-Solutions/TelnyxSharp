using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    using System.Collections.Generic;
    
    using Interfaces;

    public class ListNumberOrdersResponse : ITelnyxResponse
    {
        [JsonPropertyName("data")]
        public List<NumberOrder> Data { get; set; }

        [JsonPropertyName("meta")]
        public ListNumberOrdersMeta Meta { get; set; }
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

    public partial class ListNumberOrdersMeta
    {
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
