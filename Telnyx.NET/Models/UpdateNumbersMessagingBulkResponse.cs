using System.Text.Json.Serialization;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Models
{
    public class UpdateNumbersMessagingBulkResponse : TelnyxResponse
    {
        /// <summary>
        /// Represents the response after updating the messaging profile for multiple phone numbers.
        /// </summary>
        [JsonPropertyName("data")]
        public UpdateNumbersMessagingBulk? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the process of updating phone messaging settings.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
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
