using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to create additional documents for a porting order.
    /// </summary>
    public class CreateAdditionalDocumentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// A list of additional documents associated with the porting order.
        /// </summary>
        [JsonPropertyName("additional_documents")]
        public List<AdditionalDocumentRequest>? AdditionalDocuments { get; set; }
    }

    /// <summary>
    /// Represents an additional document associated with a porting order.
    /// </summary>
    public class AdditionalDocumentRequest
    {
        /// <summary>
        /// Specifies the type of the document.
        /// </summary>
        [JsonPropertyName("document_type")]
        public string? DocumentType { get; set; }

        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }
    }
}