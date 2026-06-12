using System.Text.Json.Serialization;

namespace TelnyxSharp.BrandedCalling.Models.ReferenceData
{
    /// <summary>
    /// Represents a supported document type for Branded Calling supporting documents.
    /// </summary>
    public class DirDocumentTypeReference
    {
        /// <summary>
        /// Stable identifier passed as the document type when attaching a document
        /// (e.g. "letter_of_authorization").
        /// </summary>
        [JsonPropertyName("short_name")]
        public string? ShortName { get; set; }

        /// <summary>
        /// Description of the document type.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
