using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to list port-out reports.
    /// This request allows filtering port-out reports by page number, size, report type, and status.
    /// </summary>
    public class ListPortoutReportsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of reports per page for pagination.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the report type to filter by.
        /// This can be the type of report, such as a CSV export.
        /// </summary>
        public string? ReportType { get; set; }

        /// <summary>
        /// Gets or sets the status of the port-out reports to filter by.
        /// </summary>
        public PortoutStatus? Status { get; set; }
    }
}
