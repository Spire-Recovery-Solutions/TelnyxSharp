using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for retrieving a list of porting reports.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> where T is a list of <see cref="PortingReport"/>.
    /// </summary>
    public class ListPortingReportsResponse : TelnyxResponse<List<PortingReport>>
    {
    }

    /// <summary>
    /// Represents a single porting report, which contains metadata about the porting order report.
    /// </summary>
    public class PortingReport
    {
        /// <summary>
        /// Gets or sets the unique identifier for the porting report.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the report (e.g., summary or detailed).
        /// </summary>
        [JsonPropertyName("report_type")]
        public string? ReportType { get; set; }

        /// <summary>
        /// Gets or sets the status of the porting report.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the parameters associated with the porting report, which include filters for the report.
        /// </summary>
        [JsonPropertyName("params")]
        public ReportParams? Params { get; set; }

        /// <summary>
        /// Gets or sets the unique document identifier for the report.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the type of record associated with this report (e.g., phone number or customer).
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp for the report.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update timestamp for the report.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the parameters for the porting report, including filters used for generating the report.
    /// </summary>
    public class ReportParams
    {
        /// <summary>
        /// Gets or sets the filters that can be applied to the report data.
        /// </summary>
        [JsonPropertyName("filters")]
        public ReportFilters Filters { get; set; } = new();
    }

    /// <summary>
    /// Represents the available filters for a porting report, such as status and reference filters.
    /// </summary>
    public class ReportFilters
    {
        /// <summary>
        /// Gets or sets a list of statuses to include in the report (e.g., completed, in progress).
        /// </summary>
        [JsonPropertyName("status__in")]
        public List<string>? StatusIn { get; set; }

        /// <summary>
        /// Gets or sets a list of customer references to filter the report by.
        /// </summary>
        [JsonPropertyName("customer_reference__in")]
        public List<string>? CustomerReferenceIn { get; set; }

        /// <summary>
        /// Gets or sets the filter for the report's creation date, limiting results to records created before a specific time.
        /// </summary>
        [JsonPropertyName("created_at__lt")]
        public DateTimeOffset? CreatedBefore { get; set; }

        /// <summary>
        /// Gets or sets the filter for the report's creation date, limiting results to records created after a specific time.
        /// </summary>
        [JsonPropertyName("created_at__gt")]
        public DateTimeOffset? CreatedAfter { get; set; }
    }
}