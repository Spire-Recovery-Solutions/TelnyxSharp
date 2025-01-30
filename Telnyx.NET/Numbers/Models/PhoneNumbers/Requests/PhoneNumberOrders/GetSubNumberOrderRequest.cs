using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders
{
    /// <summary>
    /// Represents a request to retrieve a sub-number order with optional filters.
    /// </summary>
    public class GetSubNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether to include phone numbers in the response.
        /// </summary>
        /// <remarks>
        /// If <c>true</c>, the response will include detailed information about the phone numbers associated with the sub-number order.
        /// If <c>false</c> or <c>null</c>, phone number details will not be included.
        /// </remarks>
        public bool? IncludePhoneNumbers { get; set; }
    }
}