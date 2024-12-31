using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class RecordingStartedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public RecordingStartedPayload Payload { get; set; }
}

public class RecordingStartedPayload
{
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
    [JsonPropertyName("participant_id")]
    public string Participant_id { get; set; }
    [JsonPropertyName("recording_id")]
    public string Recording_id { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
}