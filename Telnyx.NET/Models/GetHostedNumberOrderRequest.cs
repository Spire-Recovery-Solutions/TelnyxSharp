using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class GetHostedNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// The page number to load. Default value is 1.
        /// </summary>
        [JsonPropertyName("page[number]")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// The size of the page. Default value is 20. Must be between 1 and 250.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int PageSize { get; set; } = 20;
    }
}
