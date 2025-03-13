using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response for listing porting activation jobs in a porting order.
    /// Inherits from <see cref="TelnyxResponse{TData}"/> with a generic type of <see cref="List{PortingActivationJob}"/>.
    /// </summary>
    public class ListPortingActivationJobsResponse : TelnyxResponse<List<PortingActivationJob>>
    {
    }
}
