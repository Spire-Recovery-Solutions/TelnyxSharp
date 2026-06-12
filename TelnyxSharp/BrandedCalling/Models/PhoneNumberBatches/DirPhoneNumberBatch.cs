using System.Text.Json.Serialization;
using TelnyxSharp.Enums;
using TelnyxSharp.BrandedCalling.Models.PhoneNumbers;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumberBatches
{
    /// <summary>
    /// Represents a phone-number batch — all numbers added to a DIR in a single bulk-add request.
    /// Telnyx vets the batch as a unit.
    /// </summary>
    public class DirPhoneNumberBatch
    {
        /// <summary>
        /// Server-assigned unique identifier of the batch.
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// Identifier of the DIR the batch belongs to.
        /// </summary>
        [JsonPropertyName("dir_id")]
        public string? DirId { get; set; }

        /// <summary>
        /// The DIR's display name at the time the batch was read.
        /// </summary>
        [JsonPropertyName("dir_display_name")]
        public string? DirDisplayName { get; set; }

        /// <summary>
        /// Identifier of the enterprise the DIR belongs to.
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Aggregate batch status. Mirrors the values used on individual phone numbers.
        /// </summary>
        [JsonPropertyName("status")]
        public DirPhoneNumberStatus? Status { get; set; }

        /// <summary>
        /// Number of phone numbers in this batch.
        /// </summary>
        [JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the batch was created (and implicitly submitted for vetting).
        /// </summary>
        [JsonPropertyName("submitted_at")]
        public string? SubmittedAt { get; set; }

        /// <summary>
        /// Documents attached to this batch (e.g. a Letter of Authorization).
        /// Empty when none were supplied at add time.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }

        /// <summary>
        /// All phone numbers in this batch, with per-number status.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<DirPhoneNumber>? PhoneNumbers { get; set; }
    }
}
