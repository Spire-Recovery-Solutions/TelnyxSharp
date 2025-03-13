using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.NumberConfigurations.Requests
{
    public class ListPhoneMessageSettingsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page (default is 20).
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}
