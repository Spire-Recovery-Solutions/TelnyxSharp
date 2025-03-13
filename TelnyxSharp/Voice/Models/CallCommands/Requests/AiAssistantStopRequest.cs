using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Request model for stopping an AI assistant in a Telnyx call command.
    /// </summary>
    public class AiAssistantStopRequest : ITelnyxRequest
    {
        /// <summary>
        /// Optional client state information that can be passed along with the request.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Optional unique identifier for the command to track it.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}