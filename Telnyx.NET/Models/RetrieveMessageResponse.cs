using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for a message retrieval request.
    /// </summary>
    public class RetrieveMessageResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data associated with the retrieved message.
        /// </summary>
        [JsonPropertyName("data")]
        public RetrieveMessageData? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the detailed data for a retrieved message.
    /// </summary>
    public class RetrieveMessageData : MessageBaseResponse
    {
        /// <summary>
        /// Gets or sets the list of "cc" (carbon copy) recipients for the message.
        /// Only for Inbound Messages.
        /// </summary>
        [JsonPropertyName("cc")]
        public List<FromTo> Cc { get; set; }
    }
}