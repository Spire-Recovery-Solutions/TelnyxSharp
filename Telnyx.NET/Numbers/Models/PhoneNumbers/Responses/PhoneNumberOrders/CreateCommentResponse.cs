using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for creating a comment associated with a phone number order.
    /// </summary>
    public class CreateCommentResponse : TelnyxResponse<CommentData>
    {
    }

    /// <summary>
    /// Represents the data associated with a comment in a phone number order.
    /// </summary>
    public class CommentData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the body content of the comment.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Gets or sets the name or identifier of the commenter.
        /// </summary>
        [JsonPropertyName("commenter")]
        public string? Commenter { get; set; }

        /// <summary>
        /// Gets or sets the type of the commenter (e.g., user, system, etc.).
        /// </summary>
        [JsonPropertyName("commenter_type")]
        public string? CommenterType { get; set; }

        /// <summary>
        /// Gets or sets the type of record the comment is associated with.
        /// </summary>
        /// <remarks>
        /// Indicates the type of entity the comment pertains to, such as a sub-number order or other record.
        /// </remarks>
        [JsonPropertyName("comment_record_type")]
        public string? CommentRecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the record the comment is associated with.
        /// </summary>
        [JsonPropertyName("comment_record_id")]
        public string? CommentRecordId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the comment was read.
        /// </summary>
        /// <remarks>
        /// If <c>null</c>, the comment has not been read yet.
        /// </remarks>
        [JsonPropertyName("read_at")]
        public DateTimeOffset? ReadAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the comment was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the comment was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}