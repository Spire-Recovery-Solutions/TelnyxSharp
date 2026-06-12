using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.Comments.Requests
{
    /// <summary>
    /// Represents a request to post a customer comment on a Display Identity Record (DIR).
    /// The server forces the comment type to "customer_inquiry", visibility to "customer", and
    /// author role to "customer"; clients cannot override these.
    /// </summary>
    public class CreateDirCommentRequest : ITelnyxRequest
    {
        /// <summary>
        /// Comment body (1-5000 characters). Required.
        /// </summary>
        [JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Optional parent comment id to thread this reply under.
        /// </summary>
        [JsonPropertyName("parent_comment_id")]
        public string? ParentCommentId { get; set; }
    }
}
