using Telnyx.NET.Base;

namespace Telnyx.NET.Messaging.Models.MessagesProfile
{
    public class MessagingProfilesRequest : ITelnyxRequest
    {

        public int? PageSize { get; set; }
        public string? NameFilter { get; set; }
    }
}