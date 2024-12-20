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
        public SendMessageData Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a sent message.
    /// </summary>
    public partial class SendMessageData : MessageBaseResponse
    {
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        [JsonPropertyName("direction")]
        public string? Direction { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        [JsonPropertyName("messaging_profile_id")]
        public string? MessagingProfileId { get; set; }

        [JsonPropertyName("from")]
        public FromTo? From { get; set; }

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

    
}
