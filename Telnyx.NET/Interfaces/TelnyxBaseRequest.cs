using System.Net;

namespace Telnyx.NET.Interfaces
{
    public interface ITelnyxRequest
    {
    }

    public interface ITelnyxResponse
    {
        bool IsSuccessful { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string? ErrorMessage { get; set; }
    }
}