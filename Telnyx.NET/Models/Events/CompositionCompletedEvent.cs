using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class CompositionCompletedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public CompositionCompletedPayload Payload { get; set; }
}

public class CompositionCompletedPayload
{
    [JsonPropertyName("composition_id")]
    public string Composition_id { get; set; }
    [JsonPropertyName("download_url")]
    public string Download_url { get; set; }
    [JsonPropertyName("duration_secs")]
    public int Duration_secs { get; set; }
    [JsonPropertyName("format")]
    public string Format { get; set; }
    [JsonPropertyName("resolution")]
    public string Resolution { get; set; }
    [JsonPropertyName("room_id")]
    public string Room_id { get; set; }
    [JsonPropertyName("session_id")]
    public string Session_id { get; set; }
    [JsonPropertyName("size_mb")]
    public object Size_mb { get; set; }
}