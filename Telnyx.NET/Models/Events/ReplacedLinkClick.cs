using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events
{
    /// <summary>
    /// Represents an event for a replaced link click.
    /// </summary>
    public class ReplacedLinkClick
    {
        /// <summary>
        /// Gets or sets the type of the record.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the URL of the replaced link.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Gets or sets the recipient of the message.
        /// </summary>
        [JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the message.
        /// </summary>
        [JsonPropertyName("message_id")]
        public string? MessageId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the link was clicked.
        /// </summary>
        [JsonPropertyName("time_clicked")]
        public DateTimeOffset TimeClicked { get; set; }
    }
}