using System.Text.Json.Serialization;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents sound modification parameters used to adjust audio playback characteristics.
    /// These parameters can be utilized to manipulate the sound attributes of audio files during playback.
    /// </summary>
    public class SoundModifications
    {
        /// <summary>
        /// Gets or sets the pitch adjustment for the audio. 
        /// This value represents the desired pitch level of the sound, 
        /// where a higher value increases the pitch, and a lower value decreases it.
        /// </summary>
        [JsonPropertyName("pitch")]
        public double? Pitch { get; set; }

        /// <summary>
        /// Gets or sets the semitone adjustment for the audio. 
        /// This value allows for fine-tuning the pitch in terms of semitones, 
        /// where positive values raise the pitch and negative values lower it.
        /// </summary>
        [JsonPropertyName("semitone")]
        public double? Semitone { get; set; }

        /// <summary>
        /// Gets or sets the octave adjustment for the audio.
        /// This value specifies the number of octaves to shift the sound, 
        /// with positive values raising the sound and negative values lowering it.
        /// </summary>
        [JsonPropertyName("octaves")]
        public double? Octaves { get; set; }

        /// <summary>
        /// Gets or sets the track identifier associated with the sound modifications. 
        /// This property may be used to specify which audio track the modifications should apply to.
        /// </summary>
        [JsonPropertyName("track")]
        public string? Track { get; set; }
    }
}