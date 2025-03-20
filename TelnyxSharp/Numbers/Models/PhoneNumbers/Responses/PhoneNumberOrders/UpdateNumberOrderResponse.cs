using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response for updating a phone number order.
    /// </summary>
    public class UpdateNumberOrderResponse : TelnyxResponse<UpdateNumberOrderData>
    {
    }

    public class UpdateNumberOrderData : BaseNumberOrdersData
    {

        /// <summary>
        /// Gets or sets the list of phone numbers in the number order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumberOrderData>? PhoneNumbers { get; set; }
    }
}
