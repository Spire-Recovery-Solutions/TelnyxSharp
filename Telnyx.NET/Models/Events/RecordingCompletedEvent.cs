using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class RecordingCompletedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public RecordingCompletedPayload Payload { get; set; }
}

public class RecordingCompletedPayload
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
    [JsonPropertyName("size_mb")]
    public object Size_mb { get; set; }
    [JsonPropertyName("download_url")]
    public string Download_url { get; set; }
    [JsonPropertyName("codec")]
    public string Codec { get; set; }
    [JsonPropertyName("duration_secs")]
    public int Duration_secs { get; set; }
}