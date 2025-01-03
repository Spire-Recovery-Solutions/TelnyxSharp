using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response received after sending a message using a number pool.
    /// </summary>
    public class NumberPoolMessageResponse : TelnyxResponse
    {
        /// <summary>
        /// Contains the data about the message sent through the number pool.
        /// </summary>
        [JsonPropertyName("data")]
        public NumberPoolMessageData? Data { get; set; }

        /// <summary>
        /// Contains any errors that occurred during the API request.
        /// This is null if no errors were encountered.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents the detailed information about a message sent through the number pool.
    /// </summary>
    public class NumberPoolMessageData : MessageBaseResponse
    {
    }
}