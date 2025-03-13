using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to generate a porting report.
    /// </summary>
    public class CreatePortingReportRequest : ITelnyxRequest
    {
        /// <summary>
        /// The type of report to be generated. Defaults to "export_porting_orders_csv".
        /// </summary>
        [JsonPropertyName("report_type")]
        public required string ReportType { get; set; } = "export_porting_orders_csv";

        /// <summary>
        /// The parameters required for generating the report.
        /// </summary>
        [JsonPropertyName("params")]
        public required ReportParams Params { get; set; }
    }
}