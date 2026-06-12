using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests
{
    /// <summary>
    /// Represents a request to create a Display Identity Record (DIR) under an enterprise.
    /// </summary>
    public class CreateDirRequest : ITelnyxRequest
    {
        /// <summary>
        /// Name shown to call recipients (1-35 characters, no emoji, not whitespace-only). Required.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Set to true if the organization places calls on behalf of other enterprises (BPO/reseller).
        /// </summary>
        [JsonPropertyName("reselling")]
        public bool? Reselling { get; set; }

        /// <summary>
        /// Certification that the DIR information is accurate. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_brand_is_accurate")]
        public bool CertifyBrandIsAccurate { get; set; }

        /// <summary>
        /// Certification that this DIR is not used for SHAFT content (Sex, Hate, Alcohol, Firearms,
        /// Tobacco) where prohibited. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_no_shaft_content")]
        public bool CertifyNoShaftContent { get; set; }

        /// <summary>
        /// Certification of ownership of any logos/trademarks shown. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_ip_ownership")]
        public bool CertifyIpOwnership { get; set; }

        /// <summary>
        /// Name of the person at the enterprise authorizing this DIR registration.
        /// Must be a real individual. Required.
        /// </summary>
        [JsonPropertyName("authorizer_name")]
        public string? AuthorizerName { get; set; }

        /// <summary>
        /// Contact email of the authorizer. Telnyx may send verification or infringement-notice
        /// email here; use a monitored mailbox. Required.
        /// </summary>
        [JsonPropertyName("authorizer_email")]
        public string? AuthorizerEmail { get; set; }

        /// <summary>
        /// Publicly accessible HTTPS URL (max 128 chars) to a 256x256 BMP logo (max 1 MB).
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 1-10 reasons the business calls customers (each max 64 characters).
        /// Validate phrasing against the call-reason validation endpoint.
        /// </summary>
        [JsonPropertyName("call_reasons")]
        public List<string>? CallReasons { get; set; }

        /// <summary>
        /// Supporting documents (max 20). Each document id may appear at most once on a DIR.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }
    }
}
