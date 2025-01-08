using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.SharedCampaign.Requests
{
    public class ListSharedCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The number of records to return per page.
        /// </summary>
        [JsonPropertyName("recordsPerPage")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the results. Defaults to sorting by created date in descending order.
        /// </summary>
        [JsonPropertyName("sort")]
        public Sort Sort { get; set; } = Sort.CreatedAtDesc;
    }
}
