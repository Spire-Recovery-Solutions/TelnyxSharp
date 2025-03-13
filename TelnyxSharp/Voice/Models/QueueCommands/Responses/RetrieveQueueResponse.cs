using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Voice.Models.QueueCommands.Responses
{
    /// <summary>
    /// Represents the response to a request for retrieving information about a specific queue in the Telnyx Voice API.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> to provide the standard response structure for queue data.
    /// </summary>
    public class RetrieveQueueResponse : TelnyxResponse<RetrieveQueueResponseData>
    {
    }

    /// <summary>
    /// Contains the data for a specific queue in the Telnyx Voice API.
    /// This includes queue details such as the queue's ID, name, size, and wait times.
    /// </summary>
    public class RetrieveQueueResponseData
    {
        /// <summary>
        /// Gets or sets the type of record associated with the queue. Default value is "queue".
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = "queue";

        /// <summary>
        /// Gets or sets the unique identifier for the queue.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the queue.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the queue was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the queue was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the current size of the queue, representing the number of calls currently in the queue.
        /// </summary>
        [JsonPropertyName("current_size")]
        public int CurrentSize { get; set; }

        /// <summary>
        /// Gets or sets the maximum allowed size of the queue.
        /// </summary>
        [JsonPropertyName("max_size")]
        public int MaxSize { get; set; }

        /// <summary>
        /// Gets or sets the average wait time (in seconds) for calls in the queue.
        /// </summary>
        [JsonPropertyName("average_wait_time_secs")]
        public int AverageWaitTimeSecs { get; set; }
    }
}