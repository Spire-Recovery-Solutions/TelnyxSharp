using System.Text.Json.Serialization;

namespace TelnyxSharp.BrandedCalling.Models
{
    /// <summary>
    /// Represents a rejection reason attached to a rejected DIR or phone number in the Branded Calling API.
    /// </summary>
    public class RejectionReason
    {
        /// <summary>
        /// Stable rejection-reason code (e.g. "documentation_incomplete").
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Short human-readable title of the rejection reason.
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Detailed explanation of the rejection reason.
        /// </summary>
        [JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Customer-visible free-text comment from the Telnyx vetting team.
        /// Only the first rejection reason carries this; the rest are null.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
