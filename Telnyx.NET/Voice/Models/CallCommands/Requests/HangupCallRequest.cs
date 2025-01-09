using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to hang up a call in the Telnyx API.
    /// This request includes parameters to manage state and avoid duplicate commands.
    /// </summary>
    public class HangupCallRequest : ITelnyxRequest
    {
        /// <summary>
        /// Use this field to add state to every subsequent webhook.
        /// It must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Use this field to avoid duplicate commands.
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}