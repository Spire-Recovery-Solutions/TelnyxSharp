using System.Text.Json.Serialization;

namespace TelnyxSharp.BrandedCalling.Models.ReferenceData
{
    /// <summary>
    /// Represents a pre-vetted call-reason library entry.
    /// </summary>
    public class CallReasonReference
    {
        /// <summary>
        /// Server-assigned unique identifier of the library entry.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The pre-vetted call-reason text (e.g. "Account Alert").
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Description of the call reason.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
