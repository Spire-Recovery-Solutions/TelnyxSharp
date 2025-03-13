using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.CallCommands.Requests
{
    /// <summary>
    /// Represents a request to enqueue a call into a queue in the Telnyx Call Control API.
    /// This class contains the parameters required to enqueue the call.
    /// </summary>
    public class EnqueueCallRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name of the queue the call should be put in. 
        /// If a queue with the given name doesn't exist yet, it will be created.
        /// </summary>
        [JsonPropertyName("queue_name")]
        public required string QueueName { get; set; }

        /// <summary>
        /// Gets or sets the client state to add state to every subsequent webhook.
        /// This must be a valid Base-64 encoded string.
        /// </summary>
        [JsonPropertyName("client_state")]
        public string? ClientState { get; set; }

        /// <summary>
        /// Gets or sets the command ID to avoid duplicate commands.
        /// Telnyx will ignore any command with the same command_id for the same call_control_id.
        /// </summary>
        [JsonPropertyName("command_id")]
        public string? CommandId { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of seconds after which the call will be removed from the queue.
        /// </summary>
        [JsonPropertyName("max_wait_time_secs")]
        public int? MaxWaitTimeSecs { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of calls allowed in the queue at a given time.
        /// The default value is 100 and cannot be modified for an existing queue.
        /// </summary>
        [JsonPropertyName("max_size")]
        public int? MaxSize { get; set; } // Default value is 100.
    }
}