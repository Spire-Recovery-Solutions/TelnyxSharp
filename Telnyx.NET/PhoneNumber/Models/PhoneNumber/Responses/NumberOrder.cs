

using System.Text.Json.Serialization;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

public class NumberOrder
{
    [JsonPropertyName("requirements_met")]
    public bool? RequirementsMet { get; set; }

    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("phone_numbers_count")]
    public int PhoneNumbersCount { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("messaging_profile_id")]
    public string? MessagingProfileId { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    [JsonPropertyName("phone_numbers")]
    public List<NumberOrdersPhoneNumber> PhoneNumbers { get; set; }

    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }
}