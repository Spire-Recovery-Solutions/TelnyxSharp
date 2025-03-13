using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Voice.Models.QueueCommands.Requests
{
    /// <summary>
    /// Represents a request to retrieve calls from a specific queue in the Telnyx Voice API.
    /// This request can be customized to specify the page size for paginated results.
    /// </summary>
    public class RetrieveCallsQueueRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the page size for the results. This specifies how many calls per page to retrieve.
        /// Default value is 20 if not specified.
        /// </summary>
        [JsonPropertyName("page[size]")]
        public int? PageSize { get; set; } = 20;
    }
}