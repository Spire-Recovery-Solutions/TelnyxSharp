using System.Text.Json.Serialization;
using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{

    public class ListShortCodesRequest : ITelnyxRequest
    {
        public int PageSize { get; set; } = 20;
        public string? MessagingProfileId { get; set; }
    }

}
