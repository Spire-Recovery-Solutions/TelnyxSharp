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
}
