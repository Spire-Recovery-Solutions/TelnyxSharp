using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;
using Telnyx.NET.Voice.Models.CallCommands.Requests;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for speaking text to a conference.
    /// This model includes parameters for controlling the voice settings, language, and the payload (text) to be spoken in the conference.
    /// </summary>
    public class SpeakTextToConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of call control IDs for the participants in the conference that will hear the spoken text.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }

        /// <summary>
        /// Gets or sets the text payload to be spoken in the conference.
        /// This is the content that will be read out to the conference participants.
        /// </summary>
        [JsonPropertyName("payload")]
        public required string Payload { get; set; }

        /// <summary>
        /// Gets or sets the type of the payload, such as plain text or SSML.
        /// </summary>
        [JsonPropertyName("payload_type")]
        public PayloadType PayloadType { get; set; }

        /// <summary>
        /// Gets or sets the voice to be used for speaking the text.
        /// This defines the voice characteristics (e.g., male, female, robotic).
        /// </summary>
        [JsonPropertyName("voice")]
        public required string Voice { get; set; }

        /// <summary>
        /// Gets or sets additional voice settings, such as pitch, rate, or volume.
        /// These settings will influence the speech synthesis.
        /// </summary>
        [JsonPropertyName("voice_settings")]
        public VoiceSettings? VoiceSettings { get; set; }

        /// <summary>
        /// Gets or sets the language of the spoken text.
        /// This determines the language in which the text will be spoken.
        /// </summary>
        [JsonPropertyName("language")]
        public Language? Language { get; set; }

        /// <summary>
        /// Gets or sets the command ID associated with this speak text request.
        /// This can be used to track or manage the request.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}