using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create a porting phone block.
    /// </summary>
    public class CreatePortingPhoneBlockRequest : ITelnyxRequest
    {
        /// <summary>
        /// Specifies the range of phone numbers to be ported.
        /// </summary>
        [JsonPropertyName("phone_number_range")]
        public required Ranges? PhoneNumberRange { get; set; }

        /// <summary>
        /// Specifies the activation ranges within the phone number block.
        /// The activation range must be within the phone number range and should not overlap with other activation ranges.
        /// </summary>
        [JsonPropertyName("activation_ranges")]
        public required List<Ranges>? ActivationRanges { get; set; }
    }
}