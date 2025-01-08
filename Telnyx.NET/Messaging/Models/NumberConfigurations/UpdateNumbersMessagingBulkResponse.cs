using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.NumberConfigurations
{
    public class UpdateNumbersMessagingBulkResponse : TelnyxResponse<UpdateNumbersMessagingBulk>
    {
    }

    public class UpdateNumbersMessagingBulk
    {
        /// <summary>
        /// The type of the resource.
        /// </summary>
        [JsonPropertyName("record_type")]
        public MessageRecordType RecordType { get; set; } = MessageRecordType.Unknown;

        /// <summary>
        /// The order ID to verify the bulk update status.
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// List of phone numbers that were successfully updated.
        /// </summary>
        [JsonPropertyName("success")]
        public List<string> Success { get; set; } = new();

        /// <summary>
        /// List of phone numbers pending to be updated.
        /// </summary>
        [JsonPropertyName("pending")]
        public List<string> Pending { get; set; } = new();

        /// <summary>
        /// List of phone numbers that failed to update.
        /// </summary>
        [JsonPropertyName("failed")]
        public List<string> Failed { get; set; } = new();
    }
}
