using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.InventoryLevel
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
        public int? Npa { get; set; }

        /// <summary>
        /// Gets or sets the Central Office Code (NXX) for filtering results.
        /// Optional.
        /// </summary>
        public int? Nxx { get; set; }

        /// <summary>
        /// Gets or sets the administrative area (state, province, etc.) for filtering results.
        /// Optional.
        /// </summary>
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// Gets or sets the phone number type for filtering results, such as local or toll-free.
        /// Optional.
        /// </summary>
        public PhoneNumberType? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the country code for filtering results.
        /// Optional.
        /// </summary>
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to count the results instead of listing them.
        /// Optional.
        /// </summary>
        public bool? Count { get; set; }

        /// <summary>
        /// Gets or sets the list of features (e.g., SMS, MMS, voice, fax) for filtering results.
        /// Optional.
        /// </summary>
        public List<FeatureType>? Features { get; set; }

        /// <summary>
        /// Gets or sets the grouping criteria for aggregating results, such as by locality or NPA.
        /// Required.
        /// </summary>
        public GroupByType GroupBy { get; set; }
    }
}