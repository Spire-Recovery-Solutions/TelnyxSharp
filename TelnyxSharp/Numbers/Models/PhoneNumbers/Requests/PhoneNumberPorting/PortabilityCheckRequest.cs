using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberPorting
{
    /// <summary>
    /// Represents a request to perform a portability check for a list of phone numbers.
    /// This is used to verify if specific phone numbers can be ported to Telnyx.
    /// </summary>
    public class PortabilityCheckRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of phone numbers to check for portability.
        /// The phone numbers should be provided in E.164 format (e.g., "+1234567890").
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }
    }
}