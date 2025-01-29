using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create an LOA (Letter of Authorization) configuration for a porting order.
    /// </summary>
    public class CreateLoaConfigurationRequest : ITelnyxRequest
    {
        /// <summary>
        /// The name of the LOA configuration.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// The logo information associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("logo")]
        public required LogoInfo Logo { get; set; }

        /// <summary>
        /// The name of the company associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("company_name")]
        public required string CompanyName { get; set; }

        /// <summary>
        /// The address details associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("address")]
        public required Address Address { get; set; }

        /// <summary>
        /// The contact details associated with the LOA configuration.
        /// </summary>
        [JsonPropertyName("contact")]
        public required Contact Contact { get; set; }
    }
}