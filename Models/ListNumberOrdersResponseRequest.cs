using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class ListNumberOrdersRequest : NumberOrdersRequest, ITelnyxRequest
{
    public string?  Status { get; set; }
    public string?  CreatedAfter { get; set; }
    public string?  CreatedBefore { get; set; }
    public int? PhoneNumberCount { get; set; }
    public string?  CustomerReference { get; set; }
    public bool?  RequirementsMet { get; set; }
    public int? PageNumber { get; set; } = 1;
    public int? PageSize { get; set; }
}