using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for previewing a Letter of Authorization (LOA) configuration.
    /// Inherits from <see cref="TelnyxResponse"/> which is the base class for all response models.
    /// </summary>
    public class PreviewLoaConfigurationResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the PDF content for the Letter of Authorization (LOA) preview.
        /// This content is typically encoded in base64 format.
        /// </summary>
        public string? Pdf { get; set; }
    }
}