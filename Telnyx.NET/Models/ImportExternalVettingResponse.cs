using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{

    public class ImportExternalVettingResponse : ITelnyxResponse
    {
        /// <summary>
        /// External vetting provider ID for the brand.
        /// </summary>
        [JsonPropertyName("evpId")]
        public string? EvpId { get; set; }

        /// <summary>
        /// Unique ID identifying a vetting transaction performed by a vetting provider.
        /// </summary>
        [JsonPropertyName("vettingId")]
        public string? VettingId { get; set; }

        /// <summary>
        /// Required token for vetting record confirmation.
        /// </summary>
        [JsonPropertyName("vettingToken")]
        public string? VettingToken { get; set; }

        /// <summary>
        /// Vetting score ranging from 0-100.
        /// </summary>
        [JsonPropertyName("vettingScore")]
        public int VettingScore { get; set; }

        /// <summary>
        /// Vetting classification.
        /// </summary>
        [JsonPropertyName("vettingClass")]
        public string? VettingClass { get; set; }

        /// <summary>
        /// Effective date when vetting was completed.
        /// </summary>
        [JsonPropertyName("vettedDate")]
        public string? VettedDate { get; set; }

        /// <summary>
        /// Date when the vetting request was generated.
        /// </summary>
        [JsonPropertyName("createDate")]
        public string? CreateDate { get; set; }

        /// <summary>
        /// Represents any errors encountered during the retrieval of the auto-response setting.
        /// </summary>
        [JsonPropertyName("detail")]
        public List<ValidationErrorDetail>? Detail { get; set; }
    }
}
