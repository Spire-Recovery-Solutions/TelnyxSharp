using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create phone number extensions for a porting order.
    /// </summary>
    public class CreatePhoneNumberExtensionsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The unique identifier of the porting phone number associated with the extension.
        /// </summary>
        [JsonPropertyName("porting_phone_number_id")]
        public string? PortingPhoneNumberId { get; set; }

        /// <summary>
        /// The range of extensions available for this porting phone number.
        /// </summary>
        [JsonPropertyName("extension_range")]
        public Ranges? ExtensionRange { get; set; }

        /// <summary>
        /// A list of activation ranges within the extension range.
        /// </summary>
        [JsonPropertyName("activation_ranges")]
        public List<Ranges>? ActivationRanges { get; set; }
    }
}