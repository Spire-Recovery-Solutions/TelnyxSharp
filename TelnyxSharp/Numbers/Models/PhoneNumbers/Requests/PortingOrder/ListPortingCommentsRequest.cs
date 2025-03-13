using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list comments associated with porting orders.
    /// This class supports pagination by specifying the number of results per page.
    /// </summary>
    public class ListPortingCommentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of comments to retrieve per page.
        /// This is used for pagination of the results.
        /// </summary>
        public int PageSize { get; set; }
    }
}