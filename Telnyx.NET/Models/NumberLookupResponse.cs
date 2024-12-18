
using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;
public class NumberLookupResponse :ITelnyxResponse
{
    [JsonPropertyName("data")]
    public NumberLookupDatum Data { get; set; }
}

public partial class NumberLookupDatum
{
    [JsonPropertyName("country_code")]
    public string? CountryCode { get; set; }

    [JsonPropertyName("national_format")]
    public string? NationalFormat { get; set; }

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    [JsonPropertyName("fraud")]
    public string? Fraud { get; set; }

    [JsonPropertyName("carrier")]
    public NumberLookupCarrier Carrier { get; set; }

    [JsonPropertyName("caller_name")]
    public NumberLookupCallerName CallerName { get; set; }

    [JsonPropertyName("nnid_override")]
    public string? NnidOverride { get; set; }

    [JsonPropertyName("portability")]
    public NumberLookupPortability Portability { get; set; }

    [JsonPropertyName("valid_number")]
    public bool? ValidNumber { get; set; }

    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }
}

public partial class NumberLookupCallerName
{
    [JsonPropertyName("caller_name")]
    public string? CallerNameCallerName { get; set; }

    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }
}

public partial class NumberLookupCarrier
{
    [JsonPropertyName("mobile_country_code")]
    public string? MobileCountryCode { get; set; }

    [JsonPropertyName("mobile_network_code")]
    public string? MobileNetworkCode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; set; }
}

public partial class NumberLookupPortability
{
    [JsonPropertyName("lrn")]
    public string? Lrn { get; set; }

    [JsonPropertyName("ported_status")]
    public string? PortedStatus { get; set; }

    [JsonPropertyName("ported_date")]
    public string? PortedDate { get; set; }

    [JsonPropertyName("ocn")]
    public string? Ocn { get; set; }

    [JsonPropertyName("line_type")]
    public string? LineType { get; set; }

    [JsonPropertyName("spid")]
    public string? Spid { get; set; }

    [JsonPropertyName("spid_carrier_name")]
    public string? SpidCarrierName { get; set; }

    [JsonPropertyName("spid_carrier_type")]
    public string? SpidCarrierType { get; set; }

    [JsonPropertyName("altspid")]
    public string? Altspid { get; set; }

    [JsonPropertyName("altspid_carrier_name")]
    public string? AltspidCarrierName { get; set; }

    [JsonPropertyName("altspid_carrier_type")]
    public string? AltspidCarrierType { get; set; }

    [JsonPropertyName("city")]
    public string? City { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}