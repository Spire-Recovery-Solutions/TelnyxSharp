using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for previewing a Letter of Authorization (LOA) configuration.
    /// Inherits from <see cref="TelnyxResponse"/> which is the base class for all response models.
    /// </summary>
    public class PreviewLoaConfigurationParamResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the PDF file content for the Letter of Authorization (LOA) preview.
        /// </summary>
        public string? Pdf { get; set; }
    }
}