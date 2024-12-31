using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ParticipantLeftEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ParticipantLeftPayload Payload { get; set; }
}

public class ParticipantLeftPayload
{
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
    [JsonPropertyName("context")]
    public string Context { get; set; }
    [JsonPropertyName("participant_id")]
    public string Participant_id { get; set; }
    [JsonPropertyName("duration_secs")]
    public int Duration_secs { get; set; }
    [JsonPropertyName("left_reason")]
    public string Left_reason { get; set; }
}