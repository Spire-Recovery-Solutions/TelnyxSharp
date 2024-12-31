using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class SessionEndedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public SessionEndedPayload Payload { get; set; }
}

public class SessionEndedPayload
{
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
    [JsonPropertyName("duration_secs")]
    public int Duration_secs { get; set; }
    [JsonPropertyName("ended_reason")]
    public string Ended_reason { get; set; }
}