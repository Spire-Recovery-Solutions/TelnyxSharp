using System.Text.Json.Serialization;
using TelnyxSharp.Converters;

namespace TelnyxSharp.Enums
{
    /// <summary>
    /// Specifies the fields by which number configurations can be sorted in Telnyx API requests.
    /// </summary>
    [JsonConverter(typeof(SortNumberConfigurationConverter))]
    public enum SortNumberConfiguration
    {
        /// <summary>
        /// Sorts number configurations by the date and time they were purchased.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("purchased_at")]
        PurchasedAt,

        /// <summary>
        /// Sorts number configurations by the phone number in ascending or descending order.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("phone_number")]
        PhoneNumber,

        /// <summary>
        /// Sorts number configurations by the name of the associated connection.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("connection_name")]
        ConnectionName,

        /// <summary>
        /// Sorts number configurations by the payment method used for usage charges.
        /// </summary>
        //NET9UNCOMMENT [JsonStringEnumMemberName("usage_payment_method")]
        UsagePaymentMethod
    }
}