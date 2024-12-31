using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ParticipantJoinedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ParticipantJoinedPayload Payload { get; set; }
}

public class ParticipantJoinedPayload
{
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
    [JsonPropertyName("context")]
    public string Context { get; set; }
    [JsonPropertyName("participant_id")]
    public string Participant_id { get; set; }
}