using TelnyxSharp.Models;

namespace TelnyxSharp.Messaging.Models.MessagingHostedNumber.Responses
{
    /// <summary>
    /// Represents the response model for retrieving a hosted number order.
    /// </summary>
    public class RetrieveHostedNumberOrderResponse : TelnyxResponse<RetrieveHostedNumberOrderData>
    {
    }

    public class RetrieveHostedNumberOrderData : BaseHostedNumberOrderData
    {
    }
}