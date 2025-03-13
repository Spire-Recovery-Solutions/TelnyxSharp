using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.Voice.Models.Debugging.Requests
{
    /// <summary>
    /// Represents a request for listing call events with various filters and pagination options.
    /// </summary>
    public class ListCallEventsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the leg ID to filter the call events by.
        /// </summary>
        public string? LegId { get; set; }

        /// <summary>
        /// Gets or sets the application session ID to filter the call events by.
        /// </summary>
        public string? ApplicationSessionId { get; set; }

        /// <summary>
        /// Gets or sets the connection ID to filter the call events by.
        /// </summary>
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Gets or sets the product type to filter the call events by.
        /// </summary>
        public ProductType? Product { get; set; }

        /// <summary>
        /// Gets or sets the start date and time to filter the call events by.
        /// </summary>
        public string? From { get; set; }

        /// <summary>
        /// Gets or sets the end date and time to filter the call events by.
        /// </summary>
        public string? To { get; set; }

        /// <summary>
        /// Gets or sets a flag to filter the call events by failed status.
        /// </summary>
        public bool? Failed { get; set; }

        /// <summary>
        /// Gets or sets the event type to filter the call events by.
        /// </summary>
        public EventType? Type { get; set; }

        /// <summary>
        /// Gets or sets the name to filter the call events by.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred after the specified date and time.
        /// </summary>
        public string? OccurredAtGt { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred after or at the specified date and time.
        /// </summary>
        public string? OccurredAtGte { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred before the specified date and time.
        /// </summary>
        public string? OccurredAtLt { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred before or at the specified date and time.
        /// </summary>
        public string? OccurredAtLte { get; set; }

        /// <summary>
        /// Gets or sets the filter for call events that occurred exactly at the specified date and time.
        /// </summary>
        public string? OccurredAtEq { get; set; }

        /// <summary>
        /// Gets or sets the number of call events to retrieve per page (pagination).
        /// Default value is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}