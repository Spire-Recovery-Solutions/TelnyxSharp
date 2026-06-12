using TelnyxSharp.Models;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses
{
    /// <summary>
    /// Represents the response for rendering a DIR Letter of Authorization (LOA).
    /// The API returns the rendered PDF as a binary body, exposed via <see cref="Content"/>.
    /// </summary>
    public class RenderDirLoaResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the rendered LOA PDF bytes. Null when the request failed.
        /// </summary>
        public byte[]? Content { get; set; }
    }
}
