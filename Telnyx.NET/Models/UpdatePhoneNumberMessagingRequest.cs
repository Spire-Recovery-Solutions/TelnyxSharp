using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the request to update the messaging profile and/or messaging product of a phone number.
    /// </summary>
    public class UpdatePhoneNumberMessagingRequest : ITelnyxRequest
    {
        /// <summary>
        /// The unique identifier for the messaging profile to assign to the phone number.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        /// <summary>
        /// The messaging product to set for the phone number.
        /// </summary>
        [JsonPropertyName("messaging_product")]
        public string? MessagingProduct { get; set; }
    }
}