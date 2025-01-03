using System.Net;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public abstract class TelnyxResponse : ITelnyxResponse
{
    public bool IsSuccessful { get; set; }

    public HttpStatusCode StatusCode { get; set; } 
    public string? ErrorMessage { get; set; }
}