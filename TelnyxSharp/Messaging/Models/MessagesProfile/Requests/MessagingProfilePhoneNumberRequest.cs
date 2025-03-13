using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Requests
{
    public class MessagingProfilePhoneNumberRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}
