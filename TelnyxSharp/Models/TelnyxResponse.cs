using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Models
{
    /// <summary>
    /// Base abstract class implementing the non-generic ITelnyxResponse interface.
    /// </summary>
    public abstract class TelnyxResponse : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether the request was successful.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the error message, if any.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the errors associated with the response.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Gets or sets the pagination metadata for the response.
        /// </summary>
        [JsonPropertyName("meta")]
        public PaginationMeta? Meta { get; set; }
    }

    /// <summary>
    /// Generic abstract class that extends TelnyxResponse and implements the generic ITelnyxResponse interface.
    /// </summary>
    public abstract class TelnyxResponse<TData> : TelnyxResponse, ITelnyxResponse<TData>
    {
        /// <summary>
        /// Gets or sets the data associated with the response.
        /// </summary>
        [JsonPropertyName("data")]
        public TData? Data { get; set; }
    }
}