using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models
{
    public class MessagingProfileMetricsRequest : ITelnyxRequest
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

        /// <summary>
        /// The ID of the messaging profile(s) to retrieve.
        /// </summary>
        [JsonPropertyName("id")]
        public string MessagingProfileId { get; set; } = string.Empty;

        /// <summary>
        /// The timeframe for which you'd like to retrieve metrics.
        /// Possible values: [1h, 3h, 24h, 3d, 7d, 30d]. Default is 24h.
        /// </summary>
        [JsonPropertyName("time_frame")]
        public string TimeFrame { get; set; } = "24h";
    }
}
