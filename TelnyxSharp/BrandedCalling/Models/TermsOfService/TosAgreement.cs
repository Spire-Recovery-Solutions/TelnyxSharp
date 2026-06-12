using System.Text.Json.Serialization;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.TermsOfService
{
    /// <summary>
    /// Represents a recorded user agreement to a product's Terms of Service.
    /// </summary>
    public class TosAgreement
    {
        /// <summary>
        /// Server-assigned unique identifier of the agreement.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Version of the terms that was agreed to (e.g. "v1.0.0").
        /// </summary>
        [JsonPropertyName("terms_version")]
        public string? TermsVersion { get; set; }

        /// <summary>
        /// Convenience alias of <see cref="TermsVersion"/>. Both keys are present on every response.
        /// </summary>
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Telnyx product the Terms of Service apply to.
        /// </summary>
        [JsonPropertyName("product_type")]
        public TosProductType? ProductType { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the user agreed.
        /// </summary>
        [JsonPropertyName("agreed_at")]
        public string? AgreedAt { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the agreement record was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }
    }
}
