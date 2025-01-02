using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class AvailablePhoneNumbersRequest : ITelnyxRequest
{
    public string? StartsWith { get; set; }

    public string? EndsWith { get; set; }

    public string? Contains { get; set; }

    public string? Locality { get; set; }

    public string? AdministrativeArea { get; set; }

    public string? CountryCode { get; set; }

    public int? NationalDestinationCode { get; set; }

    public string? RateCenter { get; set; }

    public string? PhoneNumberType { get; set; }

    public string? Features { get; set; }
    public int Limit { get; set; } = 10;
    public bool?  Quickship { get; set; }
    public bool?  BestEffort { get; set; }
    public bool?  Reservable { get; set; }
    public bool?  ExcludeHeldNumbers { get; set; }
    //
    //public int? PageSize { get; set; }
}