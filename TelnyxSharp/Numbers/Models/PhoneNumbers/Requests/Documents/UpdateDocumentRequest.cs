using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.Documents
{
    /// <summary>
    /// Represents a request to update a document's details in the Telnyx API.
    /// Allows updating specific fields such as the filename and customer reference.
    /// </summary>
    public class UpdateDocumentRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the new filename for the document.
        /// This updates the document's name to the specified value.
        /// </summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Gets or sets the customer reference for the document.
        /// Updates the customer reference associated with the document.
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string? CustomerReference { get; set; }
    }
}