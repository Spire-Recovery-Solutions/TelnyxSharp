using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to preview a LOA (Letter of Authorization) configuration parameter.
    /// This class contains the essential details required to generate the preview of the LOA configuration.
    /// </summary>
    public class PreviewLoaConfigurationParamRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name for the LOA configuration.
        /// This is a required field that specifies the name of the configuration.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the logo information for the LOA configuration.
        /// This required field contains the logo associated with the configuration.
        /// </summary>
        [JsonPropertyName("logo")]
        public required LogoInfo Logo { get; set; }

        /// <summary>
        /// Gets or sets the company name for the LOA configuration.
        /// This required field specifies the company name that will appear on the LOA.
        /// </summary>
        [JsonPropertyName("company_name")]
        public required string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the address information for the LOA configuration.
        /// This required field specifies the address associated with the LOA.
        /// </summary>
        [JsonPropertyName("address")]
        public required Address Address { get; set; }

        /// <summary>
        /// Gets or sets the contact information for the LOA configuration.
        /// This required field contains the contact details related to the LOA.
        /// </summary>
        [JsonPropertyName("contact")]
        public required Contact Contact { get; set; }
    }
}