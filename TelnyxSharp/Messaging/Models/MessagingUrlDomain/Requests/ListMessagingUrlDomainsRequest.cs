using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagingUrlDomain.Requests
{
    public class ListMessagingUrlDomainsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}