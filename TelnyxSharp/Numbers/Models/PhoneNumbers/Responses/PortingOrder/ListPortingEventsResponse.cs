using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response from the Telnyx API containing a list of porting events.
    /// </summary>
    public class ListPortingEventsResponse : TelnyxResponse<List<PortingEvent>>
    {
    }

    /// <summary>
    /// Represents a single porting event associated with a porting order.
    /// </summary>
    public class PortingEvent
    {
        /// <summary>
        /// Gets or sets the unique identifier for the porting event.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of event (e.g., "porting_order.deleted", "porting_order.status_changed").
        /// </summary>
        [JsonPropertyName("event_type")]
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the porting order associated with the event.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the available notification methods for the porting event.
        /// </summary>
        [JsonPropertyName("available_notification_methods")]
        public List<string>? AvailableNotificationMethods { get; set; }

        /// <summary>
        /// Gets or sets the status of the event's payload.
        /// </summary>
        [JsonPropertyName("payload_status")]
        public string? PayloadStatus { get; set; }

        /// <summary>
        /// Gets or sets the payload data related to the porting event.
        /// </summary>
        [JsonPropertyName("payload")]
        public PortingEventPayload? Payload { get; set; }

        /// <summary>
        /// Gets or sets the record type for the event.
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
    /// Represents the abstract base class for payload data related to a porting event.
    /// </summary>
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "event_type")]
    [JsonDerivedType(typeof(PortingOrderDeletedPayload), "porting_order.deleted")]
    [JsonDerivedType(typeof(PortingOrderMessagingChangedPayload), "porting_order.messaging_changed")]
    [JsonDerivedType(typeof(PortingOrderStatusChangedPayload), "porting_order.status_changed")]
    [JsonDerivedType(typeof(PortingOrderNewCommentPayload), "porting_order.new_comment")]
    [JsonDerivedType(typeof(PortingOrderSplitPayload), "porting_order.split")]
    public abstract class PortingEventPayload { }

    /// <summary>
    /// Represents the payload for a deleted porting order event.
    /// </summary>
    public class PortingOrderDeletedPayload : PortingEventPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the porting order was deleted.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public DateTimeOffset? DeletedAt { get; set; }
    }

    /// <summary>
    /// Represents the payload for a porting order messaging change event.
    /// </summary>
    public class PortingOrderMessagingChangedPayload : PortingEventPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the support key related to the porting order.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>
        /// Gets or sets the messaging status for the porting order.
        /// </summary>
        [JsonPropertyName("messaging")]
        public MessagingStatus? Messaging { get; set; }
    }

    /// <summary>
    /// Represents the messaging status for a porting order.
    /// </summary>
    public class MessagingStatus
    {
        /// <summary>
        /// Gets or sets a value indicating whether the porting order is messaging capable.
        /// </summary>
        [JsonPropertyName("messaging_capable")]
        public bool? MessagingCapable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether messaging is enabled for the porting order.
        /// </summary>
        [JsonPropertyName("enable_messaging")]
        public bool? EnableMessaging { get; set; }

        /// <summary>
        /// Gets or sets the messaging port status.
        /// </summary>
        [JsonPropertyName("messaging_port_status")]
        public string? MessagingPortStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the messaging porting process is completed.
        /// </summary>
        [JsonPropertyName("messaging_port_completed")]
        public bool? MessagingPortCompleted { get; set; }
    }

    /// <summary>
    /// Represents the payload for a porting order status change event.
    /// </summary>
    public class PortingOrderStatusChangedPayload : PortingEventPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting order.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the new status of the porting order.
        /// </summary>
        [JsonPropertyName("status")]
        public PortStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets the support key related to the porting order.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the porting order status was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the webhook URL for the porting order.
        /// </summary>
        [JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }
    }

    /// <summary>
    /// Represents the status of a porting order.
    /// </summary>
    public class PortStatus
    {
        /// <summary>
        /// Gets or sets the details of the porting status.
        /// </summary>
        [JsonPropertyName("details")]
        public PortStatusDetail[]? Details { get; set; }

        /// <summary>
        /// Gets or sets the value representing the status.
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// Represents a single status detail for a porting order.
    /// </summary>
    public class PortStatusDetail
    {
        /// <summary>
        /// Gets or sets the code of the port status detail.
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the port status detail.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    /// <summary>
    /// Represents the payload for a new comment event on a porting order.
    /// </summary>
    public class PortingOrderNewCommentPayload : PortingEventPayload
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting order.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the support key related to the porting order.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>
        /// Gets or sets the comment associated with the porting order.
        /// </summary>
        [JsonPropertyName("comment")]
        public Comment? Comment { get; set; }
    }

    /// <summary>
    /// Represents a comment on a porting order.
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the unique identifier of the comment.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the body of the comment.
        /// </summary>
        [JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Gets or sets the user identifier of the person who made the comment.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the type of user who made the comment (e.g., "system", "customer").
        /// </summary>
        [JsonPropertyName("user_type")]
        public string? UserType { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the comment was inserted.
        /// </summary>
        [JsonPropertyName("inserted_at")]
        public DateTimeOffset? InsertedAt { get; set; }
    }

    /// <summary>
    /// Represents the payload for a split event in a porting order.
    /// </summary>
    public class PortingOrderSplitPayload : PortingEventPayload
    {
        /// <summary>
        /// Gets or sets the "from" porting order number reference.
        /// </summary>
        [JsonPropertyName("from")]
        public PortingOrderNumberReference? From { get; set; }

        /// <summary>
        /// Gets or sets the "to" porting order number reference.
        /// </summary>
        [JsonPropertyName("to")]
        public PortingOrderNumberReference? To { get; set; }

        /// <summary>
        /// Gets or sets the list of porting phone numbers involved in the split.
        /// </summary>
        [JsonPropertyName("porting_phone_numbers")]
        public PortingOrderNumberReference[]? PortingPhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a porting order number reference.
    /// </summary>
    public class PortingOrderNumberReference
    {
        /// <summary>
        /// Gets or sets the unique identifier of the porting number reference.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}