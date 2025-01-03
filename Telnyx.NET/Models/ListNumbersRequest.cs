using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class ListNumbersRequest : ITelnyxRequest
{
    
    public int? PageSize { get; set; }
    public List<string> Tags { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Status { get; set; }
    public string? ConnectionId { get; set; }
    public string? VoiceConnectionNameContains { get; set; }
    public string? VoiceConnectionNameStartsWith { get; set; }
    public string? VoiceConnectionNameEndsWith { get; set; }
    public string? VoiceConnectionNameEquals { get; set; }
    public string? UsagePaymentMethod { get; set; }
    public string? BillingGroupId { get; set; }
    public string? EmergencyAddressId { get; set; }
    public string? CustomerReference { get; set; }
    public string? Sort { get; set; }

}