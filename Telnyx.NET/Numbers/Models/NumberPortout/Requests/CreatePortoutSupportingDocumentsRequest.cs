using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to create supporting documents for a port-out request.
    /// </summary>
    public class CreatePortoutSupportingDocumentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the list of supporting documents to be attached to the port-out request.
        /// Each document must have a type and a corresponding document ID.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<SupportingDocumentDetail>? Documents { get; set; }
    }

    /// <summary>
    /// Represents the details of a supporting document for a port-out request.
    /// </summary>
    public class SupportingDocumentDetail
    {
        /// <summary>
        /// Gets or sets the type of the supporting document (e.g., LOA or invoice).
        /// The type is an enum value that specifies the document's nature.
        /// </summary>
        [JsonPropertyName("type")]
        public SupportingDocumentType Type { get; set; }

        /// <summary>
        /// Gets or sets the document ID associated with the supporting document.
        /// This ID identifies the actual document in the system.
        /// </summary>
        [JsonPropertyName("document_id")]
        public string DocumentId { get; set; } = string.Empty;
    }
}