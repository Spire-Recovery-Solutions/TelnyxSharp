using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response model for retrieving a hosted number order.
    /// </summary>
    public class RetrieveHostedNumberOrderResponse : TelnyxResponse
    {

        /// <summary>
        /// Contains the data associated with the sent message.
        /// </summary>
        [JsonPropertyName("data")]
        public RetrieveHostedNumberOrderData? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    public class RetrieveHostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
}