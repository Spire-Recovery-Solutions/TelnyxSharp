using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create a new porting order.
    /// </summary>
    public class CreatePortingOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// A list of phone numbers to be included in the porting order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public required List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// A customer-provided reference identifier for the porting order.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }
}