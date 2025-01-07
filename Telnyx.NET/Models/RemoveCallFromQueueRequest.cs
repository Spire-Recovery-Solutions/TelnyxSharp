using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents a request to remove a call from a queue using the Telnyx Call Control API.
    /// This request can be used to dequeue a call that is currently enqueued.
    /// </summary>
    public class RemoveCallFromQueueRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the client state to be included with every subsequent webhook.
        /// It must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets a unique identifier used to avoid duplicate commands.
        /// Telnyx will ignore any command with the same `command_id` for the same `call_control_id`.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }
    }
}