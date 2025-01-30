using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list porting events associated with porting orders.
    /// This class supports pagination, filtering by event type, porting order ID, and event creation date range.
    /// </summary>
    public class ListPortingEventsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of porting events to retrieve per page.
        /// This is used for pagination of the results, with a default value of 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the type of event to filter the results by.
        /// This allows filtering events based on the type of action or change that occurred.
        /// </summary>
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the porting order ID to filter events by.
        /// This allows retrieving events related to a specific porting order.
        /// </summary>
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// Gets or sets the start date to filter events by creation date (inclusive).
        /// This allows filtering events that were created after a specific date.
        /// </summary>
        public DateTimeOffset? CreatedAtGte { get; set; }

        /// <summary>
        /// Gets or sets the end date to filter events by creation date (inclusive).
        /// This allows filtering events that were created before a specific date.
        /// </summary>
        public DateTimeOffset? CreatedAtLte { get; set; }
    }
}