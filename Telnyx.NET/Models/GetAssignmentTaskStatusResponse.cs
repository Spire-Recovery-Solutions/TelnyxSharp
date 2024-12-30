using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving the status of an assignment task.
    /// </summary>
    public class GetAssignmentTaskStatusResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the task ID associated with the assignment task.
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status of the assignment task.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the creation timestamp of the assignment task.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the assignment task.
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the list of errors, if any, that occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}