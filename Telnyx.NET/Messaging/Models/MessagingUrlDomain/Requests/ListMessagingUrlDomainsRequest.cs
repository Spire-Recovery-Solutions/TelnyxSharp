using System.Text.Json.Serialization;
using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.MessagingUrlDomain.Requests
{
    public class ListMessagingUrlDomainsRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page. Default is 20.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}