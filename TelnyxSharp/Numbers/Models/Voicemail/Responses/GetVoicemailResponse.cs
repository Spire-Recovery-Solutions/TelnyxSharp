using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.Voicemail.Responses
{
    /// <summary>
    /// Represents the response model for retrieving voicemail settings of a phone number.
    /// </summary>
    public class GetVoicemailResponse : TelnyxResponse<VoicemailSettings>
    {
    }

    /// <summary>
    /// Represents the voicemail settings associated with a phone number.
    /// </summary>
    public class VoicemailSettings
    {
        /// <summary>
        /// Indicates whether voicemail is enabled for the phone number.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The PIN code for voicemail access, if applicable.
        /// </summary>
        [JsonPropertyName("pin")]
        public string? Pin { get; set; }
    }
}
