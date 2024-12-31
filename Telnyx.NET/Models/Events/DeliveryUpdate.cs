using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents a delivery update event.
    /// </summary>
    public class DeliveryUpdate  : TelnyxEvent
    {
        /// <summary>
        /// Gets or sets the data associated with the delivery update event.
        /// </summary>
        [JsonPropertyName("data")]
        public DeliveryUpdateData Data { get; set; }
    }

    /// <summary>
    /// Represents the data details of a delivery update event.
    /// </summary>
    public class DeliveryUpdateData : BaseEvent
    {

        /// <summary>
        /// Gets or sets the payload containing delivery update details.
        /// </summary>
        [JsonPropertyName("payload")]
        public DeliveryUpdatePayload Payload { get; set; }

        /// <summary>
        /// Gets or sets the metadata associated with the webhook.
        /// </summary>
        [JsonPropertyName("meta")]
        public WebhookMeta Meta { get; set; }
    }

    /// <summary>
    /// Represents the payload of a delivery update.
    /// </summary>
    public class DeliveryUpdatePayload : MessageBaseResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryUpdatePayload"/> class
        /// with default values for direction and record type.
        /// </summary>
        public DeliveryUpdatePayload()
        {
            Direction = MessageDirection.Outbound;
            RecordType = MessageRecordType.Message;
        }
    }

    /// <summary>
    /// Represents metadata associated with the webhook for a delivery update.
    /// </summary>
    public class WebhookMeta
    {
        /// <summary>
        /// Gets or sets the attempt count of the webhook delivery.
        /// </summary>
        [JsonPropertyName("attempt")]
        public int Attempt { get; set; }

        /// <summary>
        /// Gets or sets the recipient address where the delivery was attempted.
        /// </summary>
        [JsonPropertyName("delivered_to")]
        public string? DeliveredTo { get; set; }
    }
}
