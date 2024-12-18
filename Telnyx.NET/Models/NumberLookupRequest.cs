using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class NumberLookupRequest : ITelnyxRequest
{
    public string? PhoneNumber { get; set; }
    public List<NumberLookupType> NumberLookupTypes { get; set; }
}