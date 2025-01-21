using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Enumeration for sort order.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortOrder
    {
        [JsonPropertyName("purchased_at")]
        PurchasedAt,

        [JsonPropertyName("phone_number")]
        PhoneNumber,

        [JsonPropertyName("connection_name")]
        ConnectionName,

        [JsonPropertyName("usage_payment_method")]
        UsagePaymentMethod
    }
}
