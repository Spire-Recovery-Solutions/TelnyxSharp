using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.PhoneNumbers
{
    /// <summary>
    /// Represents a phone number attached to a Display Identity Record (DIR) for Branded Calling.
    /// </summary>
    public class DirPhoneNumber
    {
        /// <summary>
        /// Server-assigned unique identifier of the DIR phone-number association.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of the DIR the phone number is attached to.
        /// </summary>
        [JsonPropertyName("dir_id")]
        public string? DirId { get; set; }

        /// <summary>
        /// Identifier of the enterprise the DIR belongs to.
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Phone number in E.164 format with leading "+".
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Identifier of the batch this number was vetted as part of.
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// Identifier of the Letter of Authorization document attached to this number's batch.
        /// </summary>
        [JsonPropertyName("loa_document_id")]
        public string? LoaDocumentId { get; set; }

        /// <summary>
        /// Phone-number lifecycle status.
        /// </summary>
        [JsonPropertyName("status")]
        public DirPhoneNumberStatus? Status { get; set; }

        /// <summary>
        /// Populated when the status is unsuccessful or permanently rejected.
        /// </summary>
        [JsonPropertyName("rejection_reason")]
        public RejectionReason? RejectionReason { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the association was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the association was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the number was verified, if applicable.
        /// </summary>
        [JsonPropertyName("verified_at")]
        public string? VerifiedAt { get; set; }
    }
}
