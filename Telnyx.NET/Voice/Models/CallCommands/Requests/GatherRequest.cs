using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Request model for gathering digits input from the caller during a Telnyx voice call.
    /// </summary>
    public class GatherRequest : ITelnyxRequest
    {
        /// <summary>
        /// The minimum number of digits required from the caller.
        /// Default is 1.
        /// </summary>
        [JsonPropertyName("minimum_digits")]
        public int MinimumDigits { get; set; } = 1;

        /// <summary>
        /// The maximum number of digits allowed from the caller.
        /// Default is 128.
        /// </summary>
        [JsonPropertyName("maximum_digits")]
        public int MaximumDigits { get; set; } = 128;

        /// <summary>
        /// The timeout in milliseconds for receiving digits.
        /// Default is 60,000 ms (60 seconds).
        /// </summary>
        [JsonPropertyName("timeout_millis")]
        public int TimeoutMillis { get; set; } = 60000;

        /// <summary>
        /// The timeout in milliseconds for detecting a pause between digits.
        /// Default is 5,000 ms (5 seconds).
        /// </summary>
        [JsonPropertyName("inter_digit_timeout_millis")]
        public int InterDigitTimeoutMillis { get; set; } = 5000;

        /// <summary>
        /// The initial timeout in milliseconds before starting to gather digits.
        /// Default is 5,000 ms (5 seconds).
        /// </summary>
        [JsonPropertyName("initial_timeout_millis")]
        public int InitialTimeoutMillis { get; set; } = 5000;

        /// <summary>
        /// A terminating digit (e.g., "#" or "*") that indicates the end of the input.
        /// Default is "#".
        /// </summary>
        [JsonPropertyName("terminating_digit")]
        public string? TerminatingDigit { get; set; } = "#";

        /// <summary>
        /// A string of valid digits that are allowed as input.
        /// If not set, all digits are valid.
        /// </summary>
        [JsonPropertyName("valid_digits")]
        public string? ValidDigits { get; set; }

        /// <summary>
        /// An optional unique identifier for the gather request.
        /// </summary>
        [JsonPropertyName("gather_id")]
        public string? GatherId { get; set; }

        /// <summary>
        /// An optional field for passing along client-specific state data.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// An optional unique identifier for the command to track it.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}