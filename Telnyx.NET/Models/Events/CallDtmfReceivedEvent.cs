using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class CallDtmfReceivedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public CallDtmfReceivedPayload Payload { get; set; }
}

public class CallDtmfReceivedPayload
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
    [JsonPropertyName("digit")]
    public string Digit { get; set; }
}