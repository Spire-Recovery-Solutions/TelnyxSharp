using System.Net;
using Telnyx.NET.Models;

namespace Telnyx.NET.Base
{
    public interface ITelnyxRequest
    {
    }

    // Base interface for all responses
    public interface ITelnyxResponse
    {
        bool IsSuccessful { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string? ErrorMessage { get; set; }
        TelnyxError[]? Errors { get; set; }
        PaginationMeta? Meta { get; set; }
    }

// Generic interface that extends the base interface
    public interface ITelnyxResponse<TData> : ITelnyxResponse
    {
        TData? Data { get; set; }
    }

}