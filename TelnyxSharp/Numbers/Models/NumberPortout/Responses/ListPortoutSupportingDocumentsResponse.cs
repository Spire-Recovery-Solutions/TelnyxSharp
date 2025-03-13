using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response containing a list of portout supporting documents.
    /// </summary>
    public class ListPortoutSupportingDocumentsResponse : TelnyxResponse<List<PortoutSupportingDocument>>
    {
        // Inherits from TelnyxResponse<List<PortoutSupportingDocument>> to encapsulate the list of supporting documents.
    }

    /// <summary>
    /// Represents an individual portout supporting document.
    /// This object contains details about the supporting document related to the portout request.
    /// </summary>
    public class PortoutSupportingDocument
    {
        /// <summary>
        /// Gets or sets the unique identifier for the supporting document.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the record type of the supporting document.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string RecordType { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the supporting document.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the portout ID associated with this supporting document.
        /// </summary>
        [JsonPropertyName("portout_id")]
        public string PortoutId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the document ID of the supporting document.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp when the supporting document was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the supporting document was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}