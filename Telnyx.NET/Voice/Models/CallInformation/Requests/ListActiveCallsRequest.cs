using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Voice.Models.CallInformation.Requests
{
    /// <summary>
    /// Represents the request parameters for listing active calls for a given connection in the Telnyx API.
    /// This includes pagination options to limit the number of records and navigate through paginated results.
    /// </summary>
    public class ListActiveCallsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the limit for the number of records to retrieve per page.
        /// Valid values range from 1 to 250. Default value is 20.
        /// </summary>
        [JsonPropertyName("page[limit]")]
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the opaque identifier for the next page of results.
        /// This is used for pagination to retrieve subsequent pages of results.
        /// </summary>
        [JsonPropertyName("page[after]")]
        public string? PageAfter { get; set; }

        /// <summary>
        /// Gets or sets the opaque identifier for the previous page of results.
        /// This is used for pagination to retrieve previous pages of results.
        /// </summary>
        [JsonPropertyName("page[before]")]
        public string? PageBefore { get; set; }
    }
}

