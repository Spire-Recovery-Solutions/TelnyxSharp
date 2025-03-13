using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.NumberPortout.Responses;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to create a port-out report.
    /// The report type and associated parameters must be specified.
    /// </summary>
    public class CreatePortoutReportRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the type of the report to be created.
        /// This could be a CSV export or another report type as defined by the Telnyx API.
        /// </summary>
        [JsonPropertyName("report_type")]
        public string ReportType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the parameters for generating the port-out report.
        /// This includes filter criteria for the report, such as status or customer reference.
        /// </summary>
        [JsonPropertyName("params")]
        public ExportPortoutsCSVReport Params { get; set; } = new();
    }
}