using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET.PhoneNumber.Models.Identity.Requests;

public class NumberLookupRequest : ITelnyxRequest
{
    public string? PhoneNumber { get; set; }
    public List<NumberLookupType> NumberLookupTypes { get; set; }
}