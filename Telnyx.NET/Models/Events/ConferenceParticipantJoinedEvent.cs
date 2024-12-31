using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class ConferenceParticipantJoinedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public ConferenceParticipantJoinedPayload Payload { get; set; }
}

public class ConferenceParticipantJoinedPayload
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
}