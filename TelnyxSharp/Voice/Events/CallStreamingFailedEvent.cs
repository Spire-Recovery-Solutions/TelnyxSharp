using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events;

/// <summary>
/// Represents an event indicating that a call streaming has failed.
/// This event contains a payload with details about the call and the failure reason.
/// </summary>
public class CallStreamingFailedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call streaming failed event.
    /// This payload contains various details regarding the call and the failure information.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallStreamingFailedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the failed call streaming.
/// This includes identifiers for call control, connection, call leg,
/// session, client state, failure reason, stream ID, and additional stream parameters.
/// </summary>
public class CallStreamingFailedPayload
{
    /// <summary>
    /// Gets or sets the unique identifier for the call control.
    /// This ID is used to issue commands via the Call Control API.
    /// </summary>
    [JsonPropertyName("call_control_id")]
    public string Call_control_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the connection.
    /// This is the Call Control App ID (formerly Telnyx connection ID) used in the call.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call leg.
    /// This ID is unique to the call and can be used to correlate webhook events.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call session.
    /// This ID can be used to correlate webhook events and represents a group of 
    /// related call legs that logically belong to the same phone call,
    /// e.g., an inbound and outbound leg of a transferred call.
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the state of the client at the time of the event.
    /// This state is received from a command.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets a short description explaining why the media streaming failed.
    /// </summary>
    [JsonPropertyName("failure_reason")]
    public string Failure_reason { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the stream.
    /// </summary>
    [JsonPropertyName("stream_id")]
    public string Stream_id { get; set; }

    /// <summary>
    /// Gets or sets the parameters related to the stream.
    /// </summary>
    [JsonPropertyName("stream_params")]
    public StreamParams StreamParams { get; set; }

    /// <summary>
    /// Gets or sets the type of the stream connection.
    /// Possible values: [websocket, dialogflow].
    /// </summary>
    [JsonPropertyName("stream_type")]
    public string Stream_type { get; set; }
}

/// <summary>
/// Represents the parameters for a streaming event.
/// This includes the stream URL and the associated track.
/// </summary>
public class StreamParams
{
    /// <summary>
    /// Gets or sets the URL for the stream.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public string StreamUrl { get; set; }

    /// <summary>
    /// Gets or sets the track associated with the stream.
    /// Possible values: [inbound_track, outbound_track, both_tracks].
    /// Default value: inbound_track.
    /// </summary>
    [JsonPropertyName("track")]
    public string Track { get; set; }
}