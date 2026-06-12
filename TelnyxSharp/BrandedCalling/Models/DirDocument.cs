using System.Text.Json.Serialization;

namespace TelnyxSharp.BrandedCalling.Models
{
    /// <summary>
    /// Represents a supporting document attached to a Branded Calling resource
    /// (DIR, phone-number batch, or infringement-claim contest).
    /// </summary>
    public class DirDocument
    {
        /// <summary>
        /// Id returned by the Telnyx Documents API after the file was uploaded (via POST /v2/documents).
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Type of supporting document (e.g. "letter_of_authorization", "business_registration").
        /// The reference list of supported short names is available via the document types endpoint.
        /// </summary>
        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// Optional free-text description of the document (max 255 characters).
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
