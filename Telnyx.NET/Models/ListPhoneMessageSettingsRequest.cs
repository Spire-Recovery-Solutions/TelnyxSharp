using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListPhoneMessageSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The page number to load (default is 1).
        /// </summary>
        

        /// <summary>
        /// The size of the page (default is 20).
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
