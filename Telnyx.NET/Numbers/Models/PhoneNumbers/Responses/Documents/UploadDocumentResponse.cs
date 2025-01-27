using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Documents
{
    /// <summary>
    /// Represents the response returned when uploading a document associated with a phone number.
    /// Inherits from TelnyxResponse to encapsulate the uploaded document data.
    /// </summary>
    public class UploadDocumentResponse : TelnyxResponse<Document>
    {
    }
}
