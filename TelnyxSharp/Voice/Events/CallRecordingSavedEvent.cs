using System.Text.Json.Serialization;
using TelnyxSharp.Models.Events;

namespace TelnyxSharp.Voice.Events;

/// <summary>
/// Represents an event indicating that a call recording has been saved.
/// </summary>
public class CallRecordingSavedEvent : BaseEvent
{
    /// <summary>
    /// Gets or sets the payload of the call recording saved event.
    /// </summary>
    [JsonPropertyName("payload")]
    public CallRecordingSavedPayload Payload { get; set; }
}

/// <summary>
/// Represents the payload containing details of the saved call recording.
/// </summary>
public class CallRecordingSavedPayload
{
    /// <summary>
    /// Gets or sets the unique identifier for the call leg.
    /// This ID is unique to the call and can be used to correlate webhook events.
    /// </summary>
    [JsonPropertyName("call_leg_id")]
    public string Call_leg_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the call session.
    /// This ID is unique to the call session and can be used to correlate webhook events.
    /// A call session is a group of related call legs that logically belong to the same phone call,
    /// e.g., an inbound and outbound leg of a transferred call.
    /// </summary>
    [JsonPropertyName("call_session_id")]
    public string Call_session_id { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the connection.
    /// This is the Call Control App ID (formerly Telnyx connection ID) used in the call.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string Connection_id { get; set; }

    /// <summary>
    /// Gets or sets the state of the client at the time of the event.
    /// This is the state received from a command.
    /// </summary>
    [JsonPropertyName("client_state")]
    public string Client_state { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the recording started.
    /// This is in ISO 8601 DateTimeOffset? format.
    /// </summary>
    [JsonPropertyName("recording_started_at")]
    public string Recording_started_at { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the recording ended.
    /// This is in ISO 8601 DateTimeOffset? format.
    /// </summary>
    [JsonPropertyName("recording_ended_at")]
    public string Recording_ended_at { get; set; }

    /// <summary>
    /// Gets or sets the number of channels in the recording.
    /// Possible values: [single, dual].
    /// </summary>
    [JsonPropertyName("channels")]
    public string Channels { get; set; }

    /// <summary>
    /// Gets or sets the URLs for accessing the recording.
    /// These URLs are valid for 10 minutes.
    /// </summary>
    [JsonPropertyName("recording_urls")]
    public RecordingUrls Recording_urls { get; set; }

    /// <summary>
    /// Gets or sets the public URLs for accessing the recording.
    /// These URLs are valid for as long as the file exists.
    /// For security purposes, this feature is activated on a per request basis.
    /// Please contact customer support with your Account ID to request activation.
    /// </summary>
    [JsonPropertyName("public_recording_urls")]
    public RecordingUrls Public_recording_urls { get; set; }
}

/// <summary>
/// Represents the recording URLs for a call.
/// </summary>
public class RecordingUrls
{
    /// <summary>
    /// Gets or sets the URL for the recording in MP3 format.
    /// This URL is valid for 10 minutes.
    /// </summary>
    [JsonPropertyName("mp3")]
    public string? Mp3 { get; set; }

    /// <summary>
    /// Gets or sets the URL for the recording in WAV format.
    /// This URL is valid for 10 minutes.
    /// </summary>
    [JsonPropertyName("wav")]
    public string? Wav { get; set; }
}