using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Voice.Models.QueueCommands.Responses
{
    /// <summary>
    /// Represents the response to a request for retrieving a list of calls from a queue in the Telnyx Voice API.
    /// Inherits from <see cref="TelnyxResponse{T}"/> to provide standard response structure for a list of queue calls.
    /// </summary>
    public class RetrieveCallsQueueResponse : TelnyxResponse<List<RetrieveCallsQueueData>>
    {
    }

    /// <summary>
    /// Contains the data for a single call in the queue.
    /// This includes call details such as identifiers, caller/recipient information, and queue-related metadata.
    /// </summary>
    public class RetrieveCallsQueueData
    {
        /// <summary>
        /// Gets or sets the type of record associated with the call. Default is "queue_call".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "queue_call";

        /// <summary>
        /// Gets or sets the unique identifier for the call session.
        /// </summary>
        [JsonPropertyName("call_session_id")]
        public string CallSessionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the call leg.
        /// </summary>
        [JsonPropertyName("call_leg_id")]
        public string CallLegId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the call control.
        /// </summary>
        [JsonPropertyName("call_control_id")]
        public string CallControlId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unique identifier for the connection associated with the call.
        /// </summary>
        [JsonPropertyName("connection_id")]
        public string ConnectionId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number or identifier for the caller.
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number or identifier for the recipient.
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the call was enqueued in the queue.
        /// </summary>
        [JsonPropertyName("enqueued_at")]
        public string EnqueuedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the amount of time (in seconds) the call has been waiting in the queue.
        /// </summary>
        [JsonPropertyName("wait_time_secs")]
        public int WaitTimeSecs { get; set; }

        /// <summary>
        /// Gets or sets the position of the call in the queue.
        /// </summary>
        [JsonPropertyName("queue_position")]
        public int QueuePosition { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the queue where the call is waiting.
        /// </summary>
        [JsonPropertyName("queue_id")]
        public string QueueId { get; set; } = string.Empty;
    }
}