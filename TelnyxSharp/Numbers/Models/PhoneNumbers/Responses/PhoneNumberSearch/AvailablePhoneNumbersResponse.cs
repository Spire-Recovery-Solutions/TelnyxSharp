using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberSearch
{
    /// <summary>
    /// Represents the response for available phone numbers from Telnyx API.
    /// </summary>
    public partial class AvailablePhoneNumbersResponse : TelnyxResponse<List<AvailablePhoneNumbersDatum>>
    {
        /// <summary>
        /// Gets or sets metadata associated with the available phone numbers response.
        /// </summary>
        [JsonPropertyName("meta")]
        public AvailablePhoneNumbersMeta Meta { get; set; }
    }

    /// <summary>
    /// Represents details of an available phone number.
    /// </summary>
    public partial class AvailablePhoneNumbersDatum
    {
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the type of the record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Indicates whether the phone number can be reserved.
        /// </summary>
        [JsonPropertyName("reservable")]
        public bool? Reservable { get; set; }

        /// <summary>
        /// Gets or sets cost information associated with the phone number.
        /// </summary>
        [JsonPropertyName("cost_information")]
        public CostInformation CostInformation { get; set; }

        /// <summary>
        /// Gets or sets the vanity format of the phone number.
        /// </summary>
        [JsonPropertyName("vanity_format")]
        public string? VanityFormat { get; set; }

        /// <summary>
        /// Gets or sets the type of phone number.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Indicates whether the phone number is available with best effort.
        /// </summary>
        [JsonPropertyName("best_effort")]
        public bool? BestEffort { get; set; }

        /// <summary>
        /// Indicates if the phone number can be shipped quickly.
        /// </summary>
        [JsonPropertyName("quickship")]
        public bool? Quickship { get; set; }

        /// <summary>
        /// Gets or sets region information associated with the phone number.
        /// </summary>
        [JsonPropertyName("region_information")]
        public List<RegionInformation> RegionInformation { get; set; }

        /// <summary>
        /// Gets or sets features available for the phone number.
        /// </summary>
        [JsonPropertyName("features")]
        public List<Feature> Features { get; set; }
    }

    /// <summary>
    /// Represents cost information for a phone number.
    /// </summary>
    public partial class CostInformation
    {
        /// <summary>
        /// Gets or sets the upfront cost for the phone number.
        /// </summary>
        [JsonPropertyName("upfront_cost")]
        public double UpfrontCost { get; set; }

        /// <summary>
        /// Gets or sets the monthly cost for the phone number.
        /// </summary>
        [JsonPropertyName("monthly_cost")]
        public double MonthlyCost { get; set; }

        /// <summary>
        /// Gets or sets the currency for the cost information.
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }

    /// <summary>
    /// Represents a feature available for a phone number.
    /// </summary>
    public partial class Feature
    {
        /// <summary>
        /// Gets or sets the name of the feature.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }

    /// <summary>
    /// Represents region information for a phone number.
    /// </summary>
    public partial class RegionInformation
    {
        /// <summary>
        /// Gets or sets the type of the region.
        /// </summary>
        [JsonPropertyName("region_type")]
        public string? RegionType { get; set; }

        /// <summary>
        /// Gets or sets the name of the region.
        /// </summary>
        [JsonPropertyName("region_name")]
        public string? RegionName { get; set; }
    }

    /// <summary>
    /// Represents metadata for the available phone numbers response.
    /// </summary>
    public partial class AvailablePhoneNumbersMeta
    {
        /// <summary>
        /// Gets or sets the total number of results available.
        /// </summary>
        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// Gets or sets the number of results available with best effort.
        /// </summary>
        [JsonPropertyName("best_effort_results")]
        public long BestEffortResults { get; set; }
    }
}