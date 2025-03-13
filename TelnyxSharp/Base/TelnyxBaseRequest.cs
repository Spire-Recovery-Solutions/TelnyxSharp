using System.Net;
using TelnyxSharp.Models;

namespace TelnyxSharp.Base
{
    /// <summary>
    /// Represents a request to the Telnyx API.
    /// This can be extended by specific request types.
    /// </summary>
    public interface ITelnyxRequest
    {
        // Add specific properties or methods for requests as needed.
    }

    /// <summary>
    /// Base interface for all Telnyx API responses.
    /// Contains basic status, error information, and pagination metadata.
    /// </summary>
    public interface ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets whether the response was successful.
        /// </summary>
        bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// </summary>
        HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the error message (if any) returned by the API.
        /// </summary>
        string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets any errors returned by the Telnyx API.
        /// </summary>
        TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Gets or sets pagination metadata for responses that support pagination.
        /// </summary>
        PaginationMeta? Meta { get; set; }
    }

    /// <summary>
    /// A generic extension of the base response interface for handling responses with data.
    /// This is used when the response includes specific data along with status and metadata.
    /// </summary>
    /// <typeparam name="TData">The type of data contained in the response.</typeparam>
    public interface ITelnyxResponse<TData> : ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets the data returned by the Telnyx API.
        /// </summary>
        TData? Data { get; set; }
    }
}