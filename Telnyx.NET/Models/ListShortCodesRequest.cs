using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{

    public class ListShortCodesRequest
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

        /// <summary>
        /// Filter by Messaging Profile ID.
        /// </summary>
        [JsonPropertyName("filter[messaging_profile_id]")]
        public string? MessagingProfileId { get; set; }
    }

}
