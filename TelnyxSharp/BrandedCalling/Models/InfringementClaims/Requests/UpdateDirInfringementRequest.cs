using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests
{
    /// <summary>
    /// Represents a request to update a DIR in response to an infringement concern,
    /// re-certifying the brand information and explaining how the concern was addressed.
    /// </summary>
    public class UpdateDirInfringementRequest : ITelnyxRequest
    {
        /// <summary>
        /// Certification that the DIR does not infringe. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_no_infringement")]
        public bool CertifyNoInfringement { get; set; }

        /// <summary>
        /// Certification that the DIR information is accurate. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_brand_is_accurate")]
        public bool CertifyBrandIsAccurate { get; set; }

        /// <summary>
        /// Certification that this DIR is not used for SHAFT content where prohibited.
        /// Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_no_shaft_content")]
        public bool CertifyNoShaftContent { get; set; }

        /// <summary>
        /// Certification of ownership of any logos/trademarks shown. Must be true. Required.
        /// </summary>
        [JsonPropertyName("certify_ip_ownership")]
        public bool CertifyIpOwnership { get; set; }

        /// <summary>
        /// Explanation of how the infringement concern was addressed (10-500 characters). Required.
        /// </summary>
        [JsonPropertyName("infringement_resolution_notes")]
        public string? InfringementResolutionNotes { get; set; }

        /// <summary>
        /// Updated name shown to call recipients (1-35 characters).
        /// </summary>
        [JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Updated publicly accessible HTTPS URL (max 128 chars) to a 256x256 BMP logo (max 1 MB).
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// Updated reasons the business calls customers (1-10).
        /// </summary>
        [JsonPropertyName("call_reasons")]
        public List<string>? CallReasons { get; set; }

        /// <summary>
        /// Append-only supporting documents (max 20).
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }
    }
}
