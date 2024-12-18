
using System.Text.Json.Serialization;

using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public partial class SendMessageResponse : ITelnyxResponse
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

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
        public From From { get; set; }

        [JsonPropertyName("to")]
        public List<From> To { get; set; }

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
        public List<string> Errors { get; set; }

        [JsonPropertyName("original_text")]
        public string? OriginalText { get; set; }
    }

    public partial class Cost
    {
        [JsonPropertyName("cost")]
        public string? CostCost { get; set; }

        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }

    public partial class From
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
}
