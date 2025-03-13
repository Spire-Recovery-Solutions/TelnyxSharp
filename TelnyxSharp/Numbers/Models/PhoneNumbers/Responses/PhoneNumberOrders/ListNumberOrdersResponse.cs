using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Response model for listing number orders.
    /// Contains a list of number orders with associated metadata.
    /// </summary>
    public class ListNumberOrdersResponse : TelnyxResponse<List<NumberOrdersPhoneNumber>>
    {
    }

    /// <summary>
    /// Represents a phone number involved in a number order.
    /// Contains information about the phone number's requirements, status, and regulatory details.
    /// </summary>
    public partial class NumberOrdersPhoneNumber : BaseNumberOrdersData
    {
        
        /// <summary>
        /// Gets or sets the list of phone numbers in the number order.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumbersJobPhoneNumber>? PhoneNumbers { get; set; }
    }

    /// <summary>
    /// Represents a phone number included in a created number order.
    /// Provides fields such as country code, status,
    /// and regulatory requirements.
    /// </summary>
    public partial class PhoneNumbersJobPhoneNumber
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The actual phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }
    }
}