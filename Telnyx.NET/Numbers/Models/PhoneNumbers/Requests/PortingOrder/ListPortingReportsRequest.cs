using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list porting reports associated with porting orders.
    /// This class allows filtering by report type, status, and pagination.
    /// </summary>
    public class ListPortingReportsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of porting reports to retrieve per page.
        /// This property is used for pagination and defaults to 20 reports per page.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the type of report to generate.
        /// The default value is "export_porting_orders_csv", but this can be adjusted to request different report types.
        /// </summary>
        public string? ReportType { get; set; } = "export_porting_orders_csv";

        /// <summary>
        /// Gets or sets the status of the porting report.
        /// This property filters the reports based on their current status, such as 'completed', 'pending', or 'failed'.
        /// </summary>
        public JobStatusType? Status { get; set; }
    }
}