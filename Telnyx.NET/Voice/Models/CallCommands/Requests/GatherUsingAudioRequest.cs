using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to gather user input via an audio prompt in a Telnyx voice call.
    /// This class allows configuration for audio URLs, digit collection, and input timeouts.
    /// </summary>
    public class GatherUsingAudioRequest : ITelnyxRequest
    {
        /// <summary>
        /// The URL of the audio file to be played for gathering user input.
        /// This audio prompt will guide the user on what to input.
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// A name for the media to be used for identification purposes.
        /// This name can be used for logging or further processing.
        /// </summary>
        [JsonPropertyName("media_name")]
        public string? MediaName { get; set; }

        /// <summary>
        /// The URL of the audio file to be played when an invalid audio file URL is provided.
        /// This can be used for fallback or error handling scenarios.
        /// </summary>
        [JsonPropertyName("invalid_audio_url")]
        public string? InvalidAudioUrl { get; set; }

        /// <summary>
        /// The media name to be used when an invalid media name is encountered.
        /// This is typically used in fallback scenarios for error handling.
        /// </summary>
        [JsonPropertyName("invalid_media_name")]
        public string? InvalidMediaName { get; set; }

        /// <summary>
        /// The minimum number of digits that must be entered by the user. 
        /// Defaults to 1, meaning at least one digit is required.
        /// </summary>
        [JsonPropertyName("minimum_digits")]
        public int MinimumDigits { get; set; } = 1;

        /// <summary>
        /// The maximum number of digits that can be entered by the user.
        /// Defaults to 128, allowing a wide range of digit inputs.
        /// </summary>
        [JsonPropertyName("maximum_digits")]
        public int MaximumDigits { get; set; } = 128;

        /// <summary>
        /// The maximum number of attempts allowed for gathering user input.
        /// Defaults to 3 attempts.
        /// </summary>
        [JsonPropertyName("maximum_tries")]
        public int MaximumTries { get; set; } = 3;

        /// <summary>
        /// The timeout duration in milliseconds for waiting for user input.
        /// Defaults to 60000 milliseconds (60 seconds).
        /// </summary>
        [JsonPropertyName("timeout_millis")]
        public int TimeoutMillis { get; set; } = 60000;

        /// <summary>
        /// The digit that, when entered by the user, will terminate the input collection.
        /// Defaults to "#" as the terminating digit.
        /// </summary>
        [JsonPropertyName("terminating_digit")]
        public string TerminatingDigit { get; set; } = "#";

        /// <summary>
        /// A string representing the valid digits that can be entered by the user.
        /// This is used to restrict input to specific digits.
        /// </summary>
        [JsonPropertyName("valid_digits")]
        public string? ValidDigits { get; set; }

        /// <summary>
        /// The timeout duration in milliseconds between consecutive digit entries.
        /// Defaults to 5000 milliseconds (5 seconds).
        /// </summary>
        [JsonPropertyName("inter_digit_timeout_millis")]
        public int InterDigitTimeoutMillis { get; set; } = 5000;

        /// <summary>
        /// An optional client-specific state that can be used to store any relevant data 
        /// related to the request for further processing.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// An optional unique identifier for the command that can be used for tracking 
        /// or correlating the request to other commands or actions.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}