using System.Text.Json.Serialization;

namespace Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

/// <summary>
/// Represents a number order in the Telnyx API.
/// </summary>
public class NumberOrder
{
    /// <summary>
    /// Indicates whether all requirements for the number order have been met.
    /// </summary>
    [JsonPropertyName("requirements_met")]
    public bool? RequirementsMet { get; set; }

    /// <summary>
    /// The ID of the billing group associated with the number order.
    /// </summary>
    [JsonPropertyName("billing_group_id")]
    public string? BillingGroupId { get; set; }

    /// <summary>
    /// The unique identifier of the number order.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The total count of phone numbers included in the number order.
    /// </summary>
    [JsonPropertyName("phone_numbers_count")]
    public int PhoneNumbersCount { get; set; }

    /// <summary>
    /// The current status of the number order (e.g., "pending", "completed").
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The ID of the messaging profile associated with the number order.
    /// </summary>
    [JsonPropertyName("messaging_profile_id")]
    public string? MessagingProfileId { get; set; }

    /// <summary>
    /// The date and time when the number order was last updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>
    /// The connection ID associated with the number order.
    /// </summary>
    [JsonPropertyName("connection_id")]
    public string? ConnectionId { get; set; }

    /// <summary>
    /// The date and time when the number order was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    /// A custom reference string provided by the customer for the number order.
    /// </summary>
    [JsonPropertyName("customer_reference")]
    public string? CustomerReference { get; set; }

    /// <summary>
    /// A list of phone numbers included in the number order.
    /// </summary>
    [JsonPropertyName("phone_numbers")]
    public List<NumberOrdersPhoneNumber> PhoneNumbers { get; set; }

    /// <summary>
    /// The record type of the number order (e.g., "number_order").
    /// </summary>
    [JsonPropertyName("record_type")]
    public string? RecordType { get; set; }
}