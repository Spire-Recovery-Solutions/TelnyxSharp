using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{

    public partial class GetNumberOrderResponse : TelnyxResponse<GetNumberOrderData>
    {
    }

    /// <summary>
    /// Contains detailed information about a created number order.
    /// Provides various fields such as the phone numbers count,
    /// creation date, order status, and more.
    /// </summary>
    public class GetNumberOrderData : BaseNumberOrdersData
    {
        /// <summary>
        /// Gets or sets the list of phone numbers in the number order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumberOrderData>? PhoneNumbers { get; set; }

    }
}
