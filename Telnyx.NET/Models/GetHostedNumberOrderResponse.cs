using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving hosted number orders.
    /// </summary>
    public class GetHostedNumberOrderResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of hosted number order data.
        /// </summary>
        /// <remarks>
        /// Contains the details of the hosted number orders retrieved by the request.
        /// </remarks>
        [JsonPropertyName("data")]
        public List<HostedNumberOrderData>? Data { get; set; }

        /// <summary>
        /// Gets or sets the metadata related to the hosted number order response.
        /// </summary>
        /// <remarks>
        /// Includes information such as pagination details and other relevant metadata.
        /// </remarks>
        [JsonPropertyName("meta")]
        public PaginationMeta? Meta { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    public class HostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
    
}
