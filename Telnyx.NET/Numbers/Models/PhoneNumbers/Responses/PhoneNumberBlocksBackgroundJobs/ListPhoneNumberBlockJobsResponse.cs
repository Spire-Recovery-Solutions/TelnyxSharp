using System.Text.Json.Serialization;
using Telnyx.NET.Enums;
using Telnyx.NET.Models;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.BulkPhoneNumberOperations;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberBlocksBackgroundJobs
{
    /// <summary>
    /// Represents the response containing a list of phone number block jobs.
    /// </summary>
    public class ListPhoneNumberBlockJobsResponse : TelnyxResponse<List<PhoneNumberBlockJobData>>
    {
    }

    /// <summary>
    /// Represents data for a single phone number block job.
    /// </summary>
    public class PhoneNumberBlockJobData
    {
        /// <summary>
        /// Gets or sets the unique identifier of the phone number block job.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type of the phone number block job.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the current status of the phone number block job.
        /// </summary>
        [JsonPropertyName("status")]
        public JobStatusType? Status { get; set; } = JobStatusType.Pending;

        /// <summary>
        /// Gets or sets the type of job (e.g., delete, reserve).
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or sets the estimated time of completion for the job.
        /// </summary>
        [JsonPropertyName("etc")]
        public DateTimeOffset? EstimatedTimeOfCompletion { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the phone number block job.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated timestamp of the phone number block job.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the list of successful operations performed in the job.
        /// </summary>
        [JsonPropertyName("successful_operations")]
        public List<PhoneNumbersJobPhoneNumber>? SuccessfulOperations { get; set; }

        /// <summary>
        /// Gets or sets the list of failed operations performed in the job.
        /// </summary>
        [JsonPropertyName("failed_operations")]
        public List<PhoneNumbersFailedJobNumber>? FailedOperations { get; set; }
    }
}