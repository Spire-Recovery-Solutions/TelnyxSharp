using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Requests
{
    public class GetHostedNumberOrderRequest : ITelnyxRequest
    {
        /// <summary>
        /// The size of the page. Default value is 20. Must be between 1 and 250.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}
