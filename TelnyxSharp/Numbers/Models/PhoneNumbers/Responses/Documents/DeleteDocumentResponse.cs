using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.Documents
{
    /// <summary>
    /// Represents the response returned when deleting a document associated with a phone number.
    /// Inherits from TelnyxResponse to encapsulate the document data.
    /// </summary>
    public class DeleteDocumentResponse : TelnyxResponse<Document>
    {
    }
}