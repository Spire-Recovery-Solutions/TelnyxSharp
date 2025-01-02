using Telnyx.NET.Interfaces;

namespace Telnyx.NET.Models
{
    public class ListPortingPhoneNumbersRequest : PortingOrdersRequest, ITelnyxRequest
    {
        
        public int? PageSize { get; set; }
        public string? PortingOrderId { get; set; }
        public List<string>? PortingOrderIds { get; set; }
        public string? SupportKeyEq { get; set; }
        public List<string>? SupportKeyIn { get; set; }
        public string? PhoneNumber { get; set; }
        public List<string>? PhoneNumberIn { get; set; }
        public string? PortingOrderStatus { get; set; }
        public string? ActivationStatus { get; set; }
        public string? PortabilityStatus { get; set; }
    }
}