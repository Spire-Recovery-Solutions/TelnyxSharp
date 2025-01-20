using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Identity.Models.NumberLookup.Requests;

/// <summary>
/// Represents a request for performing a number lookup operation in the Telnyx system.
/// </summary>
public class NumberLookupRequest : ITelnyxRequest
{
    /// <summary>
    /// Gets or sets the phone number to be looked up.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the list of lookup types to include in the request.
    /// These types determine the specific data to retrieve about the phone number.
    /// </summary>
    public List<NumberLookupType> NumberLookupTypes { get; set; }
}