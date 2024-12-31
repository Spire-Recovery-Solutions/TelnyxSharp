using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ConferenceRecordingSavedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ConferenceRecordingSavedPayload Payload { get; set; }
}

public class ConferenceRecordingSavedPayload
{
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }
    [JsonPropertyName("channels")]
    public string Channels { get; set; }
    [JsonPropertyName("conference_id")]
    public string Conference_id { get; set; }
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("format")]
    public string Format { get; set; }
    [JsonPropertyName("public_recording_urls")]
    public object Public_recording_urls { get; set; }
    [JsonPropertyName("recording_ended_at")]
    public string Recording_ended_at { get; set; }
    [JsonPropertyName("recording_id")]
    public string Recording_id { get; set; }
    [JsonPropertyName("recording_started_at")]
    public string Recording_started_at { get; set; }
    [JsonPropertyName("recording_urls")]
    public object Recording_urls { get; set; }
}