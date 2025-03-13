using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.ShortCodes.Requests
{
    public class UpdateShortCodeRequest : ITelnyxRequest
    {
        /// <summary>
        /// Unique identifier for a messaging profile. To unbind a short code, set to null or an empty string.
        /// </summary>
        [JsonPropertyName("messaging_profile_id")]
        public required string MessagingProfileId { get; set; }
    }
}
