using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when a porting comment is created for a porting order.
    /// Inherits from TelnyxResponse and contains the PortingComment object with relevant details.
    /// </summary>
    public class CreatePortingCommentResponse : TelnyxResponse<PortingComment>
    {
    }

    /// <summary>
    /// Represents a comment related to a porting order.
    /// Contains details such as the comment body, the user who made the comment, and timestamps.
    /// </summary>
    public class PortingComment
    {
        /// <summary>
        /// The unique identifier for the porting comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The content of the porting comment.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// The ID of the porting order associated with the comment.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// The type of user who made the comment (e.g., admin, customer).
        /// </summary>
        [JsonPropertyName("user_type")]
        public string? UserType { get; set; }

        /// <summary>
        /// The ID of the user who made the comment.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The email of the user who made the comment.
        /// </summary>
        [JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// The type of record associated with the comment (e.g., comment, log).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The timestamp of when the comment was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}