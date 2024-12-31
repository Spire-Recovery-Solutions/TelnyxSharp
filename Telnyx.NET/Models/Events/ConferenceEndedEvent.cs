using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ConferenceEndedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ConferenceEndedPayload Payload { get; set; }
}

public class ConferenceEndedPayload
{
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }
    [JsonPropertyName("conference_id")]
    public string Conference_id { get; set; }
    [JsonPropertyName("occurred_at")]
    public string Occurred_at { get; set; }
    [JsonPropertyName("reason")]
    public string Reason { get; set; }
}