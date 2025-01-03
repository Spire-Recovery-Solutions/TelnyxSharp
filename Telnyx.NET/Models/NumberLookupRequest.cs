using Telnyx.NET.Interfaces;
using Telnyx.NET.Models.Events;

namespace Telnyx.NET.Models;

public class NumberLookupRequest : ITelnyxRequest
{
    public string? PhoneNumber { get; set; }
    public List<NumberLookupType> NumberLookupTypes { get; set; }
}