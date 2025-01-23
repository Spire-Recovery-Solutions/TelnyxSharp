using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.CountryCoverage
{
    /// <summary>
    /// Represents the response for retrieving a list of country coverage details.
    /// This includes a collection of details for multiple countries, each containing information about
    /// phone number availability, features, and other country-specific coverage data.
    /// </summary>
    public class ListCountryCoverageResponse : TelnyxResponse<List<CountryCoverageDetails>>
    {
    }

    /// <summary>
    /// Contains detailed information about the phone number coverage in a specific country.
    /// This includes the availability of phone numbers, supported features, and types of numbers (local, toll-free, etc.)
    /// </summary>
    public class CountryCoverageDetails
    {
        /// <summary>
        /// The country code for the specific country (e.g., 'US' for United States).
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Indicates if phone numbers are available in the specified country.
        /// </summary>
        [JsonPropertyName("numbers")]
        public bool? Numbers { get; set; }

        /// <summary>
        /// A list of features available for phone numbers in the country (e.g., SMS, voice, etc.).
        /// </summary>
        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        /// <summary>
        /// A list of phone number types available in the country (e.g., local, toll-free).
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public List<string>? PhoneNumberTypes { get; set; }

        /// <summary>
        /// Indicates whether the phone numbers in this country are reservable.
        /// </summary>
        [JsonPropertyName("reservable")]
        public bool? Reservable { get; set; }

        /// <summary>
        /// Indicates whether the phone numbers in this country are eligible for quick shipping.
        /// </summary>
        [JsonPropertyName("quickship")]
        public bool? Quickship { get; set; }

        /// <summary>
        /// Indicates whether international SMS is supported for phone numbers in this country.
        /// </summary>
        [JsonPropertyName("international_sms")]
        public bool? InternationalSms { get; set; }

        /// <summary>
        /// Indicates whether peer-to-peer (P2P) messaging is supported for phone numbers in this country.
        /// </summary>
        [JsonPropertyName("p2p")]
        public bool? P2P { get; set; }

        /// <summary>
        /// Details for local phone numbers available in this country, including features and availability.
        /// </summary>
        [JsonPropertyName("local")]
        public NumberTypeDetails? Local { get; set; }

        /// <summary>
        /// Details for toll-free phone numbers available in this country, including features and availability.
        /// </summary>
        [JsonPropertyName("toll_free")]
        public NumberTypeDetails? TollFree { get; set; }

        /// <summary>
        /// Details for mobile phone numbers available in this country, including features and availability.
        /// </summary>
        [JsonPropertyName("mobile")]
        public NumberTypeDetails? Mobile { get; set; }

        /// <summary>
        /// Details for national phone numbers available in this country, including features and availability.
        /// </summary>
        [JsonPropertyName("national")]
        public NumberTypeDetails? National { get; set; }

        /// <summary>
        /// Details for shared cost phone numbers available in this country, including features and availability.
        /// </summary>
        [JsonPropertyName("shared_cost")]
        public NumberTypeDetails? SharedCost { get; set; }

        /// <summary>
        /// Indicates whether inventory coverage is available for phone numbers in this country.
        /// </summary>
        [JsonPropertyName("inventory_coverage")]
        public bool? InventoryCoverage { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a specific type of phone number (e.g., local, toll-free, mobile).
    /// Includes features and availability information for that phone number type.
    /// </summary>
    public class NumberTypeDetails
    {
        /// <summary>
        /// A list of features available for the specific type of phone number (e.g., SMS, voice).
        /// </summary>
        [JsonPropertyName("features")]
        public List<string>? Features { get; set; }

        /// <summary>
        /// Indicates whether phone numbers of this type are reservable.
        /// </summary>
        [JsonPropertyName("reservable")]
        public bool? Reservable { get; set; }

        /// <summary>
        /// Indicates whether phone numbers of this type are eligible for quick shipping.
        /// </summary>
        [JsonPropertyName("quickship")]
        public bool? Quickship { get; set; }

        /// <summary>
        /// Indicates whether international SMS is supported for phone numbers of this type.
        /// </summary>
        [JsonPropertyName("international_sms")]
        public bool? InternationalSms { get; set; }

        /// <summary>
        /// Indicates whether peer-to-peer (P2P) messaging is supported for phone numbers of this type.
        /// </summary>
        [JsonPropertyName("p2p")]
        public bool? P2P { get; set; }
    }
}