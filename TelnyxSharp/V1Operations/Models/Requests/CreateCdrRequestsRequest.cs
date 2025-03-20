using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.V1Operations.Models.Requests
{
    /// <summary>
    /// Represents a request to create a CDR (Call Detail Record) report.
    /// </summary>
    public class CreateCdrRequestsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the start time of the report (UTC).
        /// Example: "2025-02-20T00:00:00+00:00"
        /// </summary>
        [JsonPropertyName("start_time")]
        public required string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the report (UTC). Must be less than 24 hours from now.
        /// Example: "2025-02-20T06:41:26+00:00"
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the call types for the report.
        /// Inbound = 1, Outbound = 2.
        /// </summary>
        [JsonPropertyName("call_types")]
        public List<int> CallTypes { get; set; }

        /// <summary>
        /// Gets or sets the record types for the report.
        /// Complete = 1, Incomplete = 2, Errors = 3.
        /// </summary>
        [JsonPropertyName("record_types")]
        public List<int> RecordTypes { get; set; }

        /// <summary>
        /// Gets or sets the list of connection IDs.
        /// </summary>
        [JsonPropertyName("connections")]
        public List<string> Connections { get; set; }

        /// <summary>
        /// Gets or sets the name of the report.
        /// </summary>
        [JsonPropertyName("report_name")]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or sets the source of the CDR. Can be either "calls" or "call-control".
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the list of filters as strings.
        /// Example: "filter[status]=delivered" or "filter[created_at][gte]=2021-06-22"
        /// </summary>
        /// <summary>
        /// List of filter criteria
        /// </summary>
        [JsonPropertyName("filters")]
        public List<CdrFilter>? Filters { get; set; }
    }

    public class CdrFilter
    {
        /// <summary>
        /// Filter type, either 'and' or 'or'
        /// </summary>
        [JsonPropertyName("filter_type")]
        public string FilterType { get; set; } = null!;

        /// <summary>
        /// CLI (Caller Line Identification) value
        /// </summary>
        [JsonPropertyName("cli")]
        public string? Cli { get; set; }

        /// <summary>
        /// CLI filter type: contains, starts_with, or ends_with
        /// </summary>
        [JsonPropertyName("cli_filter")]
        public string? CliFilter { get; set; }

        /// <summary>
        /// CLD (Called Line Directory) value
        /// </summary>
        [JsonPropertyName("cld")]
        public string? Cld { get; set; }

        /// <summary>
        /// CLD filter type: contains, starts_with, or ends_with
        /// </summary>
        [JsonPropertyName("cld_filter")]
        public string? CldFilter { get; set; }

        /// <summary>
        /// List of tag strings
        /// </summary>
        [JsonPropertyName("tags_list")]
        public List<string>? TagsList { get; set; }
    }
}
