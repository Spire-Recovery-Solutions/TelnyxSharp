using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.ShortCodes
{

    public class ListShortCodesRequest : ITelnyxRequest
    {
        public int PageSize { get; set; } = 20;
        public string? MessagingProfileId { get; set; }
    }

}
