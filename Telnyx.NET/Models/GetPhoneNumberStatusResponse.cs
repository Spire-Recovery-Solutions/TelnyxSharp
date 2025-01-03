using System.Text.Json.Serialization;

namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the response for retrieving the status of phone number assignments.
    /// </summary>
    public class GetPhoneNumberStatusResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of phone number status records.
        /// </summary>
        [JsonPropertyName("records")]
        public List<PhoneNumberStatusRecord>? Records { get; set; }

        /// <summary>
        /// Gets or sets the list of errors, if any, that occurred during the API call.
        /// </summary>
        [JsonPropertyName("errors")]
        public TelnyxError[]? Errors { get; set; }
    }

    /// <summary>
    /// Represents a record detailing the status of a phone number assignment.
    /// </summary>
    public class PhoneNumberStatusRecord
    {
        /// <summary>
        /// Gets or sets the task ID associated with the phone number assignment.
        /// </summary>
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the phone number associated with the record.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the status of the phone number assignment.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;
    }
}