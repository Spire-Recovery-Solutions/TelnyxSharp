using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.InfringementClaims.Requests
{
    /// <summary>
    /// Represents a request to contest an infringement claim with supporting evidence.
    /// </summary>
    public class ContestInfringementClaimRequest : ITelnyxRequest
    {
        /// <summary>
        /// The customer's response to the claim (10-2000 characters). Required.
        /// </summary>
        [JsonPropertyName("contest_notes")]
        public string? ContestNotes { get; set; }

        /// <summary>
        /// Up to 20 supporting documents per submission. Document ids must be unique within
        /// this submission; documents are aggregated into the claim's contest documents across
        /// all submissions.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<DirDocument>? Documents { get; set; }
    }
}
