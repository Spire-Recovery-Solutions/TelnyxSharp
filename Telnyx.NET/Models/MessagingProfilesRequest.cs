using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class MessagingProfilesRequest : ITelnyxRequest
    {
        
        public int? PageSize { get; set; }
        public string? NameFilter { get; set; }
    }
}