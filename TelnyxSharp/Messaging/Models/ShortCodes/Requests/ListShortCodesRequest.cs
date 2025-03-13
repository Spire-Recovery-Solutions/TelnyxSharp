using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.ShortCodes.Requests
{

    public class ListShortCodesRequest : ITelnyxRequest
    {
        public int PageSize { get; set; } = 20;
        public string? MessagingProfileId { get; set; }
    }

}
