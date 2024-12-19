using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response returned after sending a message via the Telnyx API.
    /// </summary>
    public partial class SendMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Contains the data associated with the sent message.
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a sent message.
    /// </summary>
    public partial class Data
    {
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("direction")]
        public string? Direction { get; set; }

        [JsonPropertyName("id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("organization_id")]
        public Guid? OrganizationId { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public Guid? MessagingProfileId { get; set; }

        [JsonPropertyName("from")]
        public FromTo From { get; set; }

        [JsonPropertyName("to")]
        public List<FromTo> To { get; set; }

        [JsonPropertyName("cc")]
        public List<string> Cc { get; set; }

        [JsonPropertyName("subject")]
        public string? Subject { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("media")]
        public List<Media> Media { get; set; }

        [JsonPropertyName("webhook_url")]
        public Uri WebhookUrl { get; set; }

        [JsonPropertyName("webhook_failover_url")]
        public string? WebhookFailoverUrl { get; set; }

        [JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        [JsonPropertyName("parts")]
        public long? Parts { get; set; }

        [JsonPropertyName("cost")]
        public Cost Cost { get; set; }

        [JsonPropertyName("tcr")]
        public string? Tcr { get; set; }

        [JsonPropertyName("received_at")]
        public DateTimeOffset? ReceivedAt { get; set; }

        [JsonPropertyName("sent_at")]
        public DateTimeOffset? SentAt { get; set; }

        [JsonPropertyName("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        [JsonPropertyName("valid_until")]
        public DateTimeOffset? ValidUntil { get; set; }

        [JsonPropertyName("errors")]
        public List<Error>? Errors { get; set; }
    }

    /// <summary>
    /// Represents the cost associated with sending a message.
    /// </summary>
    public partial class Cost
    {
        [JsonPropertyName("amount")]
        public decimal? Amount { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }

    /// <summary>
    /// Represents the sender or recipient of a message.
    /// </summary>
    public partial class FromTo
    {
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        [JsonPropertyName("carrier")]
        public string? Carrier { get; set; }

        [JsonPropertyName("line_type")]
        public string? LineType { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }
    }

    /// <summary>
    /// Represents a media file associated with a message.
    /// </summary>
    public partial class Media
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        [JsonPropertyName("sha256")]
        public string? Sha256 { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }
    }

    /// <summary>
    /// Represents an error encountered during the message processing.
    /// </summary>
    public class Error
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("detail")]
        public string Detail { get; set; } = string.Empty;

        [JsonPropertyName("source")]
        public ErrorSource? Source { get; set; }

        [JsonPropertyName("meta")]
        public object Meta { get; set; }
    }
}
