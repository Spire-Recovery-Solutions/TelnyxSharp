using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Models;

namespace TelnyxSharp.V1Operations.Models.Responses
{
    /// <summary>
    /// Represents the response for listing CDR requests.
    /// Contains an array of CDR request data.
    /// </summary>
    /// <summary>
    /// Response model for listing CDR requests.
    /// </summary>
    public class ListCdrRequestsResponse : List<CdrRequestData>, ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets whether the response was successful.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the error message (if any) returned by the API.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets any errors returned by the Telnyx API.
        /// </summary>
        [JsonIgnore]
        public TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Gets or sets pagination metadata for responses that support pagination.
        /// </summary>
        [JsonIgnore]
        public PaginationMeta? Meta { get; set; }
    }
}
