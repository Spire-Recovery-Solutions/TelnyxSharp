using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Converters;
using TelnyxSharp.Enums;

namespace TelnyxSharp.DetailRecords.Models.Requests
{
    /// <summary>
    /// Represents a request for searching detail records.
    /// This request supports filtering by record type, date range, and other criteria,
    /// as well as pagination and sorting.
    /// </summary>
    public class DetailRecordSearchRequest : ITelnyxRequest
    {
        /// <summary>
        /// Required. Filters by the given record type.
        /// Example: messaging, conference, etc.
        /// Sent as filter[record_type]=...
        /// </summary>
        [JsonPropertyName("record_type")]
        public DetailRecordType RecordType { get; set; }

        /// <summary>
        /// Optional. Filters by a user-friendly date range.
        /// Example: today, last_month, etc.
        /// Sent as filter[date_range]=...
        /// </summary>
        public string? DateRange { get; set; }

        /// <summary>
        /// Optional. Additional complex filters.
        /// Each filter is applied to build query parameters such as filter[created_at][gte]=2021-06-22.
        /// </summary>
        [JsonPropertyName("filters")]
        public List<FilterCriteria> Filters { get; set; } = new List<FilterCriteria>();

        /// <summary>
        /// Optional. Page number (>= 1). Defaults to 1.
        /// Sent as page[number]=...
        /// </summary>
        [JsonPropertyName("page_number")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Optional. Page size (>= 1 and <= 50). Defaults to 20.
        /// Sent as page[size]=...
        /// </summary>
        [JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 20;

        /// <summary>
        /// Optional. Sorting options.
        /// For example, new List&lt;string&gt; { "-created_at" } will be sent as sort=-created_at.
        /// </summary>
        [JsonPropertyName("sort")]
        public List<string> Sort { get; set; } = new List<string>();
    }

    /// <summary>
    /// Represents a single filter criterion for searching detail records.
    /// </summary>
    public class FilterCriteria
    {
        /// <summary>
        /// The field to filter on (e.g., "created_at", "status").
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// The operator to use, e.g., eq, ne, gt, gte, lt, lte, starts_with, ends_with, or contains.
        /// If null, a simple equality check is assumed.
        /// Uses a custom converter (<see cref="FilterOperatorConverter"/>) to map enum values to their string representation.
        /// </summary>
        public FilterOperator? Operator { get; set; }

        /// <summary>
        /// The value for the filter as a string.
        /// For dates, numbers, or booleans, convert them to the appropriate string format.
        /// </summary>
        public string Value { get; set; }
    }
}
