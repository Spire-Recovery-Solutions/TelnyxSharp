using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Documents
{
    /// <summary>
    /// Represents the response returned when listing document links associated with phone numbers.
    /// Inherits from TelnyxResponse to encapsulate the list of document links.
    /// </summary>
    public class ListDocumentLinksResponse : TelnyxResponse<List<DocumentLink>>
    {
    }

    /// <summary>
    /// Represents a link to a document in the Telnyx system.
    /// Contains details about the link, including timestamps and the associated document.
    /// </summary>
    public class DocumentLink
    {
        /// <summary>
        /// Gets or sets the unique identifier for the document link.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the document link.
        /// </summary>
        [JsonPropertyName("record_type")]
        public bool? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the document link.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update timestamp of the document link.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the document associated with the link.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the type of the record linked to the document.
        /// </summary>
        [JsonPropertyName("linked_record_type")]
        public string? LinkedRecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the resource linked to the document.
        /// </summary>
        [JsonPropertyName("linked_resource_id")]
        public string? LinkedResourceId { get; set; }
    }
}
