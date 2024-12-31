using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;


/// <summary>
/// Represents an interface for events in the system.
/// This interface defines the basic properties that all events must implement,
/// including identifiers, event type, and the timestamp of occurrence.
/// </summary>
public interface IEvent
{
    /// <summary>
    /// Gets or sets the record type of the event.
    /// Possible values: [event].
    /// </summary>
    string RecordType { get; set; }

    /// <summary>
    /// Gets or sets the type of the event.
    /// </summary>
    string EventType { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the event.
    /// This is a UUID that identifies the resource.
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the timestamp indicating when the event occurred.
    /// This is in ISO 8601 format.
    /// </summary>
    DateTimeOffset? OccurredAt { get; set; }
}

/// <summary>
/// Represents a base event that implements the IEvent interface.
/// This class includes properties for event type, ID, occurrence time,
/// payload, and record type for all derived event classes.
/// </summary>
public class BaseEvent : IEvent
{
    /// <summary>
    /// Gets or sets the type of the event.
    /// Possible values: [call.initiated].
    /// </summary>
    [JsonPropertyName("event_type")]
    public string EventType { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier for the event.
    /// This is a UUID that identifies the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }   

    /// <summary>
    /// Gets or sets the timestamp indicating when the event occurred.
    /// This is in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("occurred_at")]
    public DateTimeOffset? OccurredAt { get; set; }

    /// <summary>
    /// Gets or sets the payload associated with the event.
    /// This can be any object related to the specific event type.
    /// </summary>
    [JsonPropertyName("payload")]
    public object Payload { get; set; }

    /// <summary>
    /// Gets or sets the record type of the event.
    /// Possible values: [event].
    /// </summary>
    [JsonPropertyName("record_type")]
    public string RecordType { get; set; }
}

/// <summary>
/// Represents a Telnyx event which contains both the event data and metadata.
/// This class encapsulates the event data and its associated metadata.
/// </summary>
public class TelnyxEvent
{
    /// <summary>
    /// Gets or sets the event data.
    /// This should implement the IEvent interface and contains details about the event.
    /// </summary>
    [JsonPropertyName("data")]
    public IEvent Data { get; set; }

    /// <summary>
    /// Gets or sets the metadata associated with the Telnyx event.
    /// This includes information such as delivery attempts and delivery destination.
    /// </summary>
    [JsonPropertyName("meta")]
    public TelnyxEventMeta Meta { get; set; }
}

/// <summary>
/// Represents metadata for a Telnyx event.
/// This includes information about the delivery attempts and where the event was delivered.
/// </summary>
public class TelnyxEventMeta
{
    /// <summary>
    /// Gets or sets the number of attempts made to deliver the event.
    /// </summary>
    [JsonPropertyName("attempt")]
    public int Attempt { get; set; }

    /// <summary>
    /// Gets or sets the destination to which the event was delivered.
    /// This could be a URL or identifier representing the delivery endpoint.
    /// </summary>
    [JsonPropertyName("delivered_to")]
    public string DeliveredTo { get; set; }
}