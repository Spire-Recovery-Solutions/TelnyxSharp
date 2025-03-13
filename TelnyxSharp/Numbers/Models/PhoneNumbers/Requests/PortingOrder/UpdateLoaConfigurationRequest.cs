using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to update an existing Letter of Authorization (LOA) configuration in the Telnyx system.
    /// This class is used when making a request to modify the details of an LOA configuration for phone number porting.
    /// </summary>
    public class UpdateLoaConfigurationRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name of the LOA configuration. This field is required to identify the LOA.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets the logo information associated with the LOA configuration. This field is required to provide logo details.
        /// </summary>
        [JsonPropertyName("logo")]
        public required LogoInfo Logo { get; set; }

        /// <summary>
        /// Gets or sets the company name associated with the LOA configuration. This field is required.
        /// </summary>
        [JsonPropertyName("company_name")]
        public required string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the address associated with the LOA configuration. This field is required to provide address details.
        /// </summary>
        [JsonPropertyName("address")]
        public required Address Address { get; set; }

        /// <summary>
        /// Gets or sets the contact information associated with the LOA configuration. This field is required to specify contact details.
        /// </summary>
        [JsonPropertyName("contact")]
        public required Contact Contact { get; set; }
    }
}