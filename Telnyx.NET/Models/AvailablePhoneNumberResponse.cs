using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    using System.Collections.Generic;
    using Telnyx.NET.Enums;
    using Telnyx.NET.Interfaces;

    public partial class AvailablePhoneNumbersResponse : ITelnyxResponse
    {
        [JsonPropertyName("data")]
        public List<AvailablePhoneNumbersDatum> Data { get; set; }

        [JsonPropertyName("meta")]
        public AvailablePhoneNumbersMeta Meta { get; set; }

        [JsonPropertyName("metadata")]
        public AvailablePhoneNumbersMeta Metadata { get; set; }
    }

    public partial class AvailablePhoneNumbersDatum
    {
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("reservable")]
        public bool? Reservable { get; set; }

        [JsonPropertyName("cost_information")]
        public CostInformation CostInformation { get; set; }

        [JsonPropertyName("vanity_format")]
        public string? VanityFormat { get; set; }

        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        [JsonPropertyName("best_effort")]
        public bool? BestEffort { get; set; }

        [JsonPropertyName("quickship")]
        public bool? Quickship { get; set; }

        [JsonPropertyName("region_information")]
        public List<RegionInformation> RegionInformation { get; set; }

        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }
    }

    public partial class CostInformation
    {
        [JsonPropertyName("upfront_cost")]
        public double UpfrontCost { get; set; }

        [JsonPropertyName("monthly_cost")]
        public double MonthlyCost { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }

    public partial class Feature
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    public partial class RegionInformation
    {
        [JsonPropertyName("region_type")]
        public string? RegionType { get; set; }

        [JsonPropertyName("region_name")]
        public string? RegionName { get; set; }
    }

    public partial class AvailablePhoneNumbersMeta
    {
        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }

        [JsonPropertyName("best_effort_results")]
        public long BestEffortResults { get; set; }
    }
}
