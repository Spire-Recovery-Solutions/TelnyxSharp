using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when retrieving a list of port-out events.
    /// This response contains a list of port-out events, providing details of each event in the port-out process.
    /// </summary>
    public class ListPortoutEventsResponse : TelnyxResponse<List<PortoutEvent>>
    {
    }

    /// <summary>
    /// Represents a single port-out event.
    /// This contains event-specific information such as the event type, status, and associated payload data.
    /// </summary>
    public class PortoutEvent
    {
        /// <summary>
        /// Gets or sets the unique identifier of the event.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the event.
        /// Determines the kind of event that occurred (e.g., status change, new comment).
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the associated port-out ID for this event.
        /// </summary>
        [JsonPropertyName("portout_id")]
        public string? PortoutId { get; set; }

        /// <summary>
        /// Gets or sets the list of available notification methods for this event.
        /// </summary>
        [JsonPropertyName("available_notification_methods")]
        public List<string>? AvailableNotificationMethods { get; set; }

        /// <summary>
        /// Gets or sets the status of the payload associated with this event.
        /// </summary>
        [JsonPropertyName("payload_status")]
        public string? PayloadStatus { get; set; }

        /// <summary>
        /// Gets or sets the payload data for this event. 
        /// The type of payload depends on the event type (e.g., status change, new comment).
        /// </summary>
        [JsonPropertyName("payload")]
        public BasePortoutPayload? Payload { get; set; }

        /// <summary>
        /// Gets or sets the record type for this event.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the event was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the event was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Base class for port-out event payloads.
    /// This class is extended by specific event types like status changes, comments, and FOC date changes.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "event_type")]
    [JsonDerivedType(typeof(StatusChangedPayload), "portout.status_changed")]
    [JsonDerivedType(typeof(NewCommentPayload), "portout.new_comment")]
    [JsonDerivedType(typeof(FocDateChangedPayload), "portout.foc_date_changed")]
    public abstract class BasePortoutPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier for the payload.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    /// <summary>
    /// Represents the payload for a status change event in the port-out process.
    /// Includes information about the new status, phone numbers involved, carrier, and rejection reasons if applicable.
    /// </summary>
    public class StatusChangedPayload : BasePortoutPayload
    {
        /// <summary>
        /// Gets or sets the new status of the port-out.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the list of phone numbers associated with this status change.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the carrier name associated with the port-out.
        /// </summary>
        [JsonPropertyName("carrier_name")]
        public string? CarrierName { get; set; }

        /// <summary>
        /// Gets or sets the SPID (Service Profile Identifier) for the port-out.
        /// </summary>
        [JsonPropertyName("spid")]
        public string? Spid { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the individual who initiated or is responsible for the status change.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the subscriber name associated with the port-out.
        /// </summary>
        [JsonPropertyName("subscriber_name")]
        public string? SubscriberName { get; set; }

        /// <summary>
        /// Gets or sets the reason for the rejection, if applicable.
        /// </summary>
        [JsonPropertyName("rejection_reason")]
        public string? RejectionReason { get; set; }

        /// <summary>
        /// Gets or sets the PIN that was attempted during the port-out process.
        /// </summary>
        [JsonPropertyName("attempted_pin")]
        public string? AttemptedPin { get; set; }
    }

    /// <summary>
    /// Represents the payload for a new comment event in the port-out process.
    /// Contains details about the user who created the comment and the content of the comment.
    /// </summary>
    public class NewCommentPayload : BasePortoutPayload
    {
        /// <summary>
        /// Gets or sets the port-out ID associated with this comment.
        /// </summary>
        [JsonPropertyName("portout_id")]
        public string? PortoutId { get; set; }

        /// <summary>
        /// Gets or sets the user ID of the individual who made the comment.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the content of the comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }

    /// <summary>
    /// Represents the payload for an FOC (Firm Order Commitment) date change event.
    /// Contains the user ID of the individual who made the change and the new FOC date.
    /// </summary>
    public class FocDateChangedPayload : BasePortoutPayload
    {
        /// <summary>
        /// Gets or sets the user ID of the individual who made the FOC date change.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the new FOC date.
        /// </summary>
        [JsonPropertyName("foc_date")]
        public DateTimeOffset? FocDate { get; set; }
    }
}