using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to gather user input via spoken prompts in a Telnyx voice call.
    /// This class allows configuration for the payload to be spoken, digit collection, and input timeouts.
    /// </summary>
    public class GatherUsingSpeakRequest : ITelnyxRequest
    {
        /// <summary>
        /// The text or speech payload to be spoken to the user. This could be a prompt for the user to input digits.
        /// </summary>
        [JsonPropertyName("payload")]
        public required string Payload { get; set; }

        /// <summary>
        /// The payload to be spoken if the initial payload is invalid. 
        /// This can be used for error handling or fallback scenarios.
        /// </summary>
        [JsonPropertyName("invalid_payload")]
        public string? InvalidPayload { get; set; }

        /// <summary>
        /// The type of the payload, specifying whether it's text or SSML (Speech Synthesis Markup Language).
        /// Defaults to `Text` if not specified.
        /// </summary>
        [JsonPropertyName("payload_type")]
        public PayloadType? PayloadType { get; set; } = Enums.PayloadType.Text;

        /// <summary>
        /// The service level for the call, such as `Premium` or `Standard`. 
        /// Defines the quality and type of voice service to be used.
        /// Defaults to `Premium` if not specified.
        /// </summary>
        [JsonPropertyName("service_level")]
        public ServiceLevel? ServiceLevel { get; set; } = Enums.ServiceLevel.Premium;

        /// <summary>
        /// The voice that will be used for the spoken payload. This can specify male or female voices or specific regional accents.
        /// </summary>
        [JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// The language in which the payload will be spoken. 
        /// The language should be specified in a language code format, such as `en-US` for English.
        /// </summary>
        [JsonPropertyName("language")]
        public Language? Language { get; set; }

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