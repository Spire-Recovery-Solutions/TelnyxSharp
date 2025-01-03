using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response returned after sending a message via the Telnyx API.
    /// </summary>
    public partial class SendMessageResponse : TelnyxResponse
    {
        /// <summary>
        /// Contains the data associated with the sent message.
        /// </summary>
        [JsonPropertyName("data")]
        public SendMessageData Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Contains detailed information about a sent message.
    /// </summary>
    public partial class SendMessageData : MessageBaseResponse
    {
    }

    
}
