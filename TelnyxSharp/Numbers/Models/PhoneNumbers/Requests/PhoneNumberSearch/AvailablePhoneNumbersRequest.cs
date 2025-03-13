using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;

/// <summary>
/// Represents a request to search for available phone numbers from Telnyx API.
/// </summary>
public class AvailablePhoneNumbersRequest : ITelnyxRequest
{
    /// <summary>
    /// Gets or sets the starting digits of the desired phone number.
    /// </summary>
    public string? StartsWith { get; set; }

    /// <summary>
    /// Gets or sets the ending digits of the desired phone number.
    /// </summary>
    public string? EndsWith { get; set; }

    /// <summary>
    /// Gets or sets a substring that the phone number should contain.
    /// </summary>
    public string? Contains { get; set; }

    /// <summary>
    /// Gets or sets the locality for the phone number search.
    /// </summary>
    public string? Locality { get; set; }

    /// <summary>
    /// Gets or sets the administrative area for the phone number search.
    /// </summary>
    public string? AdministrativeArea { get; set; }

    /// <summary>
    /// Gets or sets the country code for the phone number search.
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the national destination code (NDC).
    /// </summary>
    public int? NationalDestinationCode { get; set; }

    /// <summary>
    /// Gets or sets the rate center for the phone number search.
    /// </summary>
    public string? RateCenter { get; set; }

    /// <summary>
    /// Gets or sets the type of phone number.
    /// </summary>
    public string? PhoneNumberType { get; set; }

    /// <summary>
    /// Gets or sets the desired features for the phone number.
    /// </summary>
    public List<PhoneNumberFeature>? Features { get; set; }

    /// <summary>
    /// Gets or sets the limit for the number of results returned.
    /// Default value is 10.
    /// </summary>
    public int Limit { get; set; } = 10;

    /// <summary>
    /// Indicates whether the search should include only quickship numbers.
    /// </summary>
    public bool? Quickship { get; set; }

    /// <summary>
    /// Indicates whether the search should use best effort.
    /// </summary>
    public bool? BestEffort { get; set; }

    /// <summary>
    /// Indicates whether the phone numbers should be reservable.
    /// </summary>
    public bool? Reservable { get; set; }

    /// <summary>
    /// Indicates whether held numbers should be excluded from the search.
    /// </summary>
    public bool? ExcludeHeldNumbers { get; set; }
    //
    //public int? PageSize { get; set; }
}