using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for creating a messaging hosted number order.
    /// </summary>
    public class CreateHostedNumberOrderResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public CreateHostedNumberOrder? Data { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
    public class CreateHostedNumberOrder : BaseHostedNumberOrderData
    {
    }
}
