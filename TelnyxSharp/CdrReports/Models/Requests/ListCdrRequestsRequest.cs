using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.CdrReports.Models.Requests
{
    /// <summary>
    /// Represents the request parameters for listing CDR requests.
    /// </summary>
    public class ListCdrRequestsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of results per page.
        /// Possible values: <= 1000. Default value: 100.
        /// </summary>
        [JsonPropertyName("per_page")]
        public int PageSize { get; set; } = 100;
    }
}
