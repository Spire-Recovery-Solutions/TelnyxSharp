using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to download the LOA (Letter of Authorization) template
    /// associated with a specific LOA configuration ID for phone number porting.
    /// </summary>
    public class DownloadLoaTemplateRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the LOA Configuration ID that uniquely identifies
        /// the LOA configuration for the template download.
        /// </summary>
        public string? LoaConfigurationId { get; set; }
    }
}