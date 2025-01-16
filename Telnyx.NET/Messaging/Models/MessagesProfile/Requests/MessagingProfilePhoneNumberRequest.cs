using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.MessagesProfile.Requests
{
    public class MessagingProfilePhoneNumberRequest : ITelnyxRequest
    {
        /// <summary>
        /// The page number to load. Default is 1.
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}
