using System.Text.Json.Serialization;
using Telnyx.NET.Models;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.BulkPhoneNumberOperations
{
    /// <summary>
    /// Represents the response for listing the jobs related to bulk phone number operations.
    /// </summary>
    public class ListNumbersJobsResponse : TelnyxResponse<List<NumbersJobsData>>
    {
    }

    /// <summary>
    /// Represents detailed information about a specific job for bulk phone number operations.
    /// </summary>
    public class NumbersJobsData
    {
        /// <summary>
        /// Unique identifier for the job.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of record for this job.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The current status of the job.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The type of operation performed by this job.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The estimated completion time for the job.
        /// </summary>
        [JsonPropertyName("etc")]
        public DateTimeOffset? Etc { get; set; }

        /// <summary>
        /// The creation time of the job.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The last time the job was updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// A list of phone numbers associated with the job.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PhoneNumbersJobPhoneNumber>? PhoneNumbers { get; set; }

        /// <summary>
        /// A list of phone numbers that were successfully processed by the job.
        /// </summary>
        [JsonPropertyName("successful_operations")]
        public List<PhoneNumbersJobPhoneNumber>? SuccessfulOperations { get; set; }

        /// <summary>
        /// A list of phone numbers that are still pending in the job.
        /// </summary>
        [JsonPropertyName("pending_operations")]
        public List<PhoneNumbersJobPhoneNumber>? PendingOperations { get; set; }

        /// <summary>
        /// A list of phone numbers that failed during the job operation.
        /// </summary>
        [JsonPropertyName("failed_operations")]
        public List<PhoneNumbersFailedJobNumber>? FailedOperations { get; set; }
    }

    /// <summary>
    /// Represents a phone number included in a failed job operation.
    /// Provides information such as the phone number, its identifier, and any errors associated with the failure.
    /// </summary>
    public partial class PhoneNumbersFailedJobNumber
    {
        /// <summary>
        /// Unique identifier for the phone number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The actual phone number in E.164 format.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the errors associated with the response.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }
}