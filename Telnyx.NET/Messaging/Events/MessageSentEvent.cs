using System.Text.Json.Serialization;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Messaging.Events;

public class MessageSentEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public MessageSentPayload Payload { get; set; }
}

public class MessageSentPayload
{
    [JsonPropertyName("record_type")]
    public string RecordType { get; set; }

    [JsonPropertyName("direction")]
    public string Direction { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("messaging_profile_id")]
    public string MessagingProfileId { get; set; }

    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }

    [JsonPropertyName("from")]
    public MessageFrom From { get; set; }

    [JsonPropertyName("to")]
    public List<MessageToCc> To { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    [JsonPropertyName("media")]
    public List<MessageMedia> Media { get; set; }

    [JsonPropertyName("webhook_url")]
    public string WebhookUrl { get; set; }

    [JsonPropertyName("webhook_failover_url")]
    public string WebhookFailoverUrl { get; set; }

    [JsonPropertyName("encoding")]
    public string Encoding { get; set; }

    [JsonPropertyName("parts")]
    public int Parts { get; set; }

    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }

    [JsonPropertyName("cost")]
    public object Cost { get; set; }

    [JsonPropertyName("received_at")]
    public DateTimeOffset? ReceivedAt { get; set; }

    [JsonPropertyName("sent_at")]
    public object SentAt { get; set; }

    [JsonPropertyName("completed_at")]
    public object CompletedAt { get; set; }

    [JsonPropertyName("valid_until")]
    public object ValidUntil { get; set; }

    [JsonPropertyName("errors")]
    public List<object> Errors { get; set; }
}

public class MessageMedia
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("content_type")]
    public string ContentType { get; set; }

    [JsonPropertyName("sha256")]
    public string Sha256 { get; set; }

    [JsonPropertyName("size")]
    public int? Size { get; set; }
}