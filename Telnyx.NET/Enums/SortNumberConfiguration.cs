using System.Text.Json.Serialization;

namespace Telnyx.NET.Enums
{
    /// <summary>
    /// Specifies the fields by which number configurations can be sorted in Telnyx API requests.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortNumberConfiguration
    {
        /// <summary>
        /// Sorts number configurations by the date and time they were purchased.
        /// </summary>
        [JsonPropertyName("purchased_at")]
        PurchasedAt,

        /// <summary>
        /// Sorts number configurations by the phone number in ascending or descending order.
        /// </summary>
        [JsonPropertyName("phone_number")]
        PhoneNumber,

        /// <summary>
        /// Sorts number configurations by the name of the associated connection.
        /// </summary>
        [JsonPropertyName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sorts number configurations by the payment method used for usage charges.
        /// </summary>
        [JsonPropertyName("usage_payment_method")]
        UsagePaymentMethod
    }
}