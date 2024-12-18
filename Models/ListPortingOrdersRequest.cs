using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListPortingOrdersRequest : PortingOrdersRequest, ITelnyxRequest
    {
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public bool? IncludePhoneNumbers { get; set; }
        public string?  Sort { get; set; }
        public string?  CustomerReference { get; set; }
        public string?  Status { get; set; }
    }

    public class PortingOrdersRequest
    {
    }
}
