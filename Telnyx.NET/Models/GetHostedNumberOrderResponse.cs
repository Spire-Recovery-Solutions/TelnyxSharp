using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving hosted number orders.
    /// </summary>
    public class GetHostedNumberOrderResponse : ITelnyxResponse
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
        public HostedNumberOrderMeta? Meta { get; set; }

        /// <summary>
        /// Represents any errors encountered during the message sending process.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    public class HostedNumberOrderData : BaseHostedNumberOrderData
    {
    }

    public class HostedNumberOrderMeta
    {
        /// <summary>
        /// The total number of pages.
        /// </summary>
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// The total number of results.
        /// </summary>
        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        /// <summary>
        /// The current page number.
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; }

        /// <summary>
        /// The size of the page.
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; }
    }
}
