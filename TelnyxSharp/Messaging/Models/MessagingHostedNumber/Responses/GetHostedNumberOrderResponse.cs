using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses
{
    /// <summary>
    /// Represents the response for retrieving hosted number orders.
    /// </summary>
    public class GetHostedNumberOrderResponse : TelnyxResponse<List<HostedNumberOrderData>>
    {
    }

    public class HostedNumberOrderData : BaseHostedNumberOrderData
    {
    }

}
