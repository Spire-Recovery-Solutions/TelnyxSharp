using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.ConferenceCommands.Requests
{
    /// <summary>
    /// Request model for playing audio to a conference.
    /// This model includes options for specifying the audio URL, media name, loop behavior, and participants in the conference.
    /// </summary>
    public class PlayAudioToConferenceRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the URL of the audio file to play to the conference participants.
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the media to play to the conference participants.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string? MediaName { get; set; }

        /// <summary>
        /// Gets or sets the loop configuration for the audio playback.
        /// Specifies how many times the audio should repeat during the conference.
        /// </summary>
        [JsonPropertyName("loop")]
        public Loop? Loop { get; set; }

        /// <summary>
        /// Gets or sets the list of call control IDs of participants who should receive the audio.
        /// </summary>
        [JsonPropertyName("call_control_ids")]
        public List<string>? CallControlIds { get; set; }
    }

    /// <summary>
    /// Abstract base class for defining loop configurations for audio playback.
    /// This class is used as the base type for different loop configuration classes.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(MOD1), "string")]
    [JsonDerivedType(typeof(MOD2), "integer")]
    public abstract class Loop { }

    /// <summary>
    /// Represents a loop configuration where the audio repeats infinitely.
    /// </summary>
    public class MOD1 : Loop
    {
        /// <summary>
        /// Gets or sets the loop value, which in this case is always "infinity" to indicate infinite loop.
        /// </summary>
        [JsonPropertyName("MOD1")]
        public string Value { get; set; } = "infinity";
    }

    /// <summary>
    /// Represents a loop configuration with a specific number of repetitions.
    /// The value must be between 1 and 100.
    /// </summary>
    public class MOD2 : Loop
    {
        /// <summary>
        /// Gets or sets the number of times to loop the audio.
        /// The value must be between 1 and 100.
        /// </summary>
        [JsonPropertyName("MOD2")]
        [Range(1, 100)]
        public int Value { get; set; }
    }
}