using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Request model for stopping the gather action in a Telnyx voice call.
    /// </summary>
    public class GatherStopRequest : ITelnyxRequest
    {
        /// <summary>
        /// An optional field for passing along client-specific state data.
        /// This is typically used to track or manage the request in client applications.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// An optional unique identifier for the command to track it.
        /// This helps correlate the gather stop command with the previously initiated command.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}