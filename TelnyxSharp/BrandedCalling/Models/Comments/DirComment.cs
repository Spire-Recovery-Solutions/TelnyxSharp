using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.Comments
{
    /// <summary>
    /// Represents a customer-visible comment on a Display Identity Record (DIR).
    /// </summary>
    public class DirComment
    {
        /// <summary>
        /// Server-assigned unique identifier of the comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Resource the comment is attached to. Always "dir" on this endpoint.
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string? EntityType { get; set; }

        /// <summary>
        /// The comment body.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Always "customer" on this endpoint — internal-only comments are filtered out.
        /// </summary>
        [JsonPropertyName("visibility")]
        public string? Visibility { get; set; }

        /// <summary>
        /// Who wrote the comment: "customer" or "admin" (the Telnyx vetting team).
        /// </summary>
        [JsonPropertyName("author_role")]
        public string? AuthorRole { get; set; }

        /// <summary>
        /// Display name of the author. May be null.
        /// </summary>
        [JsonPropertyName("author_name")]
        public string? AuthorName { get; set; }

        /// <summary>
        /// Comment categorisation.
        /// </summary>
        [JsonPropertyName("comment_type")]
        public DirCommentType? CommentType { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the comment was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }
    }
}
