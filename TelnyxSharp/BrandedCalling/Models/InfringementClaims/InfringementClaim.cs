using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims
{
    /// <summary>
    /// Represents a trademark/copyright infringement claim filed against a Display Identity Record (DIR).
    /// </summary>
    public class InfringementClaim
    {
        /// <summary>
        /// Server-assigned unique identifier of the claim.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of the DIR the claim is filed against.
        /// </summary>
        [JsonPropertyName("dir_id")]
        public string? DirId { get; set; }

        /// <summary>
        /// Identifier of the enterprise the DIR belongs to.
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Category of infringement being claimed.
        /// </summary>
        [JsonPropertyName("claim_type")]
        public InfringementClaimType? ClaimType { get; set; }

        /// <summary>
        /// Description of the alleged infringement (10-2000 characters).
        /// </summary>
        [JsonPropertyName("claim_description")]
        public string? ClaimDescription { get; set; }

        /// <summary>
        /// Name of the claimant.
        /// </summary>
        [JsonPropertyName("claimant_name")]
        public string? ClaimantName { get; set; }

        /// <summary>
        /// Contact details of the claimant.
        /// </summary>
        [JsonPropertyName("claimant_contact")]
        public string? ClaimantContact { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the claim was filed.
        /// </summary>
        [JsonPropertyName("claim_date")]
        public string? ClaimDate { get; set; }

        /// <summary>
        /// Lifecycle status of the claim.
        /// </summary>
        [JsonPropertyName("status")]
        public InfringementClaimStatus? Status { get; set; }

        /// <summary>
        /// Resolution of the claim. Set only when the status is resolved.
        /// </summary>
        [JsonPropertyName("resolution")]
        public InfringementClaimResolution? Resolution { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the claim was resolved, if applicable.
        /// </summary>
        [JsonPropertyName("resolution_date")]
        public string? ResolutionDate { get; set; }

        /// <summary>
        /// Notes from the Telnyx team about the resolution.
        /// </summary>
        [JsonPropertyName("resolution_notes")]
        public string? ResolutionNotes { get; set; }

        /// <summary>
        /// Contest documents aggregated across all customer contest submissions on this claim.
        /// </summary>
        [JsonPropertyName("contest_documents")]
        public List<DirDocument>? ContestDocuments { get; set; }

        /// <summary>
        /// Per-round submission audit trail. Each entry records one contest submission.
        /// </summary>
        [JsonPropertyName("contest_history")]
        public List<ContestSubmission>? ContestHistory { get; set; }

        /// <summary>
        /// Snapshot of the DIR the claim is filed against, embedded for convenience.
        /// </summary>
        [JsonPropertyName("dir")]
        public InfringementClaimDirRef? Dir { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the claim was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the claim was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents a snapshot of the DIR an infringement claim is filed against.
    /// </summary>
    public class InfringementClaimDirRef
    {
        /// <summary>
        /// Identifier of the DIR.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Display name of the DIR.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Identifier of the enterprise the DIR belongs to.
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Lifecycle status of the DIR.
        /// </summary>
        [JsonPropertyName("status")]
        public DirStatus? Status { get; set; }
    }

    /// <summary>
    /// Represents one round of customer contest evidence on an infringement claim.
    /// </summary>
    public class ContestSubmission
    {
        /// <summary>
        /// The customer's contest notes for this round.
        /// </summary>
        [JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when this round was submitted.
        /// </summary>
        [JsonPropertyName("submitted_at")]
        public string? SubmittedAt { get; set; }

        /// <summary>
        /// Number of documents attached to this submission round.
        /// </summary>
        [JsonPropertyName("document_count")]
        public int? DocumentCount { get; set; }
    }
}
