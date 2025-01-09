using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.NumberConfigurations.Requests
{
    public class ListPhoneMessageSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page (default is 20).
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
