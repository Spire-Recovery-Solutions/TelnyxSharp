using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.ReferenceData.Responses
{
    /// <summary>
    /// Represents the response for validating candidate call reasons against the pre-vetted library.
    /// </summary>
    public class ValidateCallReasonsResponse : TelnyxResponse<ValidateCallReasonsData>
    {
    }

    /// <summary>
    /// Represents the result of a call-reason validation.
    /// </summary>
    public class ValidateCallReasonsData
    {
        /// <summary>
        /// True when every supplied reason matches a pre-vetted entry in the call-reason library.
        /// </summary>
        [JsonPropertyName("all_pre_approved")]
        public bool AllPreApproved { get; set; }

        /// <summary>
        /// Subset of the input that does not match the pre-vetted library. A DIR can still be
        /// submitted with these — they will go through manual review.
        /// </summary>
        [JsonPropertyName("non_approved_reasons")]
        public List<string>? NonApprovedReasons { get; set; }

        /// <summary>
        /// True when at least one supplied reason is not pre-approved.
        /// </summary>
        [JsonPropertyName("requires_manual_vetting")]
        public bool RequiresManualVetting { get; set; }
    }
}
