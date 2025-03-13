using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when retrieving a list of comments associated with a specific port-out order.
    /// This response contains a list of port-out comments, providing details of each comment in the context of the port-out process.
    /// </summary>
    public class PortoutCommentsResponse : TelnyxResponse<List<PortoutComment>>
    {
    }

    /// <summary>
    /// Represents a comment related to a specific port-out order.
    /// The comment contains metadata such as the ID of the comment, the body of the comment,
    /// the user who created it, and the associated port-out order.
    /// </summary>
    public class PortoutComment
    {
        /// <summary>
        /// Gets or sets the unique identifier of the comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the record type associated with the comment.
        /// This provides additional context about the type of record the comment belongs to.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the body content of the comment.
        /// This contains the actual message or information shared in the comment.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the port-out order ID that this comment is associated with.
        /// This helps to link the comment to a specific port-out order.
        /// </summary>
        [JsonPropertyName("portout_id")]
        public string? PortoutId { get; set; }

        /// <summary>
        /// Gets or sets the unique user identifier for the user who created the comment.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the comment was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
