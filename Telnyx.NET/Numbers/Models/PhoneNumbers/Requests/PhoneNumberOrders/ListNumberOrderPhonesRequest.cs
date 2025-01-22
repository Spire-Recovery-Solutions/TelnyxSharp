using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to list phone numbers associated with a specific number order.
    /// </summary>
    public class ListNumberOrderPhonesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the country code filter for the phone numbers in the request.
        /// </summary>
        /// <remarks>
        /// This property specifies the country code (e.g., "US" or "GB") to filter the phone numbers
        /// associated with the number order.
        /// </remarks>
        public string? CountryCode { get; set; }
    }
}