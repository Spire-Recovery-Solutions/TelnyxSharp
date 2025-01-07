using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Models
{
    public class ImportExternalVettingRequest : ITelnyxRequest
    {
        /// <summary>
        /// External vetting provider ID for the brand.
        /// </summary>
        [JsonPropertyName("evpId")]
        public required string EvpId { get; set; }

        /// <summary>
        /// Unique ID that identifies a vetting transaction performed by a vetting provider.
        /// </summary>
        [JsonPropertyName("vettingId")]
        public required string VettingId { get; set; }

        /// <summary>
        /// Required by some providers for vetting record confirmation.
        /// </summary>
        [JsonPropertyName("vettingToken")]
        public string? VettingToken { get; set; }
    }
}
