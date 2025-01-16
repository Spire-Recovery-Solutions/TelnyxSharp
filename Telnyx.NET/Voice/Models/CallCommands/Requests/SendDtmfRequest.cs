using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to send DTMF (Dual-tone multi-frequency) signals during a call.
    /// </summary>
    public class SendDtmfRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the DTMF digits to be sent during the call.
        /// These digits correspond to the tones sent during the call, such as '1', '2', 'A', 'B', etc.
        /// </summary>
        [JsonPropertyName("digits")]
        public required string Digits { get; set; }

        /// <summary>
        /// Gets or sets the duration of the DTMF signal in milliseconds.
        /// The default value is 250 milliseconds if not specified.
        /// </summary>
        [JsonPropertyName("duration_millis")]
        public int? DurationMillis { get; set; } = 250;

        /// <summary>
        /// Gets or sets the client state associated with the DTMF send request.
        /// This can be used to track the state of the request from the client's perspective.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the unique command ID for the DTMF send request.
        /// This ID can be used for tracking and managing multiple requests.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}