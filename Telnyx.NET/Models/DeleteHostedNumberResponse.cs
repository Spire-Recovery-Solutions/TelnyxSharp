using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response after deleting a messaging hosted number.
    /// </summary>
    public class DeleteHostedNumberResponse : TelnyxResponse
    {
        [JsonPropertyName("data")]
        public DeleteHostedNumberData? Data { get; set; }

        /// <summary>
        /// Gets or sets any errors that occurred during the API request.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    public class DeleteHostedNumberData : BaseHostedNumberOrderData
    {
    }
}
