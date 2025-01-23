using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.AdvancedNumberOrders
{
    /// <summary>
    /// Represents the request payload for creating an advanced number order.
    /// This request allows for specifying detailed requirements for the number order, such as country, area code, type, and features.
    /// </summary>
    public class CreateAdvancedOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code for the phone numbers to be ordered.
        /// This is typically a two-character ISO 3166-1 alpha-2 country code.
        /// </summary>
        [JsonPropertyName("country_code")]
        public CountryCode? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets additional comments for the advanced number order.
        /// These comments can provide context or specific instructions for the order.
        /// </summary>
        [JsonPropertyName("comments")]
        public string? Comments { get; set; }

        /// <summary>
        /// Gets or sets the quantity of phone numbers to be ordered.
        /// Defaults to 1 if not specified.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; } = 1;

        /// <summary>
        /// Gets or sets the area code for the phone numbers to be ordered.
        /// This can be used to narrow down the search to a specific area or region.
        /// </summary>
        [JsonPropertyName("area_code")]
        public string? AreaCode { get; set; }

        /// <summary>
        /// Gets or sets the types of phone numbers to be ordered.
        /// Examples include toll-free, local, or mobile numbers.
        /// </summary>
        [JsonPropertyName("phone_number_type")]
        public List<PhoneNumberType>? PhoneNumberType { get; set; }

        /// <summary>
        /// Gets or sets the features required for the phone numbers in the order.
        /// Examples include voice, messaging, or fax capabilities.
        /// </summary>
        [JsonPropertyName("features")]
        public List<FeatureType>? Features { get; set; }

        /// <summary>
        /// Gets or sets a customer reference for the order.
        /// This is typically used for associating the order with a specific customer or internal tracking system.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }
}