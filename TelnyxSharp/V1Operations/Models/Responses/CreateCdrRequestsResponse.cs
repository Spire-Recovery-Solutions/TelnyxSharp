using System.Net;
using System.Text.Json.Serialization;
using TelnyxSharp.Base;
using TelnyxSharp.Enums;
using TelnyxSharp.Models;
using TelnyxSharp.V1Operations.Models.Requests;

namespace TelnyxSharp.V1Operations.Models.Responses
{
    /// <summary>
    /// Represents the response returned after creating a CDR request.
    /// </summary>
    public class CreateCdrRequestsResponse : CdrRequestData, ITelnyxResponse
    {
        /// <summary>
        /// Gets or sets whether the response was successful.
        /// </summary>
        [JsonIgnore]
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status code of the response.
        /// </summary>
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the error message (if any) returned by the API.
        /// </summary>
        [JsonIgnore]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets any errors returned by the Telnyx API.
        /// </summary>
        [JsonIgnore]
        public TelnyxError[]? Errors { get; set; }

        /// <summary>
        /// Gets or sets pagination metadata for responses that support pagination.
        /// </summary>
        [JsonIgnore]
        public PaginationMeta? Meta { get; set; }
    }


    /// <summary>
    /// Represents a CDR (Call Detail Record) request item.
    /// </summary>
    public class CdrRequestData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the CDR request.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the start time for the CDR request in UTC format.
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the end time for the CDR request in UTC format.
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the call types. Inbound = 1, Outbound = 2.
        /// </summary>
        [JsonPropertyName("call_types")]
        public List<CallType> CallTypes { get; set; } = new List<CallType>();

        /// <summary>
        /// Gets or sets the record types. Complete = 1, Incomplete = 2, Errors = 3.
        /// </summary>
        [JsonPropertyName("record_types")]
        public List<RecordType> RecordTypes { get; set; } = new List<RecordType>();

        /// <summary>
        /// Gets or sets the connection IDs.
        /// </summary>
        [JsonPropertyName("connections")]
        public List<long> Connections { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets the report name.
        /// </summary>
        [JsonPropertyName("report_name")]
        public string ReportName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status. Pending = 1, Complete = 2, Failed = 3, Expired = 4.
        /// </summary>
        [JsonPropertyName("status")]
        public CdrRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the URL to download the report.
        /// </summary>
        [JsonPropertyName("report_url")]
        public string ReportUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the search criteria filters.
        /// </summary>
        [JsonPropertyName("filters")]
        public List<CdrFilter> Filters { get; set; } = new List<CdrFilter>();

        /// <summary>
        /// Gets or sets the creation timestamp.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last update timestamp.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; } = string.Empty;
    }
        
}
