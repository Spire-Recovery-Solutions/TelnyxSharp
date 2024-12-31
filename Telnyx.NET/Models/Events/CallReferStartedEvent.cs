using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class CallReferStartedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public CallReferStartedPayload Payload { get; set; }
}

public class CallReferStartedPayload
{
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }
    [JsonPropertyName("from")]
    public string From { get; set; }
    [JsonPropertyName("sip_notify_response")]
    public int Sip_notify_response { get; set; }
    [JsonPropertyName("to")]
    public string To { get; set; }
}