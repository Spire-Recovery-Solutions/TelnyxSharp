using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.Brands.Requests
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
