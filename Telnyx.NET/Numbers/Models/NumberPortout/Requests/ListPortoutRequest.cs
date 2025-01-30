using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to list port-out operations.
    /// This request can be used to filter port-out operations based on several parameters such as carrier name, status, phone number, and date ranges.
    /// </summary>
    public class ListPortoutRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the name of the carrier for filtering the port-out requests.
        /// </summary>
        public string? CarrierName { get; set; }

        /// <summary>
        /// Gets or sets the SPID (Service Provider Identifier) for filtering the port-out requests.
        /// </summary>
        public string? Spid { get; set; }

        /// <summary>
        /// Gets or sets the status of the port-out requests to filter by.
        /// </summary>
        public PortoutStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a list of statuses to filter port-out requests. 
        /// This is an alternative to the Status property to allow multiple status values.
        /// </summary>
        public List<PortoutStatus>? StatusList { get; set; }

        /// <summary>
        /// Gets or sets the date after which port-out requests should have been ported.
        /// </summary>
        public DateTimeOffset? PortedOutAfter { get; set; }

        /// <summary>
        /// Gets or sets the date before which port-out requests should have been ported.
        /// </summary>
        public DateTimeOffset? PortedOutBefore { get; set; }

        /// <summary>
        /// Gets or sets the date after which the port-out requests should have been inserted.
        /// </summary>
        public DateTimeOffset? InsertedAfter { get; set; }

        /// <summary>
        /// Gets or sets the date before which the port-out requests should have been inserted.
        /// </summary>
        public DateTimeOffset? InsertedBefore { get; set; }

        /// <summary>
        /// Gets or sets the FOC (Firm Order Commitment) date for filtering port-out requests.
        /// </summary>
        public DateTimeOffset? FocDate { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the port-out requests to filter by.
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the support key for filtering port-out requests.
        /// </summary>
        public string? SupportKey { get; set; }

        /// <summary>
        /// Gets or sets the number of port-out requests per page (pagination). Default is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}