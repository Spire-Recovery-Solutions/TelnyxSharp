using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Documents
{
    /// <summary>
    /// Represents the response returned when listing documents associated with phone numbers.
    /// Inherits from TelnyxResponse to encapsulate the list of documents.
    /// </summary>
    public class ListDocumentsResponse : TelnyxResponse<List<Document>>
    {
    }

    /// <summary>
    /// Represents a document associated with a phone number in the Telnyx system.
    /// Contains metadata about the document such as timestamps, content type, status, and more.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Gets or sets the unique identifier for the document.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the document.
        /// </summary>
        [JsonPropertyName("record_type")]
        public bool? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp of the document.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last update timestamp of the document.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets the content type of the document.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Gets or sets the size of the document.
        /// </summary>
        [JsonPropertyName("size")]
        public DocumentSize? Size { get; set; }

        /// <summary>
        /// Gets or sets the status of the document (e.g., 'active', 'inactive').
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the SHA-256 hash of the document.
        /// </summary>
        [JsonPropertyName("sha256")]
        public string? Sha256 { get; set; }

        /// <summary>
        /// Gets or sets the filename of the document.
        /// </summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Gets or sets a customer reference associated with the document.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }

    /// <summary>
    /// Represents the size of a document, including its unit and amount.
    /// </summary>
    public class DocumentSize
    {
        /// <summary>
        /// Gets or sets the unit of measurement for the document size (e.g., 'KB', 'MB').
        /// </summary>
        [JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Gets or sets the amount of the document size in the specified unit.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
    }
}
