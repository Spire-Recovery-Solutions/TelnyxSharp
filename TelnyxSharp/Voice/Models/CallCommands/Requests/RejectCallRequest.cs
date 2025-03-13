using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to reject a call in the Telnyx API.
    /// This request requires a call_control_id path parameter and a JSON body containing client_state, command_id, and cause.
    /// </summary>
    public class RejectCallRequest : ITelnyxRequest
    {
        /// <summary>
        /// Use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Use this field to avoid duplicate commands. Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Cause for call rejection. Possible values: [CALL_REJECTED, USER_BUSY].
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonConverter(typeof(JsonStringEnumConverter<RejectCallCause>))]
        public required RejectCallCause Cause { get; set; }
    }
}