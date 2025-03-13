using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberOrders
{
    /// <summary>
    /// Represents the response received after attempting to cancel a number order.
    /// </summary>
    /// <remarks>
    /// This class encapsulates the response data, including details of the canceled sub-number order, 
    /// by extending the generic <see cref="TelnyxResponse{TData}"/> class with a type of <see cref="SubNumberOrderData"/>.
    /// </remarks>
    public class CancelNumberOrderResponse : TelnyxResponse<SubNumberOrderData>
    {
    }
}
