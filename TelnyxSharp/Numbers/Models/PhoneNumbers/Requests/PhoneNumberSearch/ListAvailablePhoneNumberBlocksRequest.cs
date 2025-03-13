using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch
{
    /// <summary>
    /// Represents a request for retrieving available phone number blocks.
    /// </summary>
    public class ListAvailablePhoneNumberBlocksRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the locality filter for the phone number block search.
        /// This specifies the geographic area (city or region) to search within.
        /// </summary>
        public string? Locality { get; set; }

        /// <summary>
        /// Gets or sets the country code filter for the phone number block search.
        /// This specifies the country of the desired phone number blocks (e.g., "US" for the United States).
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the national destination code (NDC) filter for the phone number block search.
        /// This is used to narrow the search to a specific region within a country, such as area codes.
        /// </summary>
        public string? NationalDestinationCode { get; set; }

        /// <summary>
        /// Gets or sets the phone number type filter for the phone number block search.
        /// This specifies the type of phone numbers to search for, such as local, mobile, or toll-free numbers.
        /// </summary>
        public PhoneNumberType? PhoneNumberType { get; set; }
    }
}