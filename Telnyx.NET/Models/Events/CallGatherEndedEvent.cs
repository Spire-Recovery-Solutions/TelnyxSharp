using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class CallGatherEndedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public CallGatherEndedPayload Payload { get; set; }
}

public class CallGatherEndedPayload
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
    [JsonPropertyName("from")]
    public string From { get; set; }
    [JsonPropertyName("to")]
    public string To { get; set; }
    [JsonPropertyName("digits")]
    public string Digits { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
}