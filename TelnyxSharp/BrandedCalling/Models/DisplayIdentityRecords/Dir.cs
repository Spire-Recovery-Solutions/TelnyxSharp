using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords
{
    /// <summary>
    /// Represents a Display Identity Record (DIR) — the brand identity (display name, logo,
    /// call reasons) shown to call recipients via Branded Calling.
    /// </summary>
    public class Dir
    {
        /// <summary>
        /// Server-assigned unique identifier of the DIR.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identifier of the enterprise this DIR belongs to.
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Name shown to call recipients.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// True if the organization places calls on behalf of other enterprises (BPO/reseller).
        /// </summary>
        [JsonPropertyName("reselling")]
        public bool? Reselling { get; set; }

        /// <summary>
        /// Certification that the DIR information is accurate.
        /// </summary>
        [JsonPropertyName("certify_brand_is_accurate")]
        public bool? CertifyBrandIsAccurate { get; set; }

        /// <summary>
        /// Certification that this DIR is not used for SHAFT content where prohibited.
        /// </summary>
        [JsonPropertyName("certify_no_shaft_content")]
        public bool? CertifyNoShaftContent { get; set; }

        /// <summary>
        /// Certification of ownership of any logos/trademarks shown.
        /// </summary>
        [JsonPropertyName("certify_ip_ownership")]
        public bool? CertifyIpOwnership { get; set; }

        /// <summary>
        /// Name of the person at the enterprise who authorized this DIR registration.
        /// </summary>
        [JsonPropertyName("authorizer_name")]
        public string? AuthorizerName { get; set; }

        /// <summary>
        /// Contact email of the authorizer.
        /// </summary>
        [JsonPropertyName("authorizer_email")]
        public string? AuthorizerEmail { get; set; }

        /// <summary>
        /// Publicly accessible HTTPS URL to a 256x256 BMP logo.
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Reasons the business calls customers.
        /// </summary>
        [JsonPropertyName("call_reasons")]
        public List<CallReason>? CallReasons { get; set; }

        /// <summary>
        /// Supporting documents attached to this DIR.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }

        /// <summary>
        /// DIR lifecycle status.
        /// </summary>
        [JsonPropertyName("status")]
        public DirStatus? Status { get; set; }

        /// <summary>
        /// Populated when the status is rejected; cleared on submit or successful approval.
        /// </summary>
        [JsonPropertyName("rejection_reasons")]
        public List<RejectionReason>? RejectionReasons { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR was rejected, if applicable.
        /// </summary>
        [JsonPropertyName("rejected_at")]
        public string? RejectedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR was submitted for vetting, if applicable.
        /// </summary>
        [JsonPropertyName("submitted_at")]
        public string? SubmittedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR was verified, if applicable.
        /// </summary>
        [JsonPropertyName("verified_at")]
        public string? VerifiedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the DIR's verification expires, if applicable.
        /// </summary>
        [JsonPropertyName("expiring_at")]
        public string? ExpiringAt { get; set; }
    }

    /// <summary>
    /// Represents a call reason attached to a DIR.
    /// </summary>
    public class CallReason
    {
        /// <summary>
        /// The call reason text (max 64 characters).
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the call reason was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }
    }
}
