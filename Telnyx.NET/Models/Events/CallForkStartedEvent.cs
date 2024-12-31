using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class CallForkStartedEvent : BaseEvent
{
    [JsonPropertyName("payload")]
    public CallForkStartedPayload Payload { get; set; }
}

public class CallForkStartedPayload
{
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }
    [JsonPropertyName("stream_type")]
    public string Stream_type { get; set; }
}