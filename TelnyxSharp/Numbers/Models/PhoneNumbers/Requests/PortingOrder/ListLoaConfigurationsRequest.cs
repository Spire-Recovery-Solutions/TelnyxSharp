using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list LOA (Letter of Authorization) configurations for porting orders.
    /// It allows for pagination by specifying the page size for the results.
    /// </summary>
    public class ListLoaConfigurationsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of LOA configurations to retrieve per page.
        /// Used for pagination, with a default value of 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}