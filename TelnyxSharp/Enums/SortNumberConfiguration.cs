using System.Text.Json.Serialization;

namespace TelnyxSharp.Enums
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
        [JsonStringEnumMemberName("purchased_at")]
        PurchasedAt,

        /// <summary>
        /// Sorts number configurations by the phone number in ascending or descending order.
        /// </summary>
        [JsonStringEnumMemberName("phone_number")]
        PhoneNumber,

        /// <summary>
        /// Sorts number configurations by the name of the associated connection.
        /// </summary>
        [JsonStringEnumMemberName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sorts number configurations by the payment method used for usage charges.
        /// </summary>
        [JsonStringEnumMemberName("usage_payment_method")]
        UsagePaymentMethod
    }
}