using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.Voicemail.Requests
{
    /// <summary>
    /// Represents the request model for updating voicemail settings for a phone number.
    /// </summary>
    public class UpdateVoicemailRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the PIN code required to access voicemail.
        /// </summary>
        /// <remarks>
        /// This PIN code is used for authenticating the user when they access voicemail settings or messages.
        /// </remarks>
        [JsonPropertyName("pin")]
        public string? Pin { get; set; }

        /// <summary>
        /// Gets or sets whether voicemail is enabled or not for the phone number.
        /// </summary>
        /// <remarks>
        /// If set to <c>true</c>, voicemail is enabled for the phone number; otherwise, it is disabled.
        /// </remarks>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
    }
}