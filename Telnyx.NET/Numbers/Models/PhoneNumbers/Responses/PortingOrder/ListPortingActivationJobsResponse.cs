using Telnyx.NET.Models;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing porting activation jobs in a porting order.
    /// Inherits from <see cref="TelnyxResponse{T}"/> with a generic type of <see cref="List{PortingActivationJob}"/>.
    /// </summary>
    public class ListPortingActivationJobsResponse : TelnyxResponse<List<PortingActivationJob>>
    {
    }
}
