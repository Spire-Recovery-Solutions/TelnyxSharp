using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to retrieve a porting order.
    /// This class is used to fetch details of a specific porting order, with an option to include phone numbers.
    /// </summary>
    public class RetrievePortingOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether to include associated phone numbers in the response.
        /// If true, the response will include phone numbers; otherwise, phone numbers will be excluded.
        /// </summary>
        public bool? IncludePhoneNumbers { get; set; } 
    }
}