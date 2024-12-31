//using System.Text.Json.Serialization;
//using Telnyx.NET.Enums;

//namespace Telnyx.NET.Models.Events
//{
//    public class DeliveryUpdateMessage : TelnyxEvent
//    {
//        [JsonPropertyName("data")]
//        public new DeliveryUpdateMessageData Data { get; set; }
//    }

//    public class DeliveryUpdateMessageData : BaseEvent
//    {
//        [JsonPropertyName("payload")]
//        public new DeliveryUpdateMessagePayload Payload { get; set; }
//    }

//    public class DeliveryUpdateMessagePayload : MessageBaseResponse
//    {
//        /// <summary>
//        /// Gets or sets the payload containing delivery update details.
//        /// </summary>
//        [JsonPropertyName("payload")]
//        public DeliveryUpdateMessagePayload Payload { get; set; }
//    }


//    /// <summary>
//    /// Represents the payload of a delivery update.
//    /// </summary>
//    public class DeliveryUpdateMessage : MessageBaseResponse
//    {
//        /// <summary>
//        /// Initializes a new instance of the <see cref="DeliveryUpdateMessagePayload"/> class
//        /// with default values for direction and record type.
//        /// </summary>
//        public DeliveryUpdateMessagePayload()
//        {
//            Direction = MessageDirection.Outbound;
//            RecordType = MessageRecordType.Message;
//        }
//    }
//}