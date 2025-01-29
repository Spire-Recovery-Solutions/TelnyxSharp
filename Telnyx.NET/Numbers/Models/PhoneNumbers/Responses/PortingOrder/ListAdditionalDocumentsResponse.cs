using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response when retrieving a list of additional documents for a porting order.
    /// Inherits from TelnyxResponse and includes AdditionalDocument data.
    /// </summary>
    public class ListAdditionalDocumentsResponse : TelnyxResponse<AdditionalDocument>
    {
    }

    /// <summary>
    /// Represents an additional document in the porting process.
    /// </summary>
    public class AdditionalDocument
    {
        /// <summary>
        /// The unique identifier for the document.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of the document.
        /// </summary>
        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// The ID associated with the document.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// The name of the file containing the document.
        /// </summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The content type (MIME type) of the document.
        /// </summary>
        [JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The ID of the porting order associated with the document.
        /// </summary>
        [JsonPropertyName("porting_order_id")]
        public string? PortingOrderId { get; set; }

        /// <summary>
        /// The record type of the document.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// The timestamp when the document was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the document was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}