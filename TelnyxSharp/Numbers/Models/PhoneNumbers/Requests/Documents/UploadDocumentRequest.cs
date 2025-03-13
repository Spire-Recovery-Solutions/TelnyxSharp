using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.Documents
{
    /// <summary>
    /// Represents a request to upload a document to the Telnyx API.
    /// This includes the file data and an optional customer reference for the document.
    /// </summary>
    public class UploadDocumentRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the binary data of the file to be uploaded.
        /// This property holds the document content in byte array format.
        /// </summary>
        public byte[]? File { get; set; }

        /// <summary>
        /// Gets or sets the optional customer reference for the document.
        /// This value can be used to associate the document with a specific customer or reference ID.
        /// </summary>
        public string? CustomerReference { get; set; }
    }
}