using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ConferencePlaybackStartedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ConferencePlaybackStartedPayload Payload { get; set; }
}

public class ConferencePlaybackStartedPayload
{
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("creator_call_session_id")]
    public string Creator_call_session_id { get; set; }
    [JsonPropertyName("conference_id")]
    public string Conference_id { get; set; }
    [JsonPropertyName("media_url")]
    public string Media_url { get; set; }
    [JsonPropertyName("media_name")]
    public string Media_name { get; set; }
    [JsonPropertyName("occurred_at")]
    public string Occurred_at { get; set; }
}