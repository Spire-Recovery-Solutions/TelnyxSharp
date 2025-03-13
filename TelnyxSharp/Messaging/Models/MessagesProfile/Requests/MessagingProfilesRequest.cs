using TelnyxSharp.Base;

namespace TelnyxSharp.Messaging.Models.MessagesProfile.Requests
{
    public class MessagingProfilesRequest : ITelnyxRequest
    {

        public int? PageSize { get; set; }
        public string? NameFilter { get; set; }
    }
}