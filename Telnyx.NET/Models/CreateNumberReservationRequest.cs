using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models;

public class CreateNumberReservationRequest : ITelnyxRequest
{
    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }
        
    [JsonPropertyName("phone_numbers")]
    public List<CreateNumberReservationPhoneNumber> PhoneNumbers { get; set; }
}

public class CreateNumberReservationPhoneNumber
{
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }
}