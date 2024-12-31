using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class SessionStartedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public SessionStartedPayload Payload { get; set; }
}

public class SessionStartedPayload
{
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
}