using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class OrderExternalVettingRequest : ITelnyxRequest
    {
        /// <summary>
        /// External vetting provider ID for the brand.
        /// </summary>
        [JsonPropertyName("evpId")]
        public required string EvpId { get; set; }

        /// <summary>
        /// Identifies the vetting classification.
        /// </summary>
        [JsonPropertyName("vettingClass")]
        public required string VettingClass { get; set; }
    }
}
