using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response returned when retrieving a list of port-out reports.
    /// This response contains a list of port-out reports with details like the report type, status, and creation times.
    /// </summary>
    public class ListPortoutReportsResponse : TelnyxResponse<List<PortoutReport>>
    {
    }

    /// <summary>
    /// Represents a single port-out report, providing details such as report ID, type, status, parameters, and document ID.
    /// </summary>
    public class PortoutReport
    {
        /// <summary>
        /// Gets or sets the unique identifier of the report.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the report (e.g., "export").
        /// </summary>
        [JsonPropertyName("report_type")]
        public string? ReportType { get; set; }

        /// <summary>
        /// Gets or sets the current status of the report.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the parameters associated with the report, which may include filters for exported data.
        /// </summary>
        [JsonPropertyName("params")]
        public ExportPortoutsCSVReport? Params { get; set; }

        /// <summary>
        /// Gets or sets the document ID for the report, typically representing a file to download.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the record type for this report.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the report was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the report was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents the parameters for exporting port-out reports in CSV format.
    /// Contains filters used to filter the data in the exported report.
    /// </summary>
    public class ExportPortoutsCSVReport
    {
        /// <summary>
        /// Gets or sets the filters applied to the export.
        /// </summary>
        [JsonPropertyName("filters")]
        public ExportFilters Filters { get; set; } = new();
    }

    /// <summary>
    /// Represents the filters for exporting port-out reports.
    /// These filters allow narrowing down the exported data based on status, customer reference, phone numbers, and creation dates.
    /// </summary>
    public class ExportFilters
    {
        /// <summary>
        /// Gets or sets the list of statuses to include in the report.
        /// </summary>
        [JsonPropertyName("status__in")]
        public List<string>? StatusIn { get; set; }

        /// <summary>
        /// Gets or sets the list of customer references to include in the report.
        /// </summary>
        [JsonPropertyName("customer_reference__in")]
        public List<string>? CustomerReferenceIn { get; set; }

        /// <summary>
        /// Gets or sets the end user's name to filter the report by.
        /// </summary>
        [JsonPropertyName("end_user_name")]
        public string? EndUserName { get; set; }

        /// <summary>
        /// Gets or sets the list of phone numbers to check for overlap in the report.
        /// </summary>
        [JsonPropertyName("phone_numbers__overlaps")]
        public List<string>? PhoneNumbersOverlaps { get; set; }

        /// <summary>
        /// Gets or sets the date to filter reports created before this date.
        /// </summary>
        [JsonPropertyName("created_at__lt")]
        public DateTimeOffset? CreatedAtBefore { get; set; }

        /// <summary>
        /// Gets or sets the date to filter reports created after this date.
        /// </summary>
        [JsonPropertyName("created_at__gt")]
        public DateTimeOffset? CreatedAtAfter { get; set; }

        /// <summary>
        /// Gets or sets the document ID to filter the report by.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }
    }
}