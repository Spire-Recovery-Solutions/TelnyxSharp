using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for creating a conference in Telnyx.
    /// This model contains the necessary properties to create and configure a conference call.
    /// </summary>
    public class CreateConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the unique identifier for the call control. 
        /// This ID is used to associate conference calls with their control information.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public required string CallControlId { get; set; }

        /// <summary>
        /// Gets or sets the name of the conference.
        /// This name will be used to identify the conference.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the beep is enabled during the conference call. 
        /// Beeps can indicate specific events like entry or exit from the conference.
        /// </summary>
        [JsonPropertyName("beep_enabled")]
        public BeepEnabled BeepEnabled { get; set; } = BeepEnabled.Never;

        /// <summary>
        /// Gets or sets the client state associated with the conference. 
        /// This is a custom field that can hold any string value for the client.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets whether comfort noise is enabled during the conference. 
        /// Comfort noise is typically used to simulate background noise to avoid silence during idle periods.
        /// </summary>
        [JsonPropertyName("comfort_noise")]
        public bool ComfortNoise { get; set; } = true;

        /// <summary>
        /// Gets or sets a custom command ID for the conference. 
        /// This can be used for identifying specific commands or actions related to the conference.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the duration of the conference in minutes.
        /// This defines how long the conference will last before it is automatically ended.
        /// </summary>
        [JsonPropertyName("duration_minutes")]
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Gets or sets the URL for hold audio. 
        /// This audio will be played to participants who are on hold.
        /// </summary>
        [JsonPropertyName("hold_audio_url")]
        public string? HoldAudioUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the hold media.
        /// This can be used to specify a media file or resource for hold music or audio.
        /// </summary>
        [JsonPropertyName("hold_media_name")]
        public string? HoldMediaName { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of participants allowed in the conference.
        /// This limits the number of participants who can join the conference at once.
        /// </summary>
        [JsonPropertyName("max_participants")]
        public int MaxParticipants { get; set; } = 250;

        /// <summary>
        /// Gets or sets whether to start the conference immediately upon creation. 
        /// If set to true, the conference will start as soon as it is created.
        /// </summary>
        [JsonPropertyName("start_conference_on_create")]
        public bool StartConferenceOnCreate { get; set; } = true;
    }
}