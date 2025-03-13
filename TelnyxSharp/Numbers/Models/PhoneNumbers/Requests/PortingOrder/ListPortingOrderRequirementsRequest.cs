using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list requirements associated with porting orders.
    /// This class supports pagination, allowing users to retrieve a specific number of requirements per page.
    /// </summary>
    public class ListPortingOrderRequirementsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of porting order requirements to retrieve per page.
        /// This property is used for pagination of the results, with a default value of 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}