using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ConferenceSpeakEndedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ConferenceSpeakEndedPayload Payload { get; set; }
}

public class ConferenceSpeakEndedPayload
{
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("creator_call_session_id")]
    public string Creator_call_session_id { get; set; }
    [JsonPropertyName("conference_id")]
    public string Conference_id { get; set; }
    [JsonPropertyName("occurred_at")]
    public string Occurred_at { get; set; }
}