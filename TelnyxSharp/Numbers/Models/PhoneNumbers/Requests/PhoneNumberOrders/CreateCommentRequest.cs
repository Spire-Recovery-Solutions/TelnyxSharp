using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to create a comment for a specific record in the Telnyx platform.
    /// </summary>
    public class CreateCommentRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the content of the comment.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Gets or sets the type of record the comment is associated with.
        /// For example, this could be a phone number order or another entity.
        /// </summary>
        [JsonPropertyName("comment_record_type")]
        public string? CommentRecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the record the comment is associated with.
        /// </summary>
        [JsonPropertyName("comment_record_id")]
        public string? CommentRecordId { get; set; }
    }
}