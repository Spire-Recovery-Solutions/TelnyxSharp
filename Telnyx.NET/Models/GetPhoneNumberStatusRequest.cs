using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class GetPhoneNumberStatusRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? RecordsPerPage { get; set; }

        /// <summary>
        /// The page number to retrieve.
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }
    }
}
