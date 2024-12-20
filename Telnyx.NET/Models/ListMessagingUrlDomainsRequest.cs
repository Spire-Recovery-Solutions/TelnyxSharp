using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListMessagingUrlDomainsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The page number to load. Default is 1.
        /// </summary>
        [JsonPropertyName("page[number]")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int PageSize { get; set; } = 20;
    }
}
