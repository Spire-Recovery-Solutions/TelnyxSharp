using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to list port-out events.
    /// This request can be filtered by various parameters such as event type, port-out ID, and creation date.
    /// </summary>
    public class ListPortoutEventsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the size of the page for pagination. 
        /// This determines the number of events to return per page.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the type of event to filter the list of port-out events by.
        /// Possible values include event types like "portout.status_changed", "portout.new_comment", etc.
        /// </summary>
        public string? EventType { get; set; }

        /// <summary>
        /// Gets or sets the port-out ID to filter the events by a specific port-out request.
        /// Only events associated with this port-out ID will be returned.
        /// </summary>
        public string? PortoutId { get; set; }

        /// <summary>
        /// Gets or sets the starting date-time filter for the creation date of the events.
        /// Only events created on or after this date will be returned.
        /// </summary>
        public DateTimeOffset? CreatedAtFrom { get; set; }

        /// <summary>
        /// Gets or sets the ending date-time filter for the creation date of the events.
        /// Only events created on or before this date will be returned.
        /// </summary>
        public DateTimeOffset? CreatedAtTo { get; set; }
    }
}