using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Identity.Models.NumberLookup.Responses;

/// <summary>
/// Represents the response for a number lookup request, containing details about the phone number.
/// </summary>
public class NumberLookupResponse : TelnyxResponse<NumberLookupDatum>
{
}

/// <summary>
/// Represents detailed information about a phone number returned in a number lookup response.
/// </summary>
public partial class NumberLookupDatum
{
    /// <summary>
    /// The country code associated with the phone number.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    /// <summary>
    /// The national format of the phone number.
    /// </summary>
    [JsonPropertyName("national_format")]
    public string? NationalFormat { get; set; }

    /// <summary>
    /// The phone number in E.164 format.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Information about potential fraud associated with the number.
    /// </summary>
    [JsonPropertyName("fraud")]
    public string? Fraud { get; set; }

    /// <summary>
    /// Carrier details for the phone number.
    /// </summary>
    [JsonPropertyName("carrier")]
    public NumberLookupCarrier? Carrier { get; set; }

    /// <summary>
    /// Caller name details for the phone number.
    /// </summary>
    [JsonPropertyName("caller_name")]
    public NumberLookupCallerName? CallerName { get; set; }

    /// <summary>
    /// Overrides the default NNID associated with the phone number.
    /// </summary>
    [JsonPropertyName("nnid_override")]
    public string? NnidOverride { get; set; }

    /// <summary>
    /// Portability information about the phone number.
    /// </summary>
    [JsonPropertyName("portability")]
    public NumberLookupPortability? Portability { get; set; }

    /// <summary>
    /// Indicates whether the phone number is valid.
    /// </summary>
    [JsonPropertyName("valid_number")]
    public bool? ValidNumber { get; set; }

    /// <summary>
    /// Identifies the type of record returned.
    /// </summary>
    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }
}

/// <summary>
/// Represents the caller name details for a phone number.
/// </summary>
public partial class NumberLookupCallerName
{
    /// <summary>
    /// The caller name associated with the phone number.
    /// </summary>
    [JsonPropertyName("caller_name")]
    public string? CallerNameCallerName { get; set; }

    /// <summary>
    /// The error code, if any, associated with retrieving the caller name.
    /// </summary>
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }
}

/// <summary>
/// Represents the carrier information for a phone number.
/// </summary>
public partial class NumberLookupCarrier
{
    /// <summary>
    /// The mobile country code of the carrier.
    /// </summary>
    [JsonPropertyName("mobile_country_code")]
    public string? MobileCountryCode { get; set; }

    /// <summary>
    /// The mobile network code of the carrier.
    /// </summary>
    [JsonPropertyName("mobile_network_code")]
    public string? MobileNetworkCode { get; set; }

    /// <summary>
    /// The name of the carrier.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The type of carrier (e.g., mobile, landline).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The error code, if any, related to carrier data retrieval.
    /// </summary>
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }
}

/// <summary>
/// Represents portability details for a phone number.
/// </summary>
public partial class NumberLookupPortability
{
    /// <summary>
    /// The Location Routing Number (LRN) of the phone number.
    /// </summary>
    [JsonPropertyName("lrn")]
    public string? Lrn { get; set; }

    /// <summary>
    /// The portability status of the phone number (e.g., ported, not ported).
    /// </summary>
    [JsonPropertyName("ported_status")]
    public string? PortedStatus { get; set; }

    /// <summary>
    /// The date the phone number was ported, if applicable.
    /// </summary>
    [JsonPropertyName("ported_date")]
    public string? PortedDate { get; set; }

    /// <summary>
    /// The Operating Company Number (OCN) for the phone number.
    /// </summary>
    [JsonPropertyName("ocn")]
    public string? Ocn { get; set; }

    /// <summary>
    /// The type of phone line (e.g., mobile, VoIP).
    /// </summary>
    [JsonPropertyName("line_type")]
    public string? LineType { get; set; }

    /// <summary>
    /// The SPID (Service Provider Identifier) of the phone number's carrier.
    /// </summary>
    [JsonPropertyName("spid")]
    public string? Spid { get; set; }

    /// <summary>
    /// The carrier name associated with the SPID.
    /// </summary>
    [JsonPropertyName("spid_carrier_name")]
    public string? SpidCarrierName { get; set; }

    /// <summary>
    /// The carrier type associated with the SPID.
    /// </summary>
    [JsonPropertyName("spid_carrier_type")]
    public string? SpidCarrierType { get; set; }

    /// <summary>
    /// The alternative SPID, if applicable.
    /// </summary>
    [JsonPropertyName("altspid")]
    public string? Altspid { get; set; }

    /// <summary>
    /// The carrier name associated with the alternative SPID.
    /// </summary>
    [JsonPropertyName("altspid_carrier_name")]
    public string? AltspidCarrierName { get; set; }

    /// <summary>
    /// The carrier type associated with the alternative SPID.
    /// </summary>
    [JsonPropertyName("altspid_carrier_type")]
    public string? AltspidCarrierType { get; set; }

    /// <summary>
    /// The city associated with the phone number's carrier.
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// The state associated with the phone number's carrier.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}