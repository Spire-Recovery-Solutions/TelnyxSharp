using System.Text.Json;
using System.Text.Json.Serialization;

namespace TelnyxSharp.Models.Events;

/// <summary>
/// Custom JsonConverter for handling deserialization of IEvent types based on the 'event_type' property in the JSON data.
/// </summary>
public class EventConverter : JsonConverter<IEvent>
{
    /// <summary>
    /// Determines whether the converter can convert the specified type.
    /// </summary>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <returns>True if the type is assignable to IEvent; otherwise, false.</returns>
    public override bool CanConvert(Type typeToConvert)
    {
        // Check if the type is assignable to IEvent
        return typeof(IEvent).IsAssignableFrom(typeToConvert);
    }

    /// <summary>
    /// Reads the JSON data and deserializes it into an IEvent object based on the 'event_type'.
    /// </summary>
    /// <param name="reader">The UTF-8 JSON reader.</param>
    /// <param name="typeToConvert">The type to convert.</param>
    /// <param name="options">Options for deserialization.</param>
    /// <returns>An instance of IEvent corresponding to the JSON data.</returns>
    /// <exception cref="JsonException">Thrown when the 'event_type' property is missing.</exception>
    /// <exception cref="NotSupportedException">Thrown when the event type is not supported.</exception>
    public override IEvent? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions? options)
    {
        // Parse the JSON value into a JsonDocument
        using JsonDocument doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        // Ensure the 'event_type' property is present
        if (!root.TryGetProperty("event_type", out var eventTypeProperty))
        {
            throw new JsonException("Missing 'event_type' property in the event data.");
        }

        // Get the event type as a string
        var eventType = eventTypeProperty.GetString();
        var context = TelnyxJsonSerializerContext.Default;

        // Deserialize based on the event type
        return eventType switch
        {
            "call.answered" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallAnsweredEvent),
            "call.bridged" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallBridgedEvent),
            "call.dtmf.received" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallDtmfReceivedEvent),
            "call.enqueued" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallEnqueuedEvent),
            "call.fork.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallForkStartedEvent),
            "call.fork.stopped" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallForkStoppedEvent),
            "call.gather.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallGatherEndedEvent),
            "call.hangup" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallHangupEvent),
            "call.initiated" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallInitiatedEvent),
            "call.machine.detection.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallMachineDetectionEndedEvent),
            "call.machine.greeting.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallMachineGreetingEndedEvent),
            "call.machine.premium.detection.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallMachinePremiumDetectionEndedEvent),
            "call.machine.premium.greeting.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallMachinePremiumGreetingEndedEvent),
            "call.playback.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallPlaybackEndedEvent),
            "call.playback.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallPlaybackStartedEvent),
            "call.recording.error" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallRecordingErrorEvent),
            "call.recording.saved" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallRecordingSavedEvent),
            "call.refer.completed" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallReferCompletedEvent),
            "call.refer.failed" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallReferFailedEvent),
            "call.refer.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallReferStartedEvent),
            "call.speak.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallSpeakEndedEvent),
            "call.speak.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.CallSpeakStartedEvent),
            "conference.created" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceCreatedEvent),
            "conference.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceEndedEvent),
            "conference.participant.joined" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantJoinedEvent),
            "conference.participant.left" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantLeftEvent),
            "conference.participant.playback.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantPlaybackEndedEvent),
            "conference.participant.playback.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantPlaybackStartedEvent),
            "conference.participant.speak.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantSpeakEndedEvent),
            "conference.participant.speak.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceParticipantSpeakStartedEvent),
            "conference.playback.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferencePlaybackEndedEvent),
            "conference.playback.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferencePlaybackStartedEvent),
            "conference.recording.saved" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceRecordingSavedEvent),
            "conference.speak.ended" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceSpeakEndedEvent),
            "conference.speak.started" => root.Deserialize(TelnyxJsonSerializerContext.Default.ConferenceSpeakStartedEvent),
            "message.received" => root.Deserialize(TelnyxJsonSerializerContext.Default.MessageReceivedEvent),
            "message.sent" => root.Deserialize(TelnyxJsonSerializerContext.Default.MessageSentEvent),
            _ => throw new NotSupportedException($"Event type '{eventType}' is not supported"),
        };
    }

    /// <summary>
    /// Writes the IEvent object as JSON to the specified writer.
    /// </summary>
    /// <param name="writer">The writer to write JSON to.</param>
    /// <param name="value">The IEvent object to serialize.</param>
    /// <param name="options">Options for serialization.</param>
    public override void Write(Utf8JsonWriter writer, IEvent value, JsonSerializerOptions options)
    {
        // Serialize the IEvent object to JSON
        JsonSerializer.Serialize(writer, value, value.GetType(), TelnyxJsonSerializerContext.Default);
    }
}
