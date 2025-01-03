// Base abstract class implementing the non-generic interface

using System.Net;
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public abstract class TelnyxResponse : ITelnyxResponse
{
    [JsonIgnore]
    public bool IsSuccessful { get; set; }
    
    [JsonIgnore]
    public HttpStatusCode StatusCode { get; set; }
    
    [JsonIgnore]
    public string? ErrorMessage { get; set; }
    
    [JsonPropertyName("errors")]
    public TelnyxError[]? Errors { get; set; }
    
    [JsonPropertyName("meta")]
    public PaginationMeta? Meta { get; set; }
}

// Generic abstract class that extends TelnyxResponse and implements the generic interface
public abstract class TelnyxResponse<TData> : TelnyxResponse, ITelnyxResponse<TData>
{
    [JsonPropertyName("data")]
    public TData? Data { get; set; }
}