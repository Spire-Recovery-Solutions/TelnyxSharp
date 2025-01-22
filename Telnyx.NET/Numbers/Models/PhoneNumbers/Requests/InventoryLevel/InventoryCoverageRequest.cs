using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.InventoryLevel
{
    /// <summary>
    /// Represents a request to retrieve phone number inventory coverage based on various filters.
    /// </summary>
    public class InventoryCoverageRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the Numbering Plan Area (NPA) code for filtering results.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[npa]")]
        public int? Npa { get; set; }

        /// <summary>
        /// Gets or sets the Central Office Code (NXX) for filtering results.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[nxx]")]
        public int? Nxx { get; set; }

        /// <summary>
        /// Gets or sets the administrative area (state, province, etc.) for filtering results.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[administrative_area]")]
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// Gets or sets the phone number type for filtering results, such as local or toll-free.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[phone_number_type]")]
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the country code for filtering results.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[country_code]")]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to count the results instead of listing them.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[count]")]
        public bool? Count { get; set; }

        /// <summary>
        /// Gets or sets the list of features (e.g., SMS, MMS, voice, fax) for filtering results.
        /// Optional.
        /// </summary>
        [JsonPropertyName("filter[features]")]
        public List<FeatureType>? Features { get; set; }

        /// <summary>
        /// Gets or sets the grouping criteria for aggregating results, such as by locality or NPA.
        /// Required.
        /// </summary>
        [JsonPropertyName("filter[groupBy]")]
        public GroupByType GroupBy { get; set; }
    }
}