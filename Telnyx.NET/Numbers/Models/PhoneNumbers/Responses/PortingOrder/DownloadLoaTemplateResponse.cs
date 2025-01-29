using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response when downloading a Letter of Authorization (LOA) template.
    /// Inherits from TelnyxResponse and includes the PDF content as a string.
    /// </summary>
    public class DownloadLoaTemplateResponse : TelnyxResponse
    {
        /// <summary>
        /// The content of the LOA template in PDF format, encoded as a string.
        /// </summary>
        public string? PdfContent { get; set; }
    }
}